using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiateText.DATA;
namespace CiateText
{
    public partial class Login : Form
    {
        public static db_cahier_texteEntities3 db = new db_cahier_texteEntities3();
        public Login()
        {
            InitializeComponent();
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                                 Loading 
         ---------------------------------------------------------------------------------------------------
         */
        private void Login_Load(object sender, EventArgs e)
        {
            User user = db.Users.FirstOrDefault();
            
            if(user == null)
            {
                GestionPanel(PanellCreateProfil, PanellLoign);
            }
            else
            {
                GestionPanel(PanellLoign, PanellCreateProfil);
            }

            
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                                 Designer 
         ---------------------------------------------------------------------------------------------------
         */
        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text == "username")
            {
                txtNom.Text = "";
            }

        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "username";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "username")
            {
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "username";
            }
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                             button validation Login 
         ---------------------------------------------------------------------------------------------------
         */
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if(txtNom.Text == "")
            {
                MessageBox.Show("Remplire le Login ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Entrer le Mot de Passe ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string Nom = txtNom.Text;
            string Pass = txtPass.Text;
            User user  = db.Users.Where(us => us.Login == Nom && us.Password == Pass).FirstOrDefault();
            if(user == null)
            {
                MessageBox.Show("Les Information incorrect ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            (new Accueil()).Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous les Vous Quiter", "Quiter", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                           button validation Create Profile 
         ---------------------------------------------------------------------------------------------------
         */
        private void btnCreateProfil_Click(object sender, EventArgs e)
        {
            int mtr = 0;

            /////////////// MATRTICUL
            if (string.IsNullOrWhiteSpace(TxtMatricul.Text) || !(int.TryParse(TxtMatricul.Text, out mtr)))
            {
                MessageBox.Show("Remplire Case MATRTICUL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //////////////////// Nom
            if (txtNomFormatuer.Text == "")
            {
                MessageBox.Show("Remplire Case Nom", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //////////////////////// Prenom
            if (txtPrenomFormatuer.Text == "")
            {
                MessageBox.Show("Remplire Case Prenom", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ////////////////// CIN
            if (string.IsNullOrWhiteSpace(txtCinFormateur.Text))
            {
                MessageBox.Show("Remplire Case Cin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ///////////// Login
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Remplire Case Login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /////////////// mode de Pass
            if (txtModPass.Text == "")
            {
                MessageBox.Show("Remplire Case Mot de Pass", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtConModPass.Text != txtModPass.Text)
            {
                MessageBox.Show("Confermation de mot de pass Incorrect ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             try
             {
                 Login.db.Formateurs.Add(new DATA.Formateur
                 {
                     Cin = txtCinFormateur.Text,
                     Nom = txtNomFormatuer.Text,
                     Prenom = txtPrenomFormatuer.Text,
                     Matricule = mtr
                 });
                 Login.db.Users.Add(new DATA.User
                 {
                     Login = txtLogin.Text,
                     Password = txtModPass.Text
                 });
                 Login.db.SaveChanges();
                 MessageBox.Show("Les Information Et Enregistrement ", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 GestionPanel(PanellLoign,PanellCreateProfil);
             }
             catch
             {
                 MessageBox.Show("Les Information incorrect,Error dans le Enregistrement ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                            gestion de panel
         ---------------------------------------------------------------------------------------------------
         */
        public void GestionPanel(Panel panelShow,Panel panelHide)
        {
            panelShow.Dock = DockStyle.Fill;
            panelHide.Dock = DockStyle.None;
            panelHide.Width = 0;
            panelHide.Height = 0;
        }

    }
}
