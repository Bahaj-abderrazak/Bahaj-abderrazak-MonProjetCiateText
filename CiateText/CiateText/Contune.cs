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
    public partial class Contune : Form
    {
        int Statu,IdGroup;
        string CodF;
        public Contune()
        {
            InitializeComponent();
        }
        public Contune(int Statu)
        {
            this.Statu = Statu;
            InitializeComponent();
        }
        public Contune(int Statu,int IdGroup)
        {
            this.Statu = Statu;
            this.IdGroup = IdGroup;
            InitializeComponent();
        }
        public Contune(int Statu,string CodF)
        {
            this.Statu = Statu;
            this.CodF = CodF;
            InitializeComponent();
        }

        private void Contune_Load(object sender, EventArgs e)
        {
            NewChaitText1 text1 = new NewChaitText1();
            text1.MdiParent = this;
            text1.Dock = DockStyle.Fill;
            text1.Show();
        }

        public  void Contune_Activated(object sender, EventArgs e)
        {
            
            switch (Statu)
            {
                case 1:
                    NewChaitText2 text2 = new NewChaitText2(IdGroup);
                   text2.MdiParent = this;
                   text2.Dock = DockStyle.Fill;
                    text2.Show();
                    break;
                case 2:
                    NewChaitText3 text3 = new NewChaitText3(IdGroup, CodF);
                    text3.MdiParent = this;
                    text3.Dock = DockStyle.Fill;
                    text3.Show();
                    break;
                case 3:this.Close();
                    break;
            }
        }
    }
}
