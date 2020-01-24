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
    public partial class UserEmplois : UserControl
    {
        string Nom;
        public UserEmplois()
        {
            InitializeComponent();
        }
        public UserEmplois(string NOm)
        {
            Nom = NOm;
            InitializeComponent();
        }

        private void UserEmplois_Load(object sender, EventArgs e)
        {
            LodEmplois();
            lodApropos();
        }

        private void lodApropos()
        {
            Formateur formateur = Login.db.Formateurs.FirstOrDefault();
            LblCin.Text = formateur.Cin;
            LblNom.Text = formateur.Nom;
            LblPrenom.Text = formateur.Prenom;
            LblMatr.Text = formateur.Matricule+"";
            LblDate.Text = DateTime.Now.ToShortDateString();
            LblGroup.Text = Nom;
        }

        private void LodEmplois()
        {
            LblEmplioit.Text += Nom;
            var Emp = (from G in Login.db.Groupes
                       join E in Login.db.EmploisTemps on G.NumeroGroupe equals E.NumeroGroupe
                       where G.Nom == Nom
                       select new { E.Jour, E.HeureDebut, E.HeureFin }).ToList();

            AddRwosGred();
            var item = Emp.Where(it => it.Jour == "Lundi").FirstOrDefault();
            if (item != null)
            {
                HeureFin(item.HeureDebut, item.HeureFin, 0);
            }
            item = Emp.Where(it => it.Jour == "Mardi").FirstOrDefault();
            if (item != null)
            {
                HeureFin(item.HeureDebut, item.HeureFin, 1);
            }
            item = Emp.Where(it => it.Jour == "Mercredi").FirstOrDefault();
            if (item != null)
            {
                HeureFin(item.HeureDebut, item.HeureFin, 2);
            }
            item = Emp.Where(it => it.Jour == "Jeudi").FirstOrDefault();
            if (item != null)
            {
                HeureFin(item.HeureDebut, item.HeureFin, 3);
            }
            item = Emp.Where(it => it.Jour == "Vendredi").FirstOrDefault();
            if (item != null)
            {
                HeureFin(item.HeureDebut, item.HeureFin, 4);
            }
            item = Emp.Where(it => it.Jour == "Samedi").FirstOrDefault();
            if (item != null)
            {
                HeureFin(item.HeureDebut, item.HeureFin, 5);
            }
        }
        private void AddRwosGred()
        {
            DGVemploit.Rows.Add(new string[] { "Lundi", "", "", "", "" });
            DGVemploit.Rows.Add(new string[] { "Mardi", "", "", "", "" });
            DGVemploit.Rows.Add(new string[] { "Mercredi", "", "", "", "" });
            DGVemploit.Rows.Add(new string[] { "Jeudi", "", "", "", "" });
            DGVemploit.Rows.Add(new string[] { "Vendredi", "", "", "", "" });
            DGVemploit.Rows.Add(new string[] { "Samedi", "", "", "", "" });
        }

        private void HeureFin(TimeSpan heuredebute, TimeSpan heureFin,int i)
        {
            if (heuredebute == new TimeSpan(08, 30, 00))
            {
                DGVemploit.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                if (heureFin > new TimeSpan(10, 30, 00))
                {
                    DGVemploit.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                }
            }
            else if (heuredebute == new TimeSpan(10, 30, 00))
            {
                DGVemploit.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
            }
            else if (heuredebute == new TimeSpan(13, 30, 00))
            {
                DGVemploit.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                if (heureFin > new TimeSpan(16, 30, 00))
                {
                    DGVemploit.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                }
            }
            else if (heuredebute == new TimeSpan(16, 30, 00))
            {
                DGVemploit.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
            }
        }
    }
}
