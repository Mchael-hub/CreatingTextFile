using System;
using System.IO;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load_1(object sender, EventArgs e)
        {
            cbProgram.Items.Clear();
            cbProgram.Items.Add("BS Information Technology");
            cbProgram.Items.Add("BS Computer Science");
            cbProgram.Items.Add("BS Business Administration");

            cbGender.Items.Clear();
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMI.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                cbProgram.SelectedItem == null ||
                cbGender.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all the required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentNo = txtStudentNo.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleInitial = txtMI.Text;
            string program = cbProgram.SelectedItem.ToString();
            string gender = cbGender.SelectedItem.ToString();
            string age = txtAge.Text;
            string birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            string contactNo = txtContactNo.Text;

            string[] studentInfo = new string[]
            {
                "Student No.:" + studentNo,
                "Full Name:" + lastName + ", " + firstName + ", " + middleInitial + ".",
                "Program: " + program,
                "Gender: " + gender,
                "Age: " + age,
                "Birthday: " + birthday,
                "Contact No." + contactNo
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = studentNo + ".txt";
            string filePath = Path.Combine(docPath, fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in studentInfo)
                {
                    writer.WriteLine(line);
                }
            }

            MessageBox.Show("Registration details saved to " + fileName, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}