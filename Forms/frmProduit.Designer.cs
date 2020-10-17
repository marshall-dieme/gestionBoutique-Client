namespace ClientBoutique.Forms
{
    partial class frmProduit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnChoisir = new FontAwesome.Sharp.IconButton();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSupprimer = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtDesignation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgProduit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPrix = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantiteQritique = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantiteMinimale = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxCategorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelectimage = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.cbxUnite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
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
            this.btnChoisir.Location = new System.Drawing.Point(739, 17);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Rotation = 0D;
            this.btnChoisir.Size = new System.Drawing.Size(90, 31);
            this.btnChoisir.TabIndex = 16;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.AutoRoundedCorners = true;
            this.txtRecherche.BorderRadius = 14;
            this.txtRecherche.BorderThickness = 2;
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
            this.txtRecherche.Location = new System.Drawing.Point(369, 17);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PasswordChar = '\0';
            this.txtRecherche.PlaceholderText = "Rechercher...";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.ShadowDecoration.Parent = this.txtRecherche;
            this.txtRecherche.Size = new System.Drawing.Size(351, 31);
            this.txtRecherche.TabIndex = 15;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
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
            this.btnSupprimer.Location = new System.Drawing.Point(248, 563);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Rotation = 0D;
            this.btnSupprimer.Size = new System.Drawing.Size(115, 40);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnModifier.Location = new System.Drawing.Point(126, 563);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Rotation = 0D;
            this.btnModifier.Size = new System.Drawing.Size(102, 40);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnSave.Location = new System.Drawing.Point(4, 563);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Ajouter";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDesignation
            // 
            this.txtDesignation.AutoRoundedCorners = true;
            this.txtDesignation.BorderRadius = 14;
            this.txtDesignation.BorderThickness = 2;
            this.txtDesignation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesignation.DefaultText = "";
            this.txtDesignation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesignation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesignation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesignation.DisabledState.Parent = this.txtDesignation;
            this.txtDesignation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesignation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtDesignation.FocusedState.Parent = this.txtDesignation;
            this.txtDesignation.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtDesignation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtDesignation.HoverState.Parent = this.txtDesignation;
            this.txtDesignation.Location = new System.Drawing.Point(12, 167);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.PasswordChar = '\0';
            this.txtDesignation.PlaceholderText = "Denomination Produit";
            this.txtDesignation.SelectedText = "";
            this.txtDesignation.ShadowDecoration.Parent = this.txtDesignation;
            this.txtDesignation.Size = new System.Drawing.Size(311, 31);
            this.txtDesignation.TabIndex = 11;
            // 
            // txtCode
            // 
            this.txtCode.AutoRoundedCorners = true;
            this.txtCode.BorderRadius = 14;
            this.txtCode.BorderThickness = 2;
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
            this.txtCode.Location = new System.Drawing.Point(12, 116);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "Code Produit";
            this.txtCode.SelectedText = "";
            this.txtCode.ShadowDecoration.Parent = this.txtCode;
            this.txtCode.Size = new System.Drawing.Size(311, 31);
            this.txtCode.TabIndex = 10;
            // 
            // dgProduit
            // 
            this.dgProduit.AllowUserToAddRows = false;
            this.dgProduit.AllowUserToDeleteRows = false;
            this.dgProduit.AllowUserToResizeColumns = false;
            this.dgProduit.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgProduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProduit.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgProduit.ColumnHeadersHeight = 30;
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduit.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgProduit.EnableHeadersVisualStyles = false;
            this.dgProduit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgProduit.Location = new System.Drawing.Point(369, 60);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.RowHeadersVisible = false;
            this.dgProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduit.Size = new System.Drawing.Size(569, 540);
            this.dgProduit.TabIndex = 9;
            this.dgProduit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgProduit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgProduit.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgProduit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgProduit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgProduit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProduit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgProduit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgProduit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProduit.ThemeStyle.HeaderStyle.Height = 30;
            this.dgProduit.ThemeStyle.ReadOnly = false;
            this.dgProduit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgProduit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProduit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgProduit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgProduit.ThemeStyle.RowsStyle.Height = 22;
            this.dgProduit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgProduit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtPrix
            // 
            this.txtPrix.AutoRoundedCorners = true;
            this.txtPrix.BorderRadius = 14;
            this.txtPrix.BorderThickness = 2;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.DefaultText = "";
            this.txtPrix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.DisabledState.Parent = this.txtPrix;
            this.txtPrix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtPrix.FocusedState.Parent = this.txtPrix;
            this.txtPrix.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtPrix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtPrix.HoverState.Parent = this.txtPrix;
            this.txtPrix.Location = new System.Drawing.Point(12, 274);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.PasswordChar = '\0';
            this.txtPrix.PlaceholderText = "Prix Unitaire";
            this.txtPrix.SelectedText = "";
            this.txtPrix.ShadowDecoration.Parent = this.txtPrix;
            this.txtPrix.Size = new System.Drawing.Size(311, 31);
            this.txtPrix.TabIndex = 17;
            // 
            // txtQuantiteQritique
            // 
            this.txtQuantiteQritique.AutoRoundedCorners = true;
            this.txtQuantiteQritique.BorderRadius = 14;
            this.txtQuantiteQritique.BorderThickness = 2;
            this.txtQuantiteQritique.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiteQritique.DefaultText = "";
            this.txtQuantiteQritique.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantiteQritique.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantiteQritique.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiteQritique.DisabledState.Parent = this.txtQuantiteQritique;
            this.txtQuantiteQritique.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiteQritique.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantiteQritique.FocusedState.Parent = this.txtQuantiteQritique;
            this.txtQuantiteQritique.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtQuantiteQritique.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantiteQritique.HoverState.Parent = this.txtQuantiteQritique;
            this.txtQuantiteQritique.Location = new System.Drawing.Point(12, 325);
            this.txtQuantiteQritique.Name = "txtQuantiteQritique";
            this.txtQuantiteQritique.PasswordChar = '\0';
            this.txtQuantiteQritique.PlaceholderText = "Quantité Qritique";
            this.txtQuantiteQritique.SelectedText = "";
            this.txtQuantiteQritique.ShadowDecoration.Parent = this.txtQuantiteQritique;
            this.txtQuantiteQritique.Size = new System.Drawing.Size(311, 31);
            this.txtQuantiteQritique.TabIndex = 18;
            // 
            // txtQuantiteMinimale
            // 
            this.txtQuantiteMinimale.AutoRoundedCorners = true;
            this.txtQuantiteMinimale.BorderRadius = 14;
            this.txtQuantiteMinimale.BorderThickness = 2;
            this.txtQuantiteMinimale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiteMinimale.DefaultText = "";
            this.txtQuantiteMinimale.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantiteMinimale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantiteMinimale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiteMinimale.DisabledState.Parent = this.txtQuantiteMinimale;
            this.txtQuantiteMinimale.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantiteMinimale.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantiteMinimale.FocusedState.Parent = this.txtQuantiteMinimale;
            this.txtQuantiteMinimale.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtQuantiteMinimale.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtQuantiteMinimale.HoverState.Parent = this.txtQuantiteMinimale;
            this.txtQuantiteMinimale.Location = new System.Drawing.Point(12, 376);
            this.txtQuantiteMinimale.Name = "txtQuantiteMinimale";
            this.txtQuantiteMinimale.PasswordChar = '\0';
            this.txtQuantiteMinimale.PlaceholderText = "Quantité Minimale";
            this.txtQuantiteMinimale.SelectedText = "";
            this.txtQuantiteMinimale.ShadowDecoration.Parent = this.txtQuantiteMinimale;
            this.txtQuantiteMinimale.Size = new System.Drawing.Size(311, 31);
            this.txtQuantiteMinimale.TabIndex = 19;
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.AutoRoundedCorners = true;
            this.cbxCategorie.BackColor = System.Drawing.Color.Transparent;
            this.cbxCategorie.BorderRadius = 17;
            this.cbxCategorie.BorderThickness = 2;
            this.cbxCategorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxCategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxCategorie.FocusedState.Parent = this.cbxCategorie;
            this.cbxCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCategorie.ForeColor = System.Drawing.Color.Black;
            this.cbxCategorie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxCategorie.HoverState.Parent = this.cbxCategorie;
            this.cbxCategorie.ItemHeight = 30;
            this.cbxCategorie.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxCategorie.ItemsAppearance.Parent = this.cbxCategorie;
            this.cbxCategorie.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cbxCategorie.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxCategorie.Location = new System.Drawing.Point(12, 60);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.ShadowDecoration.Parent = this.cbxCategorie;
            this.cbxCategorie.Size = new System.Drawing.Size(311, 36);
            this.cbxCategorie.TabIndex = 1;
            // 
            // txtImage
            // 
            this.txtImage.AutoRoundedCorners = true;
            this.txtImage.BorderRadius = 14;
            this.txtImage.BorderThickness = 2;
            this.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImage.DefaultText = "";
            this.txtImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.DisabledState.Parent = this.txtImage;
            this.txtImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.Enabled = false;
            this.txtImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtImage.FocusedState.Parent = this.txtImage;
            this.txtImage.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.Control;
            this.txtImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtImage.HoverState.Parent = this.txtImage;
            this.txtImage.Location = new System.Drawing.Point(12, 427);
            this.txtImage.Name = "txtImage";
            this.txtImage.PasswordChar = '\0';
            this.txtImage.PlaceholderText = "Image";
            this.txtImage.SelectedText = "";
            this.txtImage.ShadowDecoration.Parent = this.txtImage;
            this.txtImage.Size = new System.Drawing.Size(230, 31);
            this.txtImage.TabIndex = 20;
            // 
            // btnSelectimage
            // 
            this.btnSelectimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSelectimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectimage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSelectimage.ForeColor = System.Drawing.Color.White;
            this.btnSelectimage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnSelectimage.IconColor = System.Drawing.Color.White;
            this.btnSelectimage.IconSize = 25;
            this.btnSelectimage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectimage.Location = new System.Drawing.Point(224, 427);
            this.btnSelectimage.Name = "btnSelectimage";
            this.btnSelectimage.Rotation = 0D;
            this.btnSelectimage.Size = new System.Drawing.Size(99, 31);
            this.btnSelectimage.TabIndex = 21;
            this.btnSelectimage.Text = "Importer";
            this.btnSelectimage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectimage.UseVisualStyleBackColor = false;
            this.btnSelectimage.Click += new System.EventHandler(this.btnSelectimage_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnReset.IconColor = System.Drawing.Color.White;
            this.btnReset.IconSize = 20;
            this.btnReset.Location = new System.Drawing.Point(16, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Rotation = 0D;
            this.btnReset.Size = new System.Drawing.Size(90, 26);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Effacer";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.cbxUnite.Location = new System.Drawing.Point(12, 218);
            this.cbxUnite.Name = "cbxUnite";
            this.cbxUnite.ShadowDecoration.Parent = this.cbxUnite;
            this.cbxUnite.Size = new System.Drawing.Size(311, 36);
            this.cbxUnite.TabIndex = 23;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExport.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnExport.IconColor = System.Drawing.Color.White;
            this.btnExport.IconSize = 20;
            this.btnExport.Location = new System.Drawing.Point(848, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Rotation = 0D;
            this.btnExport.Size = new System.Drawing.Size(90, 31);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Exporter";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 612);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cbxUnite);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSelectimage);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.cbxCategorie);
            this.Controls.Add(this.txtQuantiteMinimale);
            this.Controls.Add(this.txtQuantiteQritique);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dgProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduit";
            this.Text = "frmProduit";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnChoisir;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private FontAwesome.Sharp.IconButton btnSupprimer;
        private FontAwesome.Sharp.IconButton btnModifier;
        private FontAwesome.Sharp.IconButton btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtDesignation;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2DataGridView dgProduit;
        private Guna.UI2.WinForms.Guna2TextBox txtPrix;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantiteQritique;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantiteMinimale;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategorie;
        private Guna.UI2.WinForms.Guna2TextBox txtImage;
        private FontAwesome.Sharp.IconButton btnSelectimage;
        private FontAwesome.Sharp.IconButton btnReset;
        private Guna.UI2.WinForms.Guna2ComboBox cbxUnite;
        private FontAwesome.Sharp.IconButton btnExport;
    }
}