namespace CiateText
{
    partial class UserListStagiaire
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListStagiaire));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.BtnRechercher = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Ajouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Vider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Modifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtPrenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt_Nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtNumInsc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(361, 566);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(367, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 33);
            this.label4.TabIndex = 46;
            this.label4.Text = "Gestion Des Stagiaire";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.BtnRechercher);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(950, 87);
            this.panelTop.TabIndex = 47;
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnRechercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRechercher.BackgroundImage")));
            this.BtnRechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRechercher.ForeColor = System.Drawing.Color.Snow;
            this.BtnRechercher.Icon = ((System.Drawing.Image)(resources.GetObject("BtnRechercher.Icon")));
            this.BtnRechercher.Location = new System.Drawing.Point(3, 39);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(358, 42);
            this.BtnRechercher.TabIndex = 47;
            this.BtnRechercher.text = "Rechercher sur le Tableau";
            this.BtnRechercher.OnTextChange += new System.EventHandler(this.BtnRechercher_OnTextChange);
            this.BtnRechercher.Enter += new System.EventHandler(this.BtnRechercher_Enter);
            this.BtnRechercher.Leave += new System.EventHandler(this.BtnRechercher_Leave);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.DGV);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 87);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(361, 566);
            this.panelLeft.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn_Ajouter);
            this.panel1.Controls.Add(this.Btn_Vider);
            this.panel1.Controls.Add(this.Btn_Modifier);
            this.panel1.Controls.Add(this.Btn_Supprimer);
            this.panel1.Controls.Add(this.TxtPrenom);
            this.panel1.Controls.Add(this.Txt_Nom);
            this.panel1.Controls.Add(this.TxtNumInsc);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(361, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 566);
            this.panel1.TabIndex = 49;
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.Btn_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Ajouter.BackColor = System.Drawing.Color.Magenta;
            this.Btn_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ajouter.BorderRadius = 0;
            this.Btn_Ajouter.ButtonText = "Ajouter";
            this.Btn_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ajouter.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Ajouter.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Ajouter.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Ajouter.Iconimage")));
            this.Btn_Ajouter.Iconimage_right = null;
            this.Btn_Ajouter.Iconimage_right_Selected = null;
            this.Btn_Ajouter.Iconimage_Selected = null;
            this.Btn_Ajouter.IconMarginLeft = 0;
            this.Btn_Ajouter.IconMarginRight = 0;
            this.Btn_Ajouter.IconRightVisible = true;
            this.Btn_Ajouter.IconRightZoom = 0D;
            this.Btn_Ajouter.IconVisible = true;
            this.Btn_Ajouter.IconZoom = 90D;
            this.Btn_Ajouter.IsTab = false;
            this.Btn_Ajouter.Location = new System.Drawing.Point(290, 310);
            this.Btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Normalcolor = System.Drawing.Color.Magenta;
            this.Btn_Ajouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.Btn_Ajouter.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Ajouter.selected = false;
            this.Btn_Ajouter.Size = new System.Drawing.Size(140, 48);
            this.Btn_Ajouter.TabIndex = 90;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ajouter.Textcolor = System.Drawing.Color.White;
            this.Btn_Ajouter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Btn_Vider
            // 
            this.Btn_Vider.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.Btn_Vider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Vider.BackColor = System.Drawing.Color.Magenta;
            this.Btn_Vider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Vider.BorderRadius = 0;
            this.Btn_Vider.ButtonText = "Vider";
            this.Btn_Vider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Vider.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Vider.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Vider.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Vider.Iconimage")));
            this.Btn_Vider.Iconimage_right = null;
            this.Btn_Vider.Iconimage_right_Selected = null;
            this.Btn_Vider.Iconimage_Selected = null;
            this.Btn_Vider.IconMarginLeft = 0;
            this.Btn_Vider.IconMarginRight = 0;
            this.Btn_Vider.IconRightVisible = true;
            this.Btn_Vider.IconRightZoom = 0D;
            this.Btn_Vider.IconVisible = true;
            this.Btn_Vider.IconZoom = 80D;
            this.Btn_Vider.IsTab = false;
            this.Btn_Vider.Location = new System.Drawing.Point(106, 310);
            this.Btn_Vider.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Vider.Name = "Btn_Vider";
            this.Btn_Vider.Normalcolor = System.Drawing.Color.Magenta;
            this.Btn_Vider.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.Btn_Vider.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Vider.selected = false;
            this.Btn_Vider.Size = new System.Drawing.Size(140, 48);
            this.Btn_Vider.TabIndex = 89;
            this.Btn_Vider.Text = "Vider";
            this.Btn_Vider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vider.Textcolor = System.Drawing.Color.White;
            this.Btn_Vider.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vider.Click += new System.EventHandler(this.Btn_Vider_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.Btn_Modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Modifier.BackColor = System.Drawing.Color.Magenta;
            this.Btn_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Modifier.BorderRadius = 0;
            this.Btn_Modifier.ButtonText = "Modifier";
            this.Btn_Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Modifier.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Modifier.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Modifier.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Modifier.Iconimage")));
            this.Btn_Modifier.Iconimage_right = null;
            this.Btn_Modifier.Iconimage_right_Selected = null;
            this.Btn_Modifier.Iconimage_Selected = null;
            this.Btn_Modifier.IconMarginLeft = 0;
            this.Btn_Modifier.IconMarginRight = 0;
            this.Btn_Modifier.IconRightVisible = true;
            this.Btn_Modifier.IconRightZoom = 0D;
            this.Btn_Modifier.IconVisible = true;
            this.Btn_Modifier.IconZoom = 90D;
            this.Btn_Modifier.IsTab = false;
            this.Btn_Modifier.Location = new System.Drawing.Point(106, 383);
            this.Btn_Modifier.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Normalcolor = System.Drawing.Color.Magenta;
            this.Btn_Modifier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.Btn_Modifier.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Modifier.selected = false;
            this.Btn_Modifier.Size = new System.Drawing.Size(140, 48);
            this.Btn_Modifier.TabIndex = 88;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modifier.Textcolor = System.Drawing.Color.White;
            this.Btn_Modifier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.Btn_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Supprimer.BackColor = System.Drawing.Color.Magenta;
            this.Btn_Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Supprimer.BorderRadius = 0;
            this.Btn_Supprimer.ButtonText = "Supprimer";
            this.Btn_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Supprimer.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Supprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Supprimer.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Supprimer.Iconimage")));
            this.Btn_Supprimer.Iconimage_right = null;
            this.Btn_Supprimer.Iconimage_right_Selected = null;
            this.Btn_Supprimer.Iconimage_Selected = null;
            this.Btn_Supprimer.IconMarginLeft = 0;
            this.Btn_Supprimer.IconMarginRight = 0;
            this.Btn_Supprimer.IconRightVisible = true;
            this.Btn_Supprimer.IconRightZoom = 0D;
            this.Btn_Supprimer.IconVisible = true;
            this.Btn_Supprimer.IconZoom = 90D;
            this.Btn_Supprimer.IsTab = false;
            this.Btn_Supprimer.Location = new System.Drawing.Point(290, 383);
            this.Btn_Supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Normalcolor = System.Drawing.Color.Magenta;
            this.Btn_Supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.Btn_Supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Supprimer.selected = false;
            this.Btn_Supprimer.Size = new System.Drawing.Size(140, 48);
            this.Btn_Supprimer.TabIndex = 87;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Supprimer.Textcolor = System.Drawing.Color.White;
            this.Btn_Supprimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtPrenom.HintForeColor = System.Drawing.Color.White;
            this.TxtPrenom.HintText = "";
            this.TxtPrenom.isPassword = false;
            this.TxtPrenom.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtPrenom.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.TxtPrenom.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.TxtPrenom.LineThickness = 3;
            this.TxtPrenom.Location = new System.Drawing.Point(202, 188);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(302, 37);
            this.TxtPrenom.TabIndex = 56;
            this.TxtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Txt_Nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Nom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Txt_Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Txt_Nom.HintForeColor = System.Drawing.Color.White;
            this.Txt_Nom.HintText = "";
            this.Txt_Nom.isPassword = false;
            this.Txt_Nom.LineFocusedColor = System.Drawing.Color.Blue;
            this.Txt_Nom.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.Txt_Nom.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.Txt_Nom.LineThickness = 3;
            this.Txt_Nom.Location = new System.Drawing.Point(202, 122);
            this.Txt_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(302, 37);
            this.Txt_Nom.TabIndex = 55;
            this.Txt_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtNumInsc
            // 
            this.TxtNumInsc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNumInsc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNumInsc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNumInsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtNumInsc.HintForeColor = System.Drawing.Color.White;
            this.TxtNumInsc.HintText = "";
            this.TxtNumInsc.isPassword = false;
            this.TxtNumInsc.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtNumInsc.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.TxtNumInsc.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.TxtNumInsc.LineThickness = 3;
            this.TxtNumInsc.Location = new System.Drawing.Point(202, 55);
            this.TxtNumInsc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumInsc.Name = "TxtNumInsc";
            this.TxtNumInsc.Size = new System.Drawing.Size(302, 37);
            this.TxtNumInsc.TabIndex = 54;
            this.TxtNumInsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(7, 220);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(84, 13);
            this.bunifuSeparator3.TabIndex = 53;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(7, 157);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(58, 13);
            this.bunifuSeparator2.TabIndex = 52;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 86);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(179, 13);
            this.bunifuSeparator1.TabIndex = 51;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Numero Inscription :";
            // 
            // UserListStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "UserListStagiaire";
            this.Size = new System.Drawing.Size(950, 653);
            this.Load += new System.EventHandler(this.UserListStagiaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private Bunifu.Framework.UI.BunifuTextbox BtnRechercher;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPrenom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Nom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNumInsc;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Ajouter;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Vider;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Modifier;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Supprimer;
    }
}
