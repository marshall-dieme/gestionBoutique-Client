namespace ClientBoutique.Forms
{
    partial class frmCategorie
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
            this.dgCategorie = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDenomination = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.btnSupprimer = new FontAwesome.Sharp.IconButton();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChoisir = new FontAwesome.Sharp.IconButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategorie
            // 
            this.dgCategorie.AllowUserToAddRows = false;
            this.dgCategorie.AllowUserToDeleteRows = false;
            this.dgCategorie.AllowUserToResizeColumns = false;
            this.dgCategorie.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgCategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategorie.AutoGenerateColumns = false;
            this.dgCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategorie.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCategorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCategorie.ColumnHeadersHeight = 30;
            this.dgCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeCategorieDataGridViewTextBoxColumn,
            this.denominationDataGridViewTextBoxColumn});
            this.dgCategorie.DataSource = this.categorieBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCategorie.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCategorie.EnableHeadersVisualStyles = false;
            this.dgCategorie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgCategorie.Location = new System.Drawing.Point(425, 57);
            this.dgCategorie.Name = "dgCategorie";
            this.dgCategorie.RowHeadersVisible = false;
            this.dgCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategorie.Size = new System.Drawing.Size(513, 552);
            this.dgCategorie.TabIndex = 0;
            this.dgCategorie.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgCategorie.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgCategorie.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgCategorie.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgCategorie.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgCategorie.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgCategorie.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgCategorie.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgCategorie.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgCategorie.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCategorie.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgCategorie.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgCategorie.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCategorie.ThemeStyle.HeaderStyle.Height = 30;
            this.dgCategorie.ThemeStyle.ReadOnly = false;
            this.dgCategorie.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgCategorie.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgCategorie.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgCategorie.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgCategorie.ThemeStyle.RowsStyle.Height = 22;
            this.dgCategorie.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgCategorie.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtCode
            // 
            this.txtCode.AutoRoundedCorners = true;
            this.txtCode.BorderRadius = 14;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.Parent = this.txtCode;
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtCode.FocusedState.Parent = this.txtCode;
            this.txtCode.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtCode.HoverState.Parent = this.txtCode;
            this.txtCode.Location = new System.Drawing.Point(12, 92);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "Code Categorie";
            this.txtCode.SelectedText = "";
            this.txtCode.ShadowDecoration.Parent = this.txtCode;
            this.txtCode.Size = new System.Drawing.Size(339, 31);
            this.txtCode.TabIndex = 1;
            // 
            // txtDenomination
            // 
            this.txtDenomination.AutoRoundedCorners = true;
            this.txtDenomination.BorderRadius = 14;
            this.txtDenomination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDenomination.DefaultText = "";
            this.txtDenomination.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDenomination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDenomination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDenomination.DisabledState.Parent = this.txtDenomination;
            this.txtDenomination.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDenomination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtDenomination.FocusedState.Parent = this.txtDenomination;
            this.txtDenomination.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtDenomination.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtDenomination.HoverState.Parent = this.txtDenomination;
            this.txtDenomination.Location = new System.Drawing.Point(12, 197);
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.PasswordChar = '\0';
            this.txtDenomination.PlaceholderText = "Denomination Categorie";
            this.txtDenomination.SelectedText = "";
            this.txtDenomination.ShadowDecoration.Parent = this.txtDenomination;
            this.txtDenomination.Size = new System.Drawing.Size(339, 31);
            this.txtDenomination.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(12, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Ajouter";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModifier.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModifier.IconColor = System.Drawing.Color.White;
            this.btnModifier.IconSize = 20;
            this.btnModifier.Location = new System.Drawing.Point(148, 560);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Rotation = 0D;
            this.btnModifier.Size = new System.Drawing.Size(102, 40);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSupprimer.IconColor = System.Drawing.Color.White;
            this.btnSupprimer.IconSize = 20;
            this.btnSupprimer.Location = new System.Drawing.Point(284, 560);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Rotation = 0D;
            this.btnSupprimer.Size = new System.Drawing.Size(115, 40);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.txtRecherche.Location = new System.Drawing.Point(425, 12);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PasswordChar = '\0';
            this.txtRecherche.PlaceholderText = "Rechercher...";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.ShadowDecoration.Parent = this.txtRecherche;
            this.txtRecherche.Size = new System.Drawing.Size(341, 31);
            this.txtRecherche.TabIndex = 6;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
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
            this.btnChoisir.Location = new System.Drawing.Point(832, 17);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Rotation = 0D;
            this.btnChoisir.Size = new System.Drawing.Size(90, 26);
            this.btnChoisir.TabIndex = 8;
            this.btnChoisir.Text = "s";
            this.btnChoisir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // codeCategorieDataGridViewTextBoxColumn
            // 
            this.codeCategorieDataGridViewTextBoxColumn.DataPropertyName = "CodeCategorie";
            this.codeCategorieDataGridViewTextBoxColumn.HeaderText = "Code Categorie";
            this.codeCategorieDataGridViewTextBoxColumn.Name = "codeCategorieDataGridViewTextBoxColumn";
            // 
            // denominationDataGridViewTextBoxColumn
            // 
            this.denominationDataGridViewTextBoxColumn.DataPropertyName = "Denomination";
            this.denominationDataGridViewTextBoxColumn.HeaderText = "Denomination";
            this.denominationDataGridViewTextBoxColumn.Name = "denominationDataGridViewTextBoxColumn";
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(ClientBoutique.BoutiqueRef.Categorie);
            // 
            // frmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 612);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDenomination);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dgCategorie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorie";
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.frmCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgCategorie;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2TextBox txtDenomination;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnModifier;
        private FontAwesome.Sharp.IconButton btnSupprimer;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private FontAwesome.Sharp.IconButton btnChoisir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categorieBindingSource;
    }
}