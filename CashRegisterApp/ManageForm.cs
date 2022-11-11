using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegisterApp
{
    public partial class ManageForm : Form
    {
        private AppForm appForm {get; set;}

        public ManageForm(AppForm appForm)
        {
            InitializeComponent();
            this.appForm = appForm;
        }

        public ManageForm(AppForm appForm, Article article)
        {
            InitializeComponent();
            this.appForm = appForm;
            PopulateForm(article);
        }

        private string img = string.Empty;

        // Quand on veut choisir une image
        private void selectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Fichier image (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG;";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fileDialog.FileName;
                    img = appForm.GetBase64(File.ReadAllBytes(filePath));
                    okLabel.Visible = true;
                }
            }
        }

        // Quand on veut valider l'article que l'on vient de créer
        private void validateButton_Click(object sender, EventArgs e)
        {
            string label = labelTextBox.Text;
            string prix = priceTextBox.Text;

            // Si jamais le label est vide
            if (label.Length < 1)
            {
                MessageBox.Show("Il faut entrer un label !");
                return;
            }

            // Si jamais aucune image n'a été choisie
            if (img == string.Empty)
            {
                MessageBox.Show("Il faut sélectionner une image !");
                return;
            }

            if (prix.Length < 1)
            {
                MessageBox.Show("Il faut entrer un prix !");
                return;
            }

            Article article = new Article(label, img, prix);
            if(appForm.DbHelper.AddArticle(article) == 1)
            {
                MessageBox.Show("Article enregistré avec succès !");
            }

            appForm.InsertNewRow(article);
            appForm.RefreshArticlesList();
            ResetForm();
        }

        /// <summary>
        /// Permet de réinitialiser le formulaire à son état de base
        /// </summary>
        private void ResetForm()
        {
            labelTextBox.Text = "";
            priceTextBox.Text = "";
            okLabel.Visible = false;
            img = string.Empty;
        }

        /// <summary>
        /// Permet d'initialiser les champs avec le contenu d'un Article
        /// </summary>
        /// <param name="article">Objet Article</param>
        private void PopulateForm(Article article)
        {
            labelTextBox.Text = article.Label;
            priceTextBox.Text = article.Prix;
            img = article.Photo;
            okLabel.Visible = true;
        }
    }
}
