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
    public partial class UserEditProf : UserControl
    {
        public UserEditProf()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (txtOldModPss.Text == "")
            {
                MessageBox.Show("Remplire la case Mot de Pass ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtModPass.Text == "")
            {
                MessageBox.Show("Remplire la case de Nouveau", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtConModPass.Text != txtModPass.Text)
            {
                MessageBox.Show("la Confimation de mot pass Incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           try
            {
               User lg = Login.db.Users.Where(mo => mo.Password == txtOldModPss.Text).FirstOrDefault();
                
                if(lg == null)
                {
                    MessageBox.Show("Voutre dernière Mot de Pass Incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                lg.Password = txtConModPass.Text;
                Login.db.SaveChanges();
                MessageBox.Show("Le Mot de Pass et  Modifer", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("l'enregistrement de Mot de Pass ne pas Terminer ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             
        }
    }
}
