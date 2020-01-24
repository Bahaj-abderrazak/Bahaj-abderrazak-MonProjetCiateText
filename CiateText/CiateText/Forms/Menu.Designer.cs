namespace CiateText
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.LBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Panel();
            this.BtnSup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAjouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSelect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Pointer = new System.Windows.Forms.Panel();
            this.Contenu = new System.Windows.Forms.Panel();
            this.BtnAller = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDeconnect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            this.Right.SuspendLayout();
            this.Contenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBox
            // 
            this.LBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.LBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LBox.FormattingEnabled = true;
            this.LBox.ItemHeight = 25;
            this.LBox.Location = new System.Drawing.Point(0, 0);
            this.LBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.LBox.Name = "LBox";
            this.LBox.Size = new System.Drawing.Size(608, 400);
            this.LBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 35;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(765, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 37);
            this.Close.TabIndex = 4;
            this.Close.Text = "x";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Right.Controls.Add(this.BtnSup);
            this.Right.Controls.Add(this.BtnAjouter);
            this.Right.Controls.Add(this.BtnSelect);
            this.Right.Controls.Add(this.Pointer);
            this.Right.Dock = System.Windows.Forms.DockStyle.Left;
            this.Right.Location = new System.Drawing.Point(0, 50);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(192, 400);
            this.Right.TabIndex = 37;
            // 
            // BtnSup
            // 
            this.BtnSup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSup.BorderRadius = 0;
            this.BtnSup.ButtonText = "      Supremer un CahierText";
            this.BtnSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSup.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSup.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSup.Iconimage = null;
            this.BtnSup.Iconimage_right = null;
            this.BtnSup.Iconimage_right_Selected = null;
            this.BtnSup.Iconimage_Selected = null;
            this.BtnSup.IconMarginLeft = 0;
            this.BtnSup.IconMarginRight = 0;
            this.BtnSup.IconRightVisible = true;
            this.BtnSup.IconRightZoom = 0D;
            this.BtnSup.IconVisible = true;
            this.BtnSup.IconZoom = 90D;
            this.BtnSup.IsTab = false;
            this.BtnSup.Location = new System.Drawing.Point(12, 153);
            this.BtnSup.Name = "BtnSup";
            this.BtnSup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnSup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.BtnSup.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.BtnSup.selected = false;
            this.BtnSup.Size = new System.Drawing.Size(174, 33);
            this.BtnSup.TabIndex = 43;
            this.BtnSup.Text = "      Supremer un CahierText";
            this.BtnSup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSup.Textcolor = System.Drawing.Color.Snow;
            this.BtnSup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSup.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAjouter.BorderRadius = 0;
            this.BtnAjouter.ButtonText = "      Ajouter Un Cahier Text";
            this.BtnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAjouter.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAjouter.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAjouter.Iconimage = null;
            this.BtnAjouter.Iconimage_right = null;
            this.BtnAjouter.Iconimage_right_Selected = null;
            this.BtnAjouter.Iconimage_Selected = null;
            this.BtnAjouter.IconMarginLeft = 0;
            this.BtnAjouter.IconMarginRight = 0;
            this.BtnAjouter.IconRightVisible = true;
            this.BtnAjouter.IconRightZoom = 0D;
            this.BtnAjouter.IconVisible = true;
            this.BtnAjouter.IconZoom = 90D;
            this.BtnAjouter.IsTab = false;
            this.BtnAjouter.Location = new System.Drawing.Point(12, 114);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnAjouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.BtnAjouter.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.BtnAjouter.selected = false;
            this.BtnAjouter.Size = new System.Drawing.Size(174, 33);
            this.BtnAjouter.TabIndex = 42;
            this.BtnAjouter.Text = "      Ajouter Un Cahier Text";
            this.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjouter.Textcolor = System.Drawing.Color.Snow;
            this.BtnAjouter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BtnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.BtnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSelect.BorderRadius = 0;
            this.BtnSelect.ButtonText = "      Selectioner un Cahier Text";
            this.BtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSelect.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSelect.Iconimage = null;
            this.BtnSelect.Iconimage_right = null;
            this.BtnSelect.Iconimage_right_Selected = null;
            this.BtnSelect.Iconimage_Selected = null;
            this.BtnSelect.IconMarginLeft = 0;
            this.BtnSelect.IconMarginRight = 0;
            this.BtnSelect.IconRightVisible = true;
            this.BtnSelect.IconRightZoom = 0D;
            this.BtnSelect.IconVisible = true;
            this.BtnSelect.IconZoom = 90D;
            this.BtnSelect.IsTab = false;
            this.BtnSelect.Location = new System.Drawing.Point(12, 68);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.BtnSelect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.BtnSelect.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.BtnSelect.selected = false;
            this.BtnSelect.Size = new System.Drawing.Size(177, 33);
            this.BtnSelect.TabIndex = 41;
            this.BtnSelect.Text = "      Selectioner un Cahier Text";
            this.BtnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelect.Textcolor = System.Drawing.Color.Snow;
            this.BtnSelect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // Pointer
            // 
            this.Pointer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.Pointer.Location = new System.Drawing.Point(3, 68);
            this.Pointer.Name = "Pointer";
            this.Pointer.Size = new System.Drawing.Size(8, 33);
            this.Pointer.TabIndex = 3;
            // 
            // Contenu
            // 
            this.Contenu.Controls.Add(this.panel1);
            this.Contenu.Controls.Add(this.LBox);
            this.Contenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenu.Location = new System.Drawing.Point(192, 50);
            this.Contenu.Name = "Contenu";
            this.Contenu.Size = new System.Drawing.Size(608, 400);
            this.Contenu.TabIndex = 38;
            // 
            // BtnAller
            // 
            this.BtnAller.ActiveBorderThickness = 1;
            this.BtnAller.ActiveCornerRadius = 20;
            this.BtnAller.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAller.ActiveForecolor = System.Drawing.Color.White;
            this.BtnAller.ActiveLineColor = System.Drawing.Color.Green;
            this.BtnAller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BtnAller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAller.BackgroundImage")));
            this.BtnAller.ButtonText = "Choisi";
            this.BtnAller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAller.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAller.ForeColor = System.Drawing.Color.White;
            this.BtnAller.IdleBorderThickness = 1;
            this.BtnAller.IdleCornerRadius = 20;
            this.BtnAller.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAller.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnAller.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnAller.Location = new System.Drawing.Point(326, 2);
            this.BtnAller.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAller.Name = "BtnAller";
            this.BtnAller.Size = new System.Drawing.Size(133, 47);
            this.BtnAller.TabIndex = 2;
            this.BtnAller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAller.Click += new System.EventHandler(this.BtnAller_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDeconnect);
            this.panel1.Controls.Add(this.BtnAller);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 47);
            this.panel1.TabIndex = 1;
            // 
            // BtnDeconnect
            // 
            this.BtnDeconnect.ActiveBorderThickness = 1;
            this.BtnDeconnect.ActiveCornerRadius = 20;
            this.BtnDeconnect.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDeconnect.ActiveForecolor = System.Drawing.Color.White;
            this.BtnDeconnect.ActiveLineColor = System.Drawing.Color.Green;
            this.BtnDeconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BtnDeconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeconnect.BackgroundImage")));
            this.BtnDeconnect.ButtonText = "Déconnecté";
            this.BtnDeconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeconnect.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeconnect.ForeColor = System.Drawing.Color.White;
            this.BtnDeconnect.IdleBorderThickness = 1;
            this.BtnDeconnect.IdleCornerRadius = 20;
            this.BtnDeconnect.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnDeconnect.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnDeconnect.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnDeconnect.Location = new System.Drawing.Point(177, 2);
            this.BtnDeconnect.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDeconnect.Name = "BtnDeconnect";
            this.BtnDeconnect.Size = new System.Drawing.Size(133, 47);
            this.BtnDeconnect.TabIndex = 3;
            this.BtnDeconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeconnect.Click += new System.EventHandler(this.BtnDeconnect_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenu);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Right.ResumeLayout(false);
            this.Contenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Panel Right;
        private System.Windows.Forms.Panel Contenu;
        private System.Windows.Forms.Panel Pointer;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSelect;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAjouter;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSup;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAller;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnDeconnect;
    }
}