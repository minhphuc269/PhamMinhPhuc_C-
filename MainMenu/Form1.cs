using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Blue;
            button2.BackColor = System.Drawing.Color.Orange;
            button3.BackColor = System.Drawing.Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quanlinhanvien frmQuanlinhanvien = new Quanlinhanvien();
            frmQuanlinhanvien.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlinhanvien frmQuanlinhanvien = new Quanlinhanvien();
            frmQuanlinhanvien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlisinhvien frmQuanlisinhvien = new Quanlisinhvien();
            frmQuanlisinhvien.Show();
        }

        private void quảnLíSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlisinhvien frmQuanlisinhvien = new Quanlisinhvien();
            frmQuanlisinhvien.Show();
        }

        private void ngườiTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Người tạo: Phạm Minh Phúc");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quanlinhansu frmQuanlinhansu = new Quanlinhansu();
            frmQuanlinhansu.Show();
        }

        private void quảnLíNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlinhansu frmQuanlinhansu = new Quanlinhansu();
            frmQuanlinhansu.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

