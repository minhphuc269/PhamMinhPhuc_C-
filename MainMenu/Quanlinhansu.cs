using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace MainMenu
{
    public partial class Quanlinhansu : Form
    {
        public Quanlinhansu()
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
            MessageBox.Show("Lưu thành công!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
