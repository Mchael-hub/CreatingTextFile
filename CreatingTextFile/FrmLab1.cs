using System;
using System.IO;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileNamee frm = new FrmFileNamee();
            frm.ShowDialog();

            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileNamee.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            MessageBox.Show("File created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            this.Close();
        }
    }
}