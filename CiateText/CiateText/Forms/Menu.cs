using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using CiateText.DATA;

namespace CiateText
{
    public partial class Accueil : Form
    {
        public static string CodF;
        db_cahier_texteEntities3 db = new db_cahier_texteEntities3();
        public Accueil() => InitializeComponent();

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous les Vous Quiter", "Quiter", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new CreateCahierTexte()).ShowDialog();
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            LBox.DataSource = (from G in db.Groupes
                               join A in db.Affectations on G.NumeroGroupe equals A.NumeroGroupe
                               join M in db.Modules on A.NumeroModule equals M.NumeroModule
                               join MF in db.ModuleFilieres on M.NumeroModule equals MF.NumeroModule
                               select new { MF.CodeFiliere, G.Nom }).Distinct().ToList();
            LBox.DisplayMember = "Nom";
            LBox.ValueMember = "CodeFiliere";
        }

        private void BtnAller_Click(object sender, EventArgs e)
        {
            new Main(LBox.Text , LBox.SelectedValue+"").Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Pointer.Top = 153;

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Pointer.Top = 68;
        }

        private void BtnDeconnect_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
