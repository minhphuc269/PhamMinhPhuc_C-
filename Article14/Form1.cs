using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Article14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = rbtnMale.Checked ? "Ông" : "Bà";
            int discount = chkDiscount.Checked ? int.Parse(txtDiscount.Text) : 0;

            lblResult.Text = $"{gender} {name} được giảm {discount}%";
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscount.Enabled = chkDiscount.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
