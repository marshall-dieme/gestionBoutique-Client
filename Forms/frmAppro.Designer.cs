namespace ClientBoutique.Forms
{
    partial class frmAppro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgProduit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnChoisir = new FontAwesome.Sharp.IconButton();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtQuantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAnnuler = new FontAwesome.Sharp.IconButton();
            this.txtQuantiteActuelle = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxUnite = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduit
            // 
            this.dgProduit.AllowUserToAddRows = false;
            this.dgProduit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgProduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduit.AutoGenerateColumns = false;
            this.dgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProduit.ColumnHeadersHeight = 21;
            this.dgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.designationProduitDataGridViewTextBoxColumn,
            this.puDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.Categorie});
            this.dgProduit.DataSource = this.produitViewModelBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduit.EnableHeadersVisualStyles = false;
            this.dgProduit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgProduit.Location = new System.Drawing.Point(405, 59);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.ReadOnly = true;
            this.dgProduit.RowHeadersVisible = false;
            this.dgProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduit.Size = new System.Drawing.Size(517, 502);
            this.dgProduit.TabIndex = 0;
            this.dgProduit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgProduit.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgProduit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgProduit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgProduit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProduit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgProduit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgProduit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgProduit.ThemeStyle.HeaderStyle.Height = 21;
            this.dgProduit.ThemeStyle.ReadOnly = true;
            this.dgProduit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgProduit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProduit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgProduit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgProduit.ThemeStyle.RowsStyle.Height = 22;
            this.dgProduit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgProduit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationProduitDataGridViewTextBoxColumn
            // 
            this.designationProduitDataGridViewTextBoxColumn.DataPropertyName = "DesignationProduit";
            this.designationProduitDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationProduitDataGridViewTextBoxColumn.Name = "designationProduitDataGridViewTextBoxColumn";
            this.designationProduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puDataGridViewTextBoxColumn
            // 
            this.puDataGridViewTextBoxColumn.DataPropertyName = "Pu";
            this.puDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.puDataGridViewTextBoxColumn.Name = "puDataGridViewTextBoxColumn";
            this.puDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "Categorie";
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            // 
            // produitViewModelBindingSource
            // 
            this.produitViewModelBindingSource.DataSource = typeof(ClientBoutique.BoutiqueRef.ProduitViewModel);
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(186)))), ((int)(((byte)(245)))));
            this.btnChoisir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoisir.FlatAppearance.BorderSize = 0;
            this.btnChoisir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoisir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnChoisir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoisir.ForeColor = System.Drawing.Color.White;
            this.btnChoisir.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnChoisir.IconColor = System.Drawing.Color.White;
            this.btnChoisir.IconSize = 20;
            this.btnChoisir.Location = new System.Drawing.Point(828, 17);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Rotation = 0D;
            this.btnChoisir.Size = new System.Drawing.Size(90, 26);
            this.btnChoisir.TabIndex = 13;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.AutoRoundedCorners = true;
            this.txtRecherche.BorderRadius = 14;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.DefaultText = "";
            this.txtRecherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.DisabledState.Parent = this.txtRecherche;
            this.txtRecherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRecherche.FocusedState.Parent = this.txtRecherche;
            this.txtRecherche.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtRecherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtRecherche.HoverState.Parent = this.txtRecherche;
            this.txtRecherche.Location = new System.Drawing.Point(421, 12);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PasswordChar = '\0';
            this.txtRecherche.PlaceholderText = "Rechercher...";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.ShadowDecoration.Parent = this.txtRecherche;
            this.txtRecherche.Size = new System.Drawing.Size(341, 31);
            this.txtRecherche.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 20;
            this.btnSave.Location = new System.Drawing.Point(25, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(124, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.AutoRoundedCorners = true;
            this.txtQuantite.BorderRadius = 14;
            this.txtQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantite.DefaultText = "";
            this.txtQuantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.DisabledState.Parent = this.txtQuantite;
            this.txtQuantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantite.FocusedState.Parent = this.txtQuantite;
            this.txtQuantite.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtQuantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantite.HoverState.Parent = this.txtQuantite;
            this.txtQuantite.Location = new System.Drawing.Point(25, 256);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.PasswordChar = '\0';
            this.txtQuantite.PlaceholderText = "Quantité à ajouter";
            this.txtQuantite.SelectedText = "";
            this.txtQuantite.ShadowDecoration.Parent = this.txtQuantite;
            this.txtQuantite.Size = new System.Drawing.Size(341, 31);
            this.txtQuantite.TabIndex = 14;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAnnuler.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnAnnuler.IconColor = System.Drawing.Color.White;
            this.btnAnnuler.IconSize = 20;
            this.btnAnnuler.Location = new System.Drawing.Point(205, 316);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Rotation = 0D;
            this.btnAnnuler.Size = new System.Drawing.Size(124, 40);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // txtQuantiteActuelle
            // 
            this.txtQuantiteActuelle.AutoRoundedCorners = true;
            this.txtQuantiteActuelle.BorderRadius = 14;
            this.txtQuantiteActuelle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiteActuelle.DefaultText = "";
            this.txtQuantiteActuelle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantiteActuelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantiteActuelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiteActuelle.DisabledState.Parent = this.txtQuantiteActuelle;
            this.txtQuantiteActuelle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiteActuelle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantiteActuelle.FocusedState.Parent = this.txtQuantiteActuelle;
            this.txtQuantiteActuelle.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtQuantiteActuelle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantiteActuelle.HoverState.Parent = this.txtQuantiteActuelle;
            this.txtQuantiteActuelle.Location = new System.Drawing.Point(25, 200);
            this.txtQuantiteActuelle.Name = "txtQuantiteActuelle";
            this.txtQuantiteActuelle.PasswordChar = '\0';
            this.txtQuantiteActuelle.PlaceholderText = "Quantité Actuelle";
            this.txtQuantiteActuelle.SelectedText = "";
            this.txtQuantiteActuelle.ShadowDecoration.Parent = this.txtQuantiteActuelle;
            this.txtQuantiteActuelle.Size = new System.Drawing.Size(341, 31);
            this.txtQuantiteActuelle.TabIndex = 16;
            // 
            // cbxUnite
            // 
            this.cbxUnite.AutoRoundedCorners = true;
            this.cbxUnite.BackColor = System.Drawing.Color.Transparent;
            this.cbxUnite.BorderRadius = 17;
            this.cbxUnite.BorderThickness = 2;
            this.cbxUnite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxUnite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnite.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxUnite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxUnite.FocusedState.Parent = this.cbxUnite;
            this.cbxUnite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxUnite.ForeColor = System.Drawing.Color.Black;
            this.cbxUnite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxUnite.HoverState.Parent = this.cbxUnite;
            this.cbxUnite.ItemHeight = 30;
            this.cbxUnite.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxUnite.ItemsAppearance.Parent = this.cbxUnite;
            this.cbxUnite.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxUnite.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxUnite.Location = new System.Drawing.Point(25, 143);
            this.cbxUnite.Name = "cbxUnite";
            this.cbxUnite.ShadowDecoration.Parent = this.cbxUnite;
            this.cbxUnite.Size = new System.Drawing.Size(341, 36);
            this.cbxUnite.TabIndex = 24;
            this.cbxUnite.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // frmAppro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 573);
            this.Controls.Add(this.cbxUnite);
            this.Controls.Add(this.txtQuantiteActuelle);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppro";
            this.Text = "Approvisionnement";
            this.Load += new System.EventHandler(this.frmAppro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgProduit;
        private System.Windows.Forms.BindingSource produitViewModelBindingSource;
        private FontAwesome.Sharp.IconButton btnChoisir;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private FontAwesome.Sharp.IconButton btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantite;
        private FontAwesome.Sharp.IconButton btnAnnuler;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantiteActuelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private Guna.UI2.WinForms.Guna2ComboBox cbxUnite;
    }
}