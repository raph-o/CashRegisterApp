using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CashRegisterApp
{
    public partial class AppForm : Form
    {
        public DbHelper DbHelper { get; private set; }

        public AppForm()
        {
            InitializeComponent();
            DbHelper = new DbHelper("database.db");
            RefreshArticles();
            RefreshArticlesList();
        }

        #region Events
        // Quand on veut ajouter un article
        private void addButton_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm(this);
            manageForm.Show();
        }

        // Quand on veut raffraichir le tableau des articles
        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshArticles();
        }

        // Quand on veut supprimer un article
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(articlesGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Il faut sélectionner la ligne à supprimer !");
                return;
            }

            Article article = GetArticleFromSelectedRow();
            if(DbHelper.RemoveArticle(article) == 1)
            {
                MessageBox.Show("Article supprimé avec succès !");
                RefreshArticles();
            }
        }

        // Quand on double click sur un item de la list des produits disponibles
        private void productsListView_ItemActivate(object sender, EventArgs e)
        {
            string label = productsListView.SelectedItems[0].Text;
            string prix = productsListView.SelectedItems[0].ToolTipText.Replace("Prix : ", "");

            ListViewItem listViewItem = new ListViewItem(label);
            listViewItem.SubItems.Add(prix);
            checkoutListView.Items.Add(listViewItem);

            CalculateTotal();
        }

        // Quand on double clique sur un item de la liste détail de la commande
        private void checkoutListView_ItemActivate(object sender, EventArgs e)
        {
            checkoutListView.Items.Remove(checkoutListView.SelectedItems[0]);
            CalculateTotal();
        }

        // Quand on veut appliquer une réduction
        private void discountButton_Click(object sender, EventArgs e)
        {
            int discount = (int)discountUpDown.Value;
            if (discount == 0)
            {
                CalculateTotal();
                return;
            }

            CalculateTotal(discount);
        }

        // Quand on valide une commande
        private void validateButton_Click(object sender, EventArgs e)
        {
            CheckoutJson checkout = new CheckoutJson();
            checkout.DateTime = DateTime.Now.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"));
            Double total = 0;
            Double.TryParse(totalLabel.Text.Replace("Total :", ""), out total);
            checkout.Total = total;
            checkout.Discount = (int)discountUpDown.Value;
            RadioButton radioButton = splitContainer1.Panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            checkout.Moyen = radioButton.Text;

            for (int i = 0; i < checkoutListView.Items.Count; i++)
            {
                ArticleJson article = new ArticleJson();
                double prix = 0;
                article.Label = checkoutListView.Items[i].Text;
                Double.TryParse(checkoutListView.Items[i].SubItems[1].Text, out prix);
                article.Prix = prix;

                checkout.Articles.Add(article);

            }

            string fileName = "commande_" + DateTime.Now.ToString("HH-mm-ss") + ".json";
            Directory.CreateDirectory("commandes");
            using (StreamWriter file = File.AppendText("commandes/" + fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, checkout);
            }

            Application.Restart();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Permet de calculer le montant total de la commande
        /// </summary>
        public void CalculateTotal()
        {
            double total = 0;
            for (int i = 0; i < checkoutListView.Items.Count; i++)
            {
                double prix;
                Double.TryParse(checkoutListView.Items[i].SubItems[1].Text, out prix);
                total += prix;
            }

            totalLabel.Text = "Total : " + total;
        }

        /// <summary>
        /// Permet de calculer le montant total de la commande en appliquant un pourcentage de réduction
        /// </summary>
        /// <param name="discount">Montant de la réduction</param>
        public void CalculateTotal(int discount)
        {
            double total = 0;
            for (int i = 0; i < checkoutListView.Items.Count; i++)
            {
                double prix;
                Double.TryParse(checkoutListView.Items[i].SubItems[1].Text, out prix);
                total += prix;
            }

            double totalDiscount = total * discount / 100;
            total -= totalDiscount;
            totalLabel.Text = "Total : " + total;
        }

        /// <summary>
        /// Permet de raffraichir la ListView des articles
        /// </summary>
        public void RefreshArticlesList()
        {
            List<Article> articles = DbHelper.GetArticles();
            ImageList imageList = new ImageList();
            int i = 0;

            articles.ForEach(article =>
            {
                string text = article.Label;
                Image photo = GetImage(article.Photo);
                imageList.Images.Add(photo);
                productsListView.Items.Add(text, i);
                productsListView.Items[i].ToolTipText = "Prix : " + article.Prix;
                i++;
            });

            imageList.ImageSize = new Size(125, 125);
            productsListView.LargeImageList = imageList;
        }

        /// <summary>
        /// Permet de raffraichir la DataGridView des articles
        /// </summary>
        public void RefreshArticles()
        {
            List<Article> articles = DbHelper.GetArticles();
            articlesGridView.Rows.Clear();

            if (articles.Count == 0) return;
            foreach (Article article in articles)
            {
                InsertNewRow(article);
            }
        }

        /// <summary>
        /// Permet la création d'une nouvelle ligne avec pour contenu les données de article
        /// </summary>
        /// <param name="article">Object Article</param>
        public void InsertNewRow(Article article)
        {
            int row = articlesGridView.Rows.Add();
            articlesGridView.Rows[row].Cells[0].Value = article.Label;
            articlesGridView.Rows[row].Cells[1].Value = GetImage(article.Photo);
            articlesGridView.Rows[row].Cells[2].Value = article.Prix;
        }

        /// <summary>
        /// Permet de créer un Article à partir des données de la ligne sélectionnée
        /// </summary>
        /// <returns>Objet Article</returns>
        public Article GetArticleFromSelectedRow()
        {
            Image img = (Image)articlesGridView.SelectedRows[0].Cells[1].Value;
            string label = (string)articlesGridView.SelectedRows[0].Cells[0].Value;
            string photo = GetBase64(img);
            string prix = (string)articlesGridView.SelectedRows[0].Cells[2].Value;
            return new Article(label, photo, prix);
        }

        /// <summary>
        /// Permet de convertir une chaîne base64 en un object Image
        /// </summary>
        /// <param name="base64">Le string base64 de l'image</param>
        /// <returns>Objet Image</returns>
        public Image GetImage(string base64)
        {
            byte[] imgBytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length))
            {
                return Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Permet de convertir une image en un string base64
        /// </summary>
        /// <param name="img">L'image que l'on veut convertir</param>
        /// <returns>Le string base64 représentant l'image</returns>
        public string GetBase64(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                byte[] imgBytes = ms.ToArray();
                return Convert.ToBase64String(imgBytes);
            }
        }

        /// <summary>
        /// Permet de convertir un tableau de bytes représentant une image en un string base64
        /// </summary>
        /// <param name="imgBytes">Le tableau de bytes de l'image</param>
        /// <returns>Le string base64 représentant l'image</returns>
        public string GetBase64(byte[] imgBytes)
        {
            return Convert.ToBase64String(imgBytes);
        }
        #endregion
    }
}
