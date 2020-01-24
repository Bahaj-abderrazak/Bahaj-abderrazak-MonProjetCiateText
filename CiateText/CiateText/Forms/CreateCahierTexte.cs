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
    public partial class CreateCahierTexte : Form
    {

        int IdEttab, IdDR , IdGroup,Mtr, IdMF, annee;
        string CodF;
        public CreateCahierTexte()
        {
            InitializeComponent();
        }
        private void CreateCahierTexte_Load(object sender, EventArgs e)
        {
            Mtr = Login.db.Formateurs.Select(u => u.Matricule).FirstOrDefault();
            Etap1_Load();
        }

        /*
        ----------------------------------------------------------------------------------------------------------
                                                               ETAPE 1/3
        ----------------------------------------------------------------------------------------------------------
       
         ---------------------------------------------------------------------------------------------------
                                                                  Load 
         ---------------------------------------------------------------------------------------------------
         */

        private void Etap1_Load()
        {
            GestionPanel(PanellEtap1, PanellEtap2, PanellEtap3);
            ///Derction Regionall
            CmbDrection.DataSource = Login.db.DirectionRegionales.ToList();
            CmbDrection.DisplayMember = "Nom";
            CmbDrection.ValueMember = "IdDr";
            ///Etablessment
            CmbEtablessment.DataSource = Login.db.Etablissements.ToList();
            CmbEtablessment.DisplayMember = "Nom";
            CmbEtablessment.ValueMember = "IdEtablissement";
            ///ModFormation
            CmbModFourm.DataSource = Login.db.ModeFormations.ToList();
            CmbModFourm.DisplayMember = "Nom";
            CmbModFourm.ValueMember = "IdMF";
            ///TypeFormation
            CmbTypFormateur.DataSource = Login.db.TypeFormations.ToList();
            CmbTypFormateur.DisplayMember = "Nom";
            CmbTypFormateur.ValueMember = "IdTF";
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                                     Les Radoi Direction Regoinall 
         ---------------------------------------------------------------------------------------------------
         */

        private void RDCreateDirectionREgoinall_CheckedChanged(object sender, EventArgs e)
        {
            CmbDrection.Enabled = false;
            TxtAddressDR.Enabled = true;
            TxtNomDR.Enabled = true;
        }
        private void RDSelectDirectionREgoinall_CheckedChanged(object sender, EventArgs e)
        {
            CmbDrection.Enabled = true;
            TxtAddressDR.Enabled = false;
            TxtNomDR.Enabled = false;
        }

        /*
         ---------------------------------------------------------------------------------------------------
                                                      Les Radoi Etablessment
         ---------------------------------------------------------------------------------------------------
         */

        private void RDSelectEtablessment_CheckedChanged(object sender, EventArgs e)
        {
            CmbEtablessment.Enabled = true;
            TxtAdressET.Enabled = false;
            TxtNomEt.Enabled = false;
        }

        private void RDCreateEtablessment_CheckedChanged(object sender, EventArgs e)
        {
            CmbEtablessment.Enabled = false;
            TxtAdressET.Enabled = true;
            TxtNomEt.Enabled = true;
        }

        /*
         ---------------------------------------------------------------------------------------------------
                                                     Button validation 
         ---------------------------------------------------------------------------------------------------
         */

        private void ValideEtap1_Click(object sender, EventArgs e)
        {

            /// Pour Le Direction Regionale
            if (GBFilier.Enabled == true)
            {
                if (RDCreate.Checked)
                {
                    if (TxtAddressDR.Text == "") { MessageBox.Show("Remplir la Case Adresse Direction Regionales", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    if (TxtNomDR.Text == "") { MessageBox.Show("Remplir la Case Nom Direction Regionales", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    try
                    {
                        Login.db.DirectionRegionales.Add(new DirectionRegionale
                        {
                            Nom = TxtNomDR.Text,
                            Adresse = TxtAddressDR.Text
                        });
                        Login.db.SaveChanges();
                        GBFilier.Enabled = false;
                        IdDR = Login.db.DirectionRegionales.Where(i => i.Nom == TxtNomDR.Text).Select(i => i.IdDr).FirstOrDefault();

                    }
                    catch
                    {
                        MessageBox.Show("Error dans l'enregistrement des informations Derction Regoinall ,Ce Derction Regoinall deja Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else
                {
                    if (CmbDrection.Items.Count == 0)
                    {
                        MessageBox.Show("Pas De Items dans La direction Regoinall","Worning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    IdDR = int.Parse(CmbDrection.SelectedValue + "");
                }
            }

            /// /// /// /// Pour Le Etablissement

            if (Etablissement.Enabled == true)
            {
                if (RDCreateEtab.Checked)
                {
                    if (TxtAdressET.Text == "") { MessageBox.Show("Remplir le Case Adresse Etablessment", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    if (TxtNomEt.Text == "") { MessageBox.Show("Remplir le Case Nom Etablessment", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }


                    try
                    {
                        Login.db.Etablissements.Add(new Etablissement
                        {
                            Nom = TxtNomEt.Text,
                            Adresse = TxtAdressET.Text,
                            IdDr = IdDR
                        });
                        Login.db.SaveChanges();
                        Etablissement.Enabled = false;
                        IdEttab = Login.db.Etablissements.Where(i => i.Nom == TxtNomEt.Text).Select(i => i.IdEtablissement).FirstOrDefault();
                    }
                    catch
                    {

                        MessageBox.Show("Error dans l'enregistrement des informations Etablissement ,Ce Etablissement deja Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    if (CmbDrection.Items.Count == 0)
                    {
                        MessageBox.Show("Pas De Items dans La Etablissement", "Warning");
                        return;
                    }
                    IdEttab = int.Parse(CmbEtablessment.SelectedValue + "");
                }
            }


            /// /// /// Pour Le Group

            if (TxtNomGroup.Text == "")
            {
                MessageBox.Show("Remplir La Case Nom de Groupe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           try
            {
                annee =  int.Parse(CmbGroupDate.Text);

                Login.db.Groupes.Add(new Groupe
                {
                    Annee = annee,
                    IdMF = int.Parse(CmbModFourm.SelectedValue + ""),
                    IdTF = int.Parse(CmbTypFormateur.SelectedValue + ""),
                    Nom = TxtNomGroup.Text,
                    IdEtablissement = IdEttab
                });
                Login.db.SaveChanges();
                IdGroup = Login.db.Groupes.Where(u => u.Nom == TxtNomGroup.Text).Select(u => u.NumeroGroupe).FirstOrDefault();
                IdMF = int.Parse(CmbModFourm.SelectedValue + "");
                Etap2_Load();
            }
            catch
            {
                MessageBox.Show(" Ce groupe deja Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        /*
        ----------------------------------------------------------------------------------------------------------
                                                                ETAPE 2/3
        ----------------------------------------------------------------------------------------------------------
        
        
         ---------------------------------------------------------------------------------------------------
                                                             Load
         ---------------------------------------------------------------------------------------------------
         */

        private void Etap2_Load()
        {
            GestionPanel(PanellEtap2, PanellEtap1, PanellEtap3);
            //Comobox Niveaux
            CmbNeveau.DataSource = Login.db.Niveaux.ToList();
            CmbNeveau.DisplayMember = "Nom";
            CmbNeveau.ValueMember = "CodeNiveau";
            //Comobox Filiere
            CmbFilier.DataSource = Login.db.Filieres.ToList();
            CmbFilier.DisplayMember = "Nom";
            CmbFilier.ValueMember = "CodeFiliere";
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                                     Remplir la liste de Module  
         ---------------------------------------------------------------------------------------------------
         */

        private void ListboxRempli()
        {
           
            ListModule.DataSource = Login.db.Modules.ToList();
            ListModule.DisplayMember = "Nom";
            ListModule.ValueMember = "NumeroModule";
        }
       
        /*
        ---------------------------------------------------------------------------------------------------
                                               Button Fillier
        ---------------------------------------------------------------------------------------------------
        */

        private void BtnFillier_Click(object sender, EventArgs e)
        {
            if (RDCreateFilier.Checked)
            {
                if (TxtNomFilier.Text == "") { MessageBox.Show("Remplir la Case Nom Filiere", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (TxtCodeFiliere.Text == "") { MessageBox.Show("Remplir la Case Code Filiere", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                try
                {
                    Login.db.Filieres.Add(new Filiere
                    {
                        Nom = TxtNomFilier.Text,
                        CodeFiliere = TxtCodeFiliere.Text,
                        CodeNiveau = CmbNeveau.SelectedValue + ""
                    });
                    Login.db.SaveChanges();
                    CodF = Login.db.Filieres.Where(i => i.Nom == TxtNomFilier.Text).Select(i => i.CodeFiliere).FirstOrDefault();
                    MessageBox.Show("CodF" + CodF);
                }
                catch
                {
                    MessageBox.Show("Error dans le enregistrement des informations  Filiere, Ce Fillier deja Exist", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                CodF = CmbFilier.SelectedValue + "";
                ListboxRempli();
            }

            GBModule.Visible = true;
            BtnFilier.Visible = false;
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                                Les Radoi Filier
         ---------------------------------------------------------------------------------------------------
         */

        private void RFSelectFillier_CheckedChanged(object sender, EventArgs e)
        {
            TxtNomFilier.Enabled = false;
            CmbFilier.Enabled = true;
        }

        private void RDCreateFillier_CheckedChanged(object sender, EventArgs e)
        {
            TxtNomFilier.Enabled = true;
            CmbFilier.Enabled = false;
        }
        /*
         ---------------------------------------------------------------------------------------------------
                                                Ajouter Des Module
         ---------------------------------------------------------------------------------------------------
         */

        private void AddModule_Click(object sender, EventArgs e)
        {
            if (TxtNomModule.Text == "")
            {
                MessageBox.Show("Remplir La Case Nom Module", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TxtCodModule.Text == "")
            {
                MessageBox.Show("Remplir La Case Code  Module", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Login.db.Modules.Add(new Module
                {
                    CodeModule = TxtCodModule.Text,
                    Nom = TxtNomModule.Text,
                    
                });
                Login.db.SaveChanges();
                MessageBox.Show("Vous avez Ajouter ce Module", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListboxRempli();
            }
            catch
            {
                MessageBox.Show("Error dans le enregistrement de Module Ce Model deja Exist ", "Worning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }

        /*
        ---------------------------------------------------------------------------------------------------
                                               Button validation  
        ---------------------------------------------------------------------------------------------------
        */


        private void ValideEtape2_Click_1(object sender, EventArgs e)
        {
            
            Etap3_Load();
        }
        /*
        ----------------------------------------------------------------------------------------------------------
                                                               ETAPE 3/3
        ----------------------------------------------------------------------------------------------------------
       
         ---------------------------------------------------------------------------------------------------
                                                                Load
         ---------------------------------------------------------------------------------------------------
         */

        private void Etap3_Load()
        {
            GestionPanel(PanellEtap3, PanellEtap2, PanellEtap1);
            MessageBox.Show(CodF);
            CmbMonModuls.DataSource = Login.db.Modules.ToList();
            CmbMonModuls.DisplayMember = "Nom";
            CmbMonModuls.ValueMember = "NumeroModule";

            RemplirlistviewV2();

        }

        private void RemplirlistviewV2()
        {
            ListMonModuls.DataSource = (from M in Login.db.Modules
                                        join MF in Login.db.ModuleFilieres on M.NumeroModule equals MF.NumeroModule
                                        where MF.CodeFiliere == CodF
                                        select new { MF.NumeroModule, M.Nom }).ToList();
            ListMonModuls.DisplayMember = "Nom";
            ListMonModuls.ValueMember = "NumeroModule";
        }

        /*
         ---------------------------------------------------------------------------------------------------
                                                Ajouter Des Module a Mon List
         ---------------------------------------------------------------------------------------------------
         */

        private void BtnAyuterAModuleMonList_Click(object sender, EventArgs e)
        {
            /// pour Affection
            int NumeroModule = int.Parse(CmbMonModuls.SelectedValue + "");
            try
            {
                int annee = int.Parse(CmbGroupDate.Text);

                Login.db.Affectations.Add(new Affectation
                {
                    Annee = annee,
                    Matricule = Mtr,
                    NumeroGroupe = IdGroup,
                    NumeroModule = NumeroModule
                });
                Login.db.SaveChanges();
            }
            catch
            {
                MessageBox.Show(" Error dans enrestrer les info mdule", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int MasH;
            if (TxtMassHataire.Text == "" || !(int.TryParse(TxtMassHataire.Text, out MasH)))
            {
                MessageBox.Show("des Mass Hataire incorrect", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int an;

            if (RD_1er.Checked) an = 1; else if (RD_2em.Checked) an = 2; else an = 3;

            try
            {

                Login.db.ModuleFilieres.Add(new ModuleFiliere
                {
                    Annee = an,
                    MasseHoraire = MasH,
                    CodeFiliere =  CodF,
                    NumeroModule = NumeroModule,
                    
                        
                });
                Login.db.SaveChanges();
                ListMonModuls.Items.Add(new { nom = CmbMonModuls.Text + " :   Masse Horaire : " + TxtMassHataire.Text});
                RemplirlistviewV2();
            }
            catch
            {
            }

        }

        /*
          ----------------------------------------- --------------------------------------------------------
                                            Button validation 
          --------------------------------------------------------------------------------------------------
         */

        private void ValideEtape3_Click(object sender, EventArgs e)
        {
            ///Pour Emploit
            bool valid = false;

            if (checkedTest()==false)
            {
                MessageBox.Show("Au moins Sélectionner un Joure", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                valid = Enrestrer(Chlu, DTPLUD, DTPLUF, "Lundi")|| valid;
                valid = Enrestrer(CHma, DTPMAD, DTPMAF, "Mardi") || valid;
                valid = Enrestrer(Chme, DTPMED, DTPMEF, "Mercredi") || valid;
                valid = Enrestrer(CHje, DTPJED, DTPJEF, "Jeudi") || valid;
                valid = Enrestrer(Chva, DTPVED, DTPVEF, "Vendredi") || valid;
                valid = Enrestrer(CHsa, DTPSAD, DTPSAF, "Samedi") || valid;

                if(valid == false)
                {
                    MessageBox.Show("Error dans Les Condition de Emplois Temps lire les Remarque", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Login.db.SaveChanges();
            }
             catch
            {
                MessageBox.Show("Error Dans l'enregistrement des info de le Emplois Temps");
                return;
            }
            MessageBox.Show("Le Cahier  et Created", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
         /*
         ---------------------------------------------------------------------------------------------------
                                                           DATE TIME PICKER
         ---------------------------------------------------------------------------------------------------
         */
        private bool Enrestrer(BunifuCheckbox CHEK ,DateTimePicker DTPD, DateTimePicker DTPF,string jour)
        {
            
            if(CHEK.Checked && checkedTest())
            {
                if (TestTime(DTPD, DTPF))
                {

                    Login.db.EmploisTemps.Add(new EmploisTemp
                    {
                        NumeroGroupe = IdGroup,
                        IdET = IdEttab,
                        HeureDebut = new TimeSpan(DTPD.Value.Hour, DTPD.Value.Minute, DTPD.Value.Second),
                        HeureFin = new TimeSpan(DTPF.Value.Hour, DTPF.Value.Minute, DTPF.Value.Second),
                        Jour = jour,
                        Matricule = Mtr

                    });
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            
            return false ;
        }

        private bool checkedTest()
        {
            foreach(Control checkbox in this.gb3.Controls)
            {
                if(checkbox is  BunifuCheckbox && ((BunifuCheckbox)checkbox).Checked)
                {
                    return true;
                }
            }
            return false;
        }

        private bool TestTime(DateTimePicker DTPD, DateTimePicker DTPF)
        {
            if(DTPD.Value.Hour > DTPF.Value.Hour)
            {
                return false;
            }

            TimeSpan TSF = new TimeSpan(DTPF.Value.Hour, DTPF.Value.Minute, DTPF.Value.Second);
            TimeSpan TSD = new TimeSpan(DTPD.Value.Hour, DTPD.Value.Minute, DTPD.Value.Second);

            if(TSD > new TimeSpan(16, 30, 00) || TSD < new TimeSpan(08, 30, 00))
            {
                return false;
            }
            if ( TSF> new TimeSpan(18, 30, 00) || TSF < new TimeSpan(10, 30, 00))
            {
                return false;
            }
            if(TSD == TSF)
            {
                return false;
            }

            return true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Vous les Vous Quiter", "Quiter", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        /*
         ---------------------------------------------------------------------------------------------------
                                                THE CHACKBOX GESTION
         ---------------------------------------------------------------------------------------------------
         */

        private void Chlu_OnChange(object sender, EventArgs e)
        {
            DTPLUD.Enabled = Chlu.Checked;
            DTPLUF.Enabled = Chlu.Checked;
        }

        private void CHma_OnChange(object sender, EventArgs e)
        {
            DTPMAD.Enabled = CHma.Checked;
            DTPMAF.Enabled = CHma.Checked;
        }

        private void Chme_OnChange(object sender, EventArgs e)
        {
            DTPMED.Enabled = Chme.Checked;
            DTPMEF.Enabled = Chme.Checked;
        }

        private void CHje_OnChange(object sender, EventArgs e)
        {
            DTPJED.Enabled = CHje.Checked;
            DTPJEF.Enabled = CHje.Checked;
        }

        private void Chva_OnChange(object sender, EventArgs e)
        {
            DTPVED.Enabled = Chva.Checked;
            DTPVEF.Enabled = Chva.Checked;
        }

        private void CHsa_OnChange(object sender, EventArgs e)
        {
            DTPSAD.Enabled = CHsa.Checked;
            DTPSAF.Enabled = CHsa.Checked;
        }

        /*
        ---------------------------------------------------------------------------------------------------
                                                         GESTION Panell
        ---------------------------------------------------------------------------------------------------
        */
        private void GestionPanel(Panel panelShow,Panel panelHid1, Panel PanelHid2)
        {
            panelHid1.Dock = DockStyle.None;
            panelHid1.Width = 0;
            panelHid1.Height = 0;

            PanelHid2.Dock = DockStyle.None;
            PanelHid2.Width = 0;
            PanelHid2.Height = 0;

            panelShow.Dock = DockStyle.Fill;
        }

    }
}
