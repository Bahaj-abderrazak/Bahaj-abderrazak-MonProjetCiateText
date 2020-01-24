using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using CiateText.DATA;

namespace CiateText
{
    public partial class UserListStagiaire : UserControl
    {
        DATA.db_cahier_texteEntities3 db = new DATA.db_cahier_texteEntities3();
        int IdG;

        public UserListStagiaire()
        {
            InitializeComponent();
        }
        public UserListStagiaire(string IdGroup)
        {
            IdG = db.Groupes.Where(i => i.Nom == IdGroup).Select(i => i.NumeroGroupe).FirstOrDefault();
            InitializeComponent();
        }
        private void UserListStagiaire_Load(object sender, EventArgs e)
        {
            remplir();
            widthGrid();
        }

        private void remplir()
        {
            DGV.DataSource = (from G in db.Groupes
                              join S in db.Stagiaires on G.NumeroGroupe equals S.NumeroGroupe
                              where G.NumeroGroupe == IdG
                              select new { S.NumInscription, S.Nom, S.Prenom }).ToList();
        }

        private void widthGrid()
        {
            DGV.Columns[0].Width = 80;
            DGV.Columns[1].Width = 119;
            DGV.Columns[2].Width = 119;
        }
        private bool FindExist()
        {
            var stg = (from G in db.Groupes
                       join S in db.Stagiaires on G.NumeroGroupe equals S.NumeroGroupe
                       where G.NumeroGroupe == IdG && S.NumInscription == TxtNumInsc.Text
                       select new { S }).FirstOrDefault();
            if (stg != null)
            {
                return true;
            }
            return false;
        }
        private void BtnRechercher_OnTextChange(object sender, EventArgs e)
        {
            if (BtnRechercher.text != "Rechercher sur le Tableau")
            {
                DGV.DataSource = (from G in db.Groupes
                                  join S in db.Stagiaires on G.NumeroGroupe equals S.NumeroGroupe
                                  where G.NumeroGroupe == IdG && (S.Nom.Contains(BtnRechercher.text) || S.Prenom.Contains(BtnRechercher.text))
                                  select new { S.NumInscription, S.Nom, S.Prenom }).ToList();
            }
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtNumInsc.Text = DGV.Rows[e.RowIndex].Cells[0].Value + "";
                Txt_Nom.Text = DGV.Rows[e.RowIndex].Cells[1].Value + "";
                TxtPrenom.Text = DGV.Rows[e.RowIndex].Cells[2].Value + "";
            }
        }

        private void BtnRechercher_Enter(object sender, EventArgs e)
        {

            if (BtnRechercher.text == "Rechercher sur le Tableau")
            {
                BtnRechercher.ForeColor = Color.Khaki;
                BtnRechercher.text = "";
            }
        }

        private void BtnRechercher_Leave(object sender, EventArgs e)
        {

            if (BtnRechercher.text == "")
            {
                BtnRechercher.text = "Rechercher sur le Tableau";
                BtnRechercher.ForeColor = Color.Snow;
            }
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumInsc.Text))
            {
                MessageBox.Show("Remplir La Case Numero Inscription ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNumInsc.Focus();
                return;
            }
            if (Txt_Nom.Text == "")
            {
                MessageBox.Show("Remplir La Case Nom ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Nom.Focus();
                return;
            }
            if (TxtPrenom.Text == "")
            {
                MessageBox.Show("Remplir La Case Prenom ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPrenom.Focus();
                return;
            }
            if (FindExist())
            {
                MessageBox.Show("Ce Numero Inscription Exist Deja", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNumInsc.Focus();
                return;
            }
            try
            {
                db.Stagiaires.Add(new Stagiaire
                {
                    Nom = Txt_Nom.Text,
                    Prenom = TxtPrenom.Text,
                    NumInscription = TxtNumInsc.Text,
                    NumeroGroupe = IdG
                });
                db.SaveChanges();
                remplir();
            }
            catch
            {
                MessageBox.Show("Enregistrement ne pas Terminer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumInsc.Text))
            {
                MessageBox.Show("Remplir La Case Numero Inscription ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNumInsc.Focus();
                return;
            }
            if (Txt_Nom.Text == "")
            {
                MessageBox.Show("Remplir La Case Nom ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Nom.Focus();
                return;
            }
            if (TxtPrenom.Text == "")
            {
                MessageBox.Show("Remplir La Case Prenom ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPrenom.Focus();
                return;
            }
            if (!FindExist())
            {
                MessageBox.Show("Ce Numero d'inscription n'exist pas ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNumInsc.Focus();
                return;
            }

            try
            {
                Stagiaire stg = db.Stagiaires.Find(TxtNumInsc.Text);

                stg.Nom = Txt_Nom.Text;
                stg.Prenom = TxtPrenom.Text;
                db.SaveChanges();
                remplir();
            }
            catch
            {
                MessageBox.Show("Modifier ne pas Terminer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Btn_Vider_Click(object sender, EventArgs e)
        {
            TxtNumInsc.Text = "";
            TxtPrenom.Text = "";
            Txt_Nom.Text = "";
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TxtNumInsc.Text))
            {
                MessageBox.Show("Remplir La Case Numero Inscription ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNumInsc.Focus();
                return;
            }
           
            if (!FindExist())
            {
                MessageBox.Show("Ce Numero d'inscription n'exist pas ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNumInsc.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("voulez vous vraiment supprimer ce Stagiaire", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                db.Stagiaires.Remove(db.Stagiaires.Find(TxtNumInsc.Text));
                db.SaveChanges();
                remplir();
            }
            catch
            {
                MessageBox.Show("Supprimer ne pas Terminer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
