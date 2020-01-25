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
    public partial class UserRealisation : UserControl
    {
        string Nom, Fill;
        public UserRealisation()
        {
            InitializeComponent();
        }
        public UserRealisation( string NomGrup,string Fill)
        {
            this.Fill = Fill;
            Nom = NomGrup;
            InitializeComponent();
        }

        private void UserRealisation_Load(object sender, EventArgs e)
        {

            ///
            /// les Joure
            /// 


            CmbJour.DataSource = (
                from G in Login.db.Groupes
                join E in Login.db.EmploisTemps on G.NumeroGroupe equals E.NumeroGroupe
                where G.Nom == Nom
                select new {E.IdET,E.Jour}
                ).ToList();
            
            CmbJour.DisplayMember = "Jour";
            CmbJour.ValueMember = "IdET";

            ///
            /// les les Module
            /// 

            CmbModule.DataSource = (from M in Login.db.Modules
                                    join MF in Login.db.ModuleFilieres on M.NumeroModule equals MF.NumeroModule
                                    where MF.CodeFiliere == Fill
                                    select new { MF.NumeroModule, M.Nom }).ToList();
            CmbModule.DisplayMember = "Nom";
            CmbModule.ValueMember = "NumeroModule";

            ///
            /// les Stagiaire
            /// 
            var list = (from G in Login.db.Groupes
                                 join S in Login.db.Stagiaires on G.NumeroGroupe equals S.NumeroGroupe
                                 where G.Nom == Nom
                                 select new {S.NumInscription,S.Nom,S.Prenom,S.NumeroGroupe,S.Realisations,S.Groupe}
                                 ).ToList();


            List<Stagiaire> stgs = new List<Stagiaire>();
            foreach (var item in list)
            {
                stgs.Add(new Stagiaire
                {
                    NumInscription = item.NumInscription,
                    Nom = item.Nom,
                    Prenom = item.Prenom,
                    NumeroGroupe =item.NumeroGroupe,
                    Groupe = item.Groupe,
                    Realisations = item.Realisations
                });
            }
            listSTG.DataSource = stgs;
            listSTG.DisplayMember = "Nom";
            listSTG.ValueMember = "NumInscription";
        }

        private void BtnValid_Click(object sender, EventArgs e)
        {
            if (CmbJour.SelectedItem == null)
            {
                MessageBox.Show("Pas de Jour Pour Realisation ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (CmbModule.SelectedItem == null)
            {
                MessageBox.Show("Pas de Model Pour Realisation ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(string.IsNullOrEmpty(txtContenu.Text))
            {
                MessageBox.Show("Remplire Case  Contenu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<Stagiaire> stgs = new List<Stagiaire>();
            if (listSTG.SelectedItems.Count == 0)
            {
                stgs = null;
                MessageBox.Show("Test");
            }
            else
            {
                foreach(var s in listSTG.SelectedItems)
                {
                    stgs.Add((Stagiaire)s);
                }
            }

            Realisation realis = new Realisation
            {
                Contenu = txtContenu.Text,
                Stagiaires = stgs,
                NumeroModule = int.Parse(CmbJour.SelectedValue + ""),
                IdET = int.Parse(CmbJour.SelectedValue + ""),
                DateRealisation = DTPDateRailisation.Value
            };
            Login.db.Realisations.Add(realis);
            Login.db.SaveChanges();
            try
            {
                Login.db.Realisations.Add(realis);
                Login.db.SaveChanges();
                MessageBox.Show(" vous avez réalisé ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error dans le enregistrement des informations ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
