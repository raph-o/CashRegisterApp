namespace CashRegisterApp
{
    partial class AppForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.articlesPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.productsListView = new System.Windows.Forms.ListView();
            this.chequeRadioButton = new System.Windows.Forms.RadioButton();
            this.discountButton = new System.Windows.Forms.Button();
            this.reductionLabel = new System.Windows.Forms.Label();
            this.discountUpDown = new System.Windows.Forms.NumericUpDown();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.cbRadioButton = new System.Windows.Forms.RadioButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.checkoutListView = new System.Windows.Forms.ListView();
            this.labelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gestionTab = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.articlesGridView = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.articlesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountUpDown)).BeginInit();
            this.gestionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.articlesPage);
            this.tabControl1.Controls.Add(this.gestionTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1287, 771);
            this.tabControl1.TabIndex = 0;
            // 
            // articlesPage
            // 
            this.articlesPage.Controls.Add(this.splitContainer1);
            this.articlesPage.Location = new System.Drawing.Point(4, 22);
            this.articlesPage.Name = "articlesPage";
            this.articlesPage.Padding = new System.Windows.Forms.Padding(3);
            this.articlesPage.Size = new System.Drawing.Size(1279, 745);
            this.articlesPage.TabIndex = 0;
            this.articlesPage.Text = "Articles";
            this.articlesPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.productsListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chequeRadioButton);
            this.splitContainer1.Panel2.Controls.Add(this.discountButton);
            this.splitContainer1.Panel2.Controls.Add(this.reductionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.discountUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.cashRadioButton);
            this.splitContainer1.Panel2.Controls.Add(this.cbRadioButton);
            this.splitContainer1.Panel2.Controls.Add(this.totalLabel);
            this.splitContainer1.Panel2.Controls.Add(this.validateButton);
            this.splitContainer1.Panel2.Controls.Add(this.checkoutListView);
            this.splitContainer1.Size = new System.Drawing.Size(1273, 739);
            this.splitContainer1.SplitterDistance = 900;
            this.splitContainer1.TabIndex = 0;
            // 
            // productsListView
            // 
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(4, 3);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.ShowItemToolTips = true;
            this.productsListView.Size = new System.Drawing.Size(893, 733);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.ItemActivate += new System.EventHandler(this.productsListView_ItemActivate);
            // 
            // chequeRadioButton
            // 
            this.chequeRadioButton.AutoSize = true;
            this.chequeRadioButton.Location = new System.Drawing.Point(174, 454);
            this.chequeRadioButton.Name = "chequeRadioButton";
            this.chequeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.chequeRadioButton.TabIndex = 8;
            this.chequeRadioButton.TabStop = true;
            this.chequeRadioButton.Text = "Chèque";
            this.chequeRadioButton.UseVisualStyleBackColor = true;
            // 
            // discountButton
            // 
            this.discountButton.Location = new System.Drawing.Point(344, 424);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(19, 23);
            this.discountButton.TabIndex = 7;
            this.discountButton.Text = "✓";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // reductionLabel
            // 
            this.reductionLabel.AutoSize = true;
            this.reductionLabel.Location = new System.Drawing.Point(217, 426);
            this.reductionLabel.Name = "reductionLabel";
            this.reductionLabel.Size = new System.Drawing.Size(62, 13);
            this.reductionLabel.TabIndex = 6;
            this.reductionLabel.Text = "Réduction :";
            // 
            // discountUpDown
            // 
            this.discountUpDown.Location = new System.Drawing.Point(285, 424);
            this.discountUpDown.Name = "discountUpDown";
            this.discountUpDown.Size = new System.Drawing.Size(53, 20);
            this.discountUpDown.TabIndex = 5;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(107, 454);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(61, 17);
            this.cashRadioButton.TabIndex = 4;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Espèce";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // cbRadioButton
            // 
            this.cbRadioButton.AutoSize = true;
            this.cbRadioButton.Checked = true;
            this.cbRadioButton.Location = new System.Drawing.Point(6, 454);
            this.cbRadioButton.Name = "cbRadioButton";
            this.cbRadioButton.Size = new System.Drawing.Size(95, 17);
            this.cbRadioButton.TabIndex = 3;
            this.cbRadioButton.TabStop = true;
            this.cbRadioButton.Text = "Carte Bancaire";
            this.cbRadioButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(3, 426);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(37, 13);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total :";
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(3, 477);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(360, 91);
            this.validateButton.TabIndex = 1;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // checkoutListView
            // 
            this.checkoutListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.labelColumn,
            this.priceColumn});
            this.checkoutListView.HideSelection = false;
            this.checkoutListView.Location = new System.Drawing.Point(3, 3);
            this.checkoutListView.Name = "checkoutListView";
            this.checkoutListView.Size = new System.Drawing.Size(361, 420);
            this.checkoutListView.TabIndex = 0;
            this.checkoutListView.UseCompatibleStateImageBehavior = false;
            this.checkoutListView.View = System.Windows.Forms.View.Details;
            this.checkoutListView.ItemActivate += new System.EventHandler(this.checkoutListView_ItemActivate);
            // 
            // labelColumn
            // 
            this.labelColumn.Text = "Label";
            this.labelColumn.Width = 280;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Prix";
            // 
            // gestionTab
            // 
            this.gestionTab.Controls.Add(this.refreshButton);
            this.gestionTab.Controls.Add(this.deleteButton);
            this.gestionTab.Controls.Add(this.addButton);
            this.gestionTab.Controls.Add(this.articlesGridView);
            this.gestionTab.Location = new System.Drawing.Point(4, 22);
            this.gestionTab.Name = "gestionTab";
            this.gestionTab.Padding = new System.Windows.Forms.Padding(3);
            this.gestionTab.Size = new System.Drawing.Size(1279, 745);
            this.gestionTab.TabIndex = 1;
            this.gestionTab.Text = "Gestion";
            this.gestionTab.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1196, 64);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Raffraichir";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1196, 35);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1196, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // articlesGridView
            // 
            this.articlesGridView.AllowUserToAddRows = false;
            this.articlesGridView.AllowUserToDeleteRows = false;
            this.articlesGridView.AllowUserToResizeColumns = false;
            this.articlesGridView.AllowUserToResizeRows = false;
            this.articlesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articlesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articlesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Label,
            this.Photo,
            this.Prix});
            this.articlesGridView.Location = new System.Drawing.Point(0, 0);
            this.articlesGridView.MultiSelect = false;
            this.articlesGridView.Name = "articlesGridView";
            this.articlesGridView.ReadOnly = true;
            this.articlesGridView.RowTemplate.Height = 150;
            this.articlesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articlesGridView.Size = new System.Drawing.Size(1190, 747);
            this.articlesGridView.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.HeaderText = "Label";
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            // 
            // Photo
            // 
            this.Photo.HeaderText = "Photo";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 772);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.articlesPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discountUpDown)).EndInit();
            this.gestionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articlesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage articlesPage;
        private System.Windows.Forms.TabPage gestionTab;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView articlesGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ListView checkoutListView;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.ColumnHeader labelColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.RadioButton cbRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.Label reductionLabel;
        private System.Windows.Forms.NumericUpDown discountUpDown;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.RadioButton chequeRadioButton;
    }
}

