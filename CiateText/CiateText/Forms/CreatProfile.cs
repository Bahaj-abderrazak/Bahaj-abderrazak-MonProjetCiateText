using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiateText
{
    public partial class CreatProfile : Form
    {
        public CreatProfile()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            int mtr = 0;
            
            /////////////// MATRTICUL
            if (string.IsNullOrWhiteSpace(TxtMatricul.Text) || !(int.TryParse(TxtMatricul.Text,out mtr)))
            {
                MessageBox.Show("MATRTICUL Incorrect");
                return;
            }
            ////////////////// CIN

            if (string.IsNullOrWhiteSpace(txtCinFormateur.Text))
            {
                MessageBox.Show("Cin Incorrect", "Worning");
                return;
            }
            //////////////////// Nom
            if (txtNomFormatuer.Text == "")
            {
                MessageBox.Show("Nom Incorrect", "Worning");
                return;
            }
            //////////////////////// Prenom
            if (txtPrenomFormatuer.Text == "")
            {
                MessageBox.Show("Remplire Case Prenom", "Worning");
                return;
            }
            ///////////// Login
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Remplire Case Login ", "Worning");
                return;
            }
            /////////////// mode de Pass

            if(txtModPass.Text == "")
            {
                MessageBox.Show("Remplire Case Mot de Pass","Worning");
                return;
            }
            if (txtConModPass.Text != txtModPass.Text)
            {
                MessageBox.Show("Confermation de mot de pass Incorrect", "Worning");
                return;
            }

            try
            {
                Login.db.Formateurs.Add(new DATA.Formateur { 
                 Cin = txtCinFormateur.Text,
                 Nom = txtNomFormatuer.Text,
                 Prenom = txtPrenomFormatuer.Text,
                 Matricule = mtr 
                });
                Login.db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error dans le enregistrement des informations Formateur", "Worning");
                return;
            }


            try
            {
                Login.db.Users.Add(new  DATA.User
                {
                     Login = txtLogin.Text,
                     Password = txtModPass.Text
                });
                Login.db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error dans le enregistrement des informations Login", "Worning");
                return;
            }


            (new Login()).Show();
            this.Hide();
        }
    }
}
