using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedItem.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập chỉ số của ComboBox khi form được tải
            cb_Faculty.SelectedIndex = 2; // Chọn mục thứ 3 (chỉ số bắt đầu từ 0)
        }
    }
}
