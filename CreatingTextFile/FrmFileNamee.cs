using System;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmFileNamee : Form
    {
        public static string SetFileName = "";

        public FrmFileNamee()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            this.Close();
        }
    }
}