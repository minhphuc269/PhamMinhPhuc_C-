using System;
using System.Windows.Forms;
using System.IO;

namespace Article19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get employee data
            string employeeID = txtEmployeeID.Text;
            string employeeName = txtEmployeeName.Text;
            string imagePath = pbImage.ImageLocation;

            // Save logic (can be to a file, database, etc.)
            SaveEmployeeData(employeeID, employeeName, imagePath);
        }

        private void SaveEmployeeData(string employeeID, string employeeName, string imagePath)
        {
            // Example: save to a text file (you can change this to save to a database)
            string data = $"Employee ID: {employeeID}, Name: {employeeName}, Image: {imagePath}";
            File.WriteAllText($"{employeeID}.txt", data);
            MessageBox.Show("Employee data saved successfully!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
