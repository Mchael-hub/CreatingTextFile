namespace CreatingTextFile
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLab1 simpleLab = new FrmLab1();
            simpleLab.ShowDialog();
            this.Show();
        }

        private void btnChallenge_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistration challengeLab = new FrmRegistration();
            challengeLab.ShowDialog();
            this.Show(); 
        }
    }
}
