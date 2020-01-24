namespace CiateText
{
    partial class UserRealisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRealisation));
            this.CmbModule = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbJour = new System.Windows.Forms.ComboBox();
            this.DTPDateRailisation = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContenu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Vider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listSTG = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbModule
            // 
            this.CmbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModule.FormattingEnabled = true;
            this.CmbModule.Location = new System.Drawing.Point(172, 159);
            this.CmbModule.Name = "CmbModule";
            this.CmbModule.Size = new System.Drawing.Size(224, 21);
            this.CmbModule.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date Realisation  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Jour :";
            // 
            // CmbJour
            // 
            this.CmbJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJour.FormattingEnabled = true;
            this.CmbJour.Location = new System.Drawing.Point(172, 97);
            this.CmbJour.Name = "CmbJour";
            this.CmbJour.Size = new System.Drawing.Size(224, 21);
            this.CmbJour.TabIndex = 39;
            // 
            // DTPDateRailisation
            // 
            this.DTPDateRailisation.Checked = false;
            this.DTPDateRailisation.CustomFormat = "yyyy - MM - dd";
            this.DTPDateRailisation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDateRailisation.Location = new System.Drawing.Point(172, 222);
            this.DTPDateRailisation.Name = "DTPDateRailisation";
            this.DTPDateRailisation.ShowUpDown = true;
            this.DTPDateRailisation.Size = new System.Drawing.Size(147, 20);
            this.DTPDateRailisation.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Module  :";
            // 
            // txtContenu
            // 
            this.txtContenu.BorderColorFocused = System.Drawing.Color.WhiteSmoke;
            this.txtContenu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtContenu.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.txtContenu.BorderThickness = 3;
            this.txtContenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContenu.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtContenu.ForeColor = System.Drawing.Color.White;
            this.txtContenu.isPassword = false;
            this.txtContenu.Location = new System.Drawing.Point(36, 312);
            this.txtContenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtContenu.Name = "txtContenu";
            this.txtContenu.Size = new System.Drawing.Size(406, 169);
            this.txtContenu.TabIndex = 43;
            this.txtContenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Contenu  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(331, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 33);
            this.label4.TabIndex = 45;
            this.label4.Text = " Realisation";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(474, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Stagiaires :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listSTG);
            this.panel1.Location = new System.Drawing.Point(478, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 511);
            this.panel1.TabIndex = 48;
            // 
            // Btn_Vider
            // 
            this.Btn_Vider.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(35)))), ((int)(((byte)(117)))));
            this.Btn_Vider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Vider.BackColor = System.Drawing.Color.Magenta;
            this.Btn_Vider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Vider.BorderRadius = 0;
            this.Btn_Vider.ButtonText = "   Realisation";
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
            this.Btn_Vider.Location = new System.Drawing.Point(145, 554);
            this.Btn_Vider.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Vider.MaximumSize = new System.Drawing.Size(174, 48);
            this.Btn_Vider.MinimumSize = new System.Drawing.Size(174, 48);
            this.Btn_Vider.Name = "Btn_Vider";
            this.Btn_Vider.Normalcolor = System.Drawing.Color.Magenta;
            this.Btn_Vider.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.Btn_Vider.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Vider.selected = false;
            this.Btn_Vider.Size = new System.Drawing.Size(174, 48);
            this.Btn_Vider.TabIndex = 90;
            this.Btn_Vider.Text = "   Realisation";
            this.Btn_Vider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vider.Textcolor = System.Drawing.Color.White;
            this.Btn_Vider.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vider.Click += new System.EventHandler(this.BtnValid_Click);
            // 
            // listSTG
            // 
            this.listSTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listSTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSTG.ForeColor = System.Drawing.SystemColors.Window;
            this.listSTG.FormattingEnabled = true;
            this.listSTG.ItemHeight = 20;
            this.listSTG.Location = new System.Drawing.Point(0, 0);
            this.listSTG.Name = "listSTG";
            this.listSTG.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listSTG.Size = new System.Drawing.Size(404, 511);
            this.listSTG.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(562, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 20);
            this.label7.TabIndex = 91;
            this.label7.Text = "* Sélectionner tout les stagiaire qui Absence";
            // 
            // UserRealisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_Vider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPDateRailisation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbJour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbModule);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "UserRealisation";
            this.Size = new System.Drawing.Size(950, 653);
            this.Load += new System.EventHandler(this.UserRealisation_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbModule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbJour;
        private System.Windows.Forms.DateTimePicker DTPDateRailisation;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtContenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Vider;
        private System.Windows.Forms.ListBox listSTG;
        private System.Windows.Forms.Label label7;
    }
}
