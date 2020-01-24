namespace CiateText
{
    partial class UserEmplois
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVemploit = new System.Windows.Forms.DataGridView();
            this.Jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tim8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblEmplioit = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCin = new System.Windows.Forms.Label();
            this.LblMatr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblGroup = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVemploit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, -6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 31);
            this.label5.TabIndex = 75;
            this.label5.Text = "Emplois de Temps";
            // 
            // DGVemploit
            // 
            this.DGVemploit.AllowUserToAddRows = false;
            this.DGVemploit.AllowUserToDeleteRows = false;
            this.DGVemploit.AllowUserToResizeColumns = false;
            this.DGVemploit.AllowUserToResizeRows = false;
            this.DGVemploit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVemploit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGVemploit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVemploit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jour,
            this.Tim8,
            this.Time10,
            this.Time13,
            this.Time16});
            this.DGVemploit.GridColor = System.Drawing.SystemColors.ControlText;
            this.DGVemploit.Location = new System.Drawing.Point(6, 53);
            this.DGVemploit.Name = "DGVemploit";
            this.DGVemploit.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVemploit.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.DGVemploit.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGVemploit.Size = new System.Drawing.Size(748, 175);
            this.DGVemploit.TabIndex = 76;
            // 
            // Jour
            // 
            this.Jour.HeaderText = "Jour";
            this.Jour.Name = "Jour";
            this.Jour.ReadOnly = true;
            this.Jour.Width = 140;
            // 
            // Tim8
            // 
            this.Tim8.HeaderText = "08 : 30 - 10 : 30";
            this.Tim8.Name = "Tim8";
            this.Tim8.ReadOnly = true;
            this.Tim8.Width = 140;
            // 
            // Time10
            // 
            this.Time10.HeaderText = "10 : 30 - 13 : 30";
            this.Time10.Name = "Time10";
            this.Time10.ReadOnly = true;
            this.Time10.Width = 140;
            // 
            // Time13
            // 
            this.Time13.HeaderText = "13 : 30 - 16 : 30";
            this.Time13.Name = "Time13";
            this.Time13.ReadOnly = true;
            this.Time13.Width = 140;
            // 
            // Time16
            // 
            this.Time16.HeaderText = "16 : 30 - 18 : 30";
            this.Time16.Name = "Time16";
            this.Time16.ReadOnly = true;
            this.Time16.Width = 140;
            // 
            // LblEmplioit
            // 
            this.LblEmplioit.AutoSize = true;
            this.LblEmplioit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LblEmplioit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmplioit.ForeColor = System.Drawing.Color.Blue;
            this.LblEmplioit.Location = new System.Drawing.Point(255, 10);
            this.LblEmplioit.Name = "LblEmplioit";
            this.LblEmplioit.Size = new System.Drawing.Size(86, 24);
            this.LblEmplioit.TabIndex = 77;
            this.LblEmplioit.Text = "Groupe ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 36);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(418, 10);
            this.bunifuSeparator1.TabIndex = 78;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVemploit);
            this.groupBox1.Controls.Add(this.bunifuSeparator1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblEmplioit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 238);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " À propos de Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LblGroup);
            this.groupBox2.Controls.Add(this.LblPrenom);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.LblNom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LblMatr);
            this.groupBox2.Controls.Add(this.LblCin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 301);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = " À propos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "Matricule :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Cin :";
            // 
            // LblCin
            // 
            this.LblCin.AutoSize = true;
            this.LblCin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LblCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCin.ForeColor = System.Drawing.Color.White;
            this.LblCin.Location = new System.Drawing.Point(308, 141);
            this.LblCin.Name = "LblCin";
            this.LblCin.Size = new System.Drawing.Size(156, 18);
            this.LblCin.TabIndex = 78;
            this.LblCin.Text = " À propos de Group";
            // 
            // LblMatr
            // 
            this.LblMatr.AutoSize = true;
            this.LblMatr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LblMatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatr.ForeColor = System.Drawing.Color.White;
            this.LblMatr.Location = new System.Drawing.Point(308, 96);
            this.LblMatr.Name = "LblMatr";
            this.LblMatr.Size = new System.Drawing.Size(156, 18);
            this.LblMatr.TabIndex = 79;
            this.LblMatr.Text = " À propos de Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(170, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 80;
            this.label7.Text = "Nom :";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.ForeColor = System.Drawing.Color.White;
            this.LblNom.Location = new System.Drawing.Point(308, 191);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(156, 18);
            this.LblNom.TabIndex = 81;
            this.LblNom.Text = " À propos de Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(170, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 82;
            this.label9.Text = "Prenom :";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrenom.ForeColor = System.Drawing.Color.White;
            this.LblPrenom.Location = new System.Drawing.Point(308, 239);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(156, 18);
            this.LblPrenom.TabIndex = 83;
            this.LblPrenom.Text = " À propos de Group";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(808, 635);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(156, 18);
            this.LblDate.TabIndex = 84;
            this.LblDate.Text = " À propos de Group";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(726, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "Le Date :";
            // 
            // LblGroup
            // 
            this.LblGroup.AutoSize = true;
            this.LblGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGroup.ForeColor = System.Drawing.Color.White;
            this.LblGroup.Location = new System.Drawing.Point(308, 52);
            this.LblGroup.Name = "LblGroup";
            this.LblGroup.Size = new System.Drawing.Size(156, 18);
            this.LblGroup.TabIndex = 86;
            this.LblGroup.Text = " À propos de Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(170, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 87;
            this.label8.Text = "le Group :";
            // 
            // UserEmplois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDate);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserEmplois";
            this.Size = new System.Drawing.Size(950, 653);
            this.Load += new System.EventHandler(this.UserEmplois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVemploit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVemploit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tim8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time16;
        private System.Windows.Forms.Label LblEmplioit;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblMatr;
        private System.Windows.Forms.Label LblCin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblGroup;
        private System.Windows.Forms.Label label4;
    }
}
