using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiateText.DATA;

namespace CiateText
{
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void Btn_Modifer_Click(object sender, EventArgs e)
        {
            if (TxtNom.Text == "")
            {
                MessageBox.Show("Remplire le Nom ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TxtPrenom.Text == "")
            {
                MessageBox.Show("Remplire le Prenom", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Formateur formateur = Login.db.Formateurs.FirstOrDefault();
                if (formateur != null)
                {
                    formateur.Nom = TxtNom.Text;
                    formateur.Prenom = TxtPrenom.Text;
                }
                Login.db.SaveChanges();
                MessageBox.Show("Les information enregistré", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Les information ne pas enregistré", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



        }
    }
}
