namespace ClientBoutique
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFacturation = new FontAwesome.Sharp.IconButton();
            this.btnCommande = new FontAwesome.Sharp.IconButton();
            this.btnAppro = new FontAwesome.Sharp.IconButton();
            this.btnProduit = new FontAwesome.Sharp.IconButton();
            this.btnCategorie = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Label();
            this.btnMax = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenu.Controls.Add(this.btnFacturation);
            this.panelMenu.Controls.Add(this.btnCommande);
            this.panelMenu.Controls.Add(this.btnAppro);
            this.panelMenu.Controls.Add(this.btnProduit);
            this.panelMenu.Controls.Add(this.btnCategorie);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 650);
            this.panelMenu.TabIndex = 0;
            // 
            // btnFacturation
            // 
            this.btnFacturation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturation.FlatAppearance.BorderSize = 0;
            this.btnFacturation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(232)))));
            this.btnFacturation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturation.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFacturation.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturation.ForeColor = System.Drawing.Color.White;
            this.btnFacturation.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnFacturation.IconColor = System.Drawing.Color.White;
            this.btnFacturation.IconSize = 32;
            this.btnFacturation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturation.Location = new System.Drawing.Point(0, 341);
            this.btnFacturation.Name = "btnFacturation";
            this.btnFacturation.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFacturation.Rotation = 0D;
            this.btnFacturation.Size = new System.Drawing.Size(250, 60);
            this.btnFacturation.TabIndex = 5;
            this.btnFacturation.Text = "Facturation";
            this.btnFacturation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturation.UseVisualStyleBackColor = true;
            this.btnFacturation.Click += new System.EventHandler(this.btnFacturation_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(232)))));
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCommande.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.White;
            this.btnCommande.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnCommande.IconColor = System.Drawing.Color.White;
            this.btnCommande.IconSize = 32;
            this.btnCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommande.Location = new System.Drawing.Point(0, 281);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCommande.Rotation = 0D;
            this.btnCommande.Size = new System.Drawing.Size(250, 60);
            this.btnCommande.TabIndex = 4;
            this.btnCommande.Text = "Commande";
            this.btnCommande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnAppro
            // 
            this.btnAppro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppro.FlatAppearance.BorderSize = 0;
            this.btnAppro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(232)))));
            this.btnAppro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAppro.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppro.ForeColor = System.Drawing.Color.White;
            this.btnAppro.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnAppro.IconColor = System.Drawing.Color.White;
            this.btnAppro.IconSize = 32;
            this.btnAppro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppro.Location = new System.Drawing.Point(0, 221);
            this.btnAppro.Name = "btnAppro";
            this.btnAppro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAppro.Rotation = 0D;
            this.btnAppro.Size = new System.Drawing.Size(250, 60);
            this.btnAppro.TabIndex = 3;
            this.btnAppro.Text = "Approvisionnement";
            this.btnAppro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppro.UseVisualStyleBackColor = true;
            this.btnAppro.Click += new System.EventHandler(this.btnAppro_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduit.FlatAppearance.BorderSize = 0;
            this.btnProduit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(232)))));
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProduit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.ForeColor = System.Drawing.Color.White;
            this.btnProduit.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnProduit.IconColor = System.Drawing.Color.White;
            this.btnProduit.IconSize = 32;
            this.btnProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduit.Location = new System.Drawing.Point(0, 161);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProduit.Rotation = 0D;
            this.btnProduit.Size = new System.Drawing.Size(250, 60);
            this.btnProduit.TabIndex = 2;
            this.btnProduit.Text = "Produit";
            this.btnProduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduit.UseVisualStyleBackColor = true;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // btnCategorie
            // 
            this.btnCategorie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorie.FlatAppearance.BorderSize = 0;
            this.btnCategorie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(232)))));
            this.btnCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCategorie.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.White;
            this.btnCategorie.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCategorie.IconColor = System.Drawing.Color.White;
            this.btnCategorie.IconSize = 32;
            this.btnCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorie.Location = new System.Drawing.Point(0, 101);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCategorie.Rotation = 0D;
            this.btnCategorie.Size = new System.Drawing.Size(250, 60);
            this.btnCategorie.TabIndex = 1;
            this.btnCategorie.Text = "Categorie";
            this.btnCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorie.UseVisualStyleBackColor = true;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 38);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMin.Location = new System.Drawing.Point(884, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 20);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "O";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.AutoSize = true;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMax.Location = new System.Drawing.Point(906, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(22, 20);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "O";
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(928, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "O";
            this.btnClose.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 38);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(950, 612);
            this.panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boutique";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label btnMin;
        private System.Windows.Forms.Label btnMax;
        private FontAwesome.Sharp.IconButton btnCategorie;
        private FontAwesome.Sharp.IconButton btnFacturation;
        private FontAwesome.Sharp.IconButton btnCommande;
        private FontAwesome.Sharp.IconButton btnAppro;
        private FontAwesome.Sharp.IconButton btnProduit;
        private System.Windows.Forms.Panel panelContent;
    }
}

