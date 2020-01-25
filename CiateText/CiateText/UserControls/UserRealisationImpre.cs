using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiateText.DATA.DataSetTableAdapters;

namespace CiateText
{
    public partial class UserRealisationImpre : UserControl
    {
        string Nom;
        public UserRealisationImpre(string Nom)
        {
            this.Nom = Nom;
            InitializeComponent();
        }

        private void UserRealisationImpre_Load(object sender, EventArgs e)
        {
            DATA.DataSet set = new DATA.DataSet();
            PS_REALISATIONTableAdapter ps = new PS_REALISATIONTableAdapter();
            Reports.CRRealistion CR = new Reports.CRRealistion();

            ps.Fill(set.PS_REALISATION, Nom);
            CR.SetDataSource(set);
            CRV.ReportSource = CR;

        }
    }
}
