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
using CiateText.Reports;


namespace CiateText
{
    public partial class UserEmploisiprem : UserControl
    {
        string Nom;
        public UserEmploisiprem()
        {
            InitializeComponent();
        }
        public UserEmploisiprem(string Nom)
        {
            this.Nom = Nom;
            InitializeComponent();
        }

        private void UserEmploisiprem_Load(object sender, EventArgs e)
        {
            DATA.DataSet ds = new DATA.DataSet();
            PS_EMPLOISTableAdapter ps = new PS_EMPLOISTableAdapter();
            CREmplois CR = new CREmplois();

            ps.Fill(ds.PS_EMPLOIS, Nom);
            CR.SetDataSource(ds);
            CRV.ReportSource = CR;
        }
    }
}
