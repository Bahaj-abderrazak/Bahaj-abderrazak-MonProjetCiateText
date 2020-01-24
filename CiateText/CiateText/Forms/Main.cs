using System;
using System.Windows.Forms;

namespace CiateText
{
    public partial class Main : Form
    {
        string Fillier;
        string NomGroup;
        public Main()
        {
            InitializeComponent();
        }
        public Main(string GRO,string Fillier)
        {
            this.Fillier = Fillier;
            NomGroup = GRO;
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e) => this.panel1.Width = (this.panel1.Width == 50) ? 238 : 50;

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Top = 96;
            CONTAIN.Controls.Clear();
            UserEmplois user = new UserEmplois(NomGroup);
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Add(user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Top = 134;
            CONTAIN.Controls.Clear();
            UserListStagiaire user = new UserListStagiaire(NomGroup);
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Add(user);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Top = 207;
            CONTAIN.Controls.Clear();
            UserProfile user = new UserProfile();
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Add(user);

        }
        private void BtnKey_Click(object sender, EventArgs e)
        {
            panel3.Top = 244;
            CONTAIN.Controls.Clear();
            UserEditProf user = new UserEditProf();
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Add(user);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Top = 170;
            UserRealisation user = new UserRealisation(NomGroup, Fillier);
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Clear();
            CONTAIN.Controls.Add(user);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Top = 251;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Top = 257;
            CONTAIN.Controls.Clear();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblTitle.Text = NomGroup;
            CONTAIN.Controls.Clear();   UserEmplois user = new UserEmplois(NomGroup);
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Add(user);
        }

        private void Size_Click(object sender, EventArgs e) => this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;

        private void Reduir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous les Vous Quiter", "Quiter", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            (new Accueil()).Show();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce Programe créé par Achraf Mojan et Abderrazak Bahaj","À Propos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Imprem_Click(object sender, EventArgs e)
        {
            panel3.Top = 281;
            UserEmploisiprem user = new UserEmploisiprem(NomGroup);
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Clear();
            CONTAIN.Controls.Add(user);
        }

        private void BtnImremierRe_Click(object sender, EventArgs e)
        {
            panel3.Top = 319;
            UserRealisationImpre user = new UserRealisationImpre(NomGroup);
            user.Dock = DockStyle.Fill;
            CONTAIN.Controls.Clear();
            CONTAIN.Controls.Add(user);
        }
    }
}
