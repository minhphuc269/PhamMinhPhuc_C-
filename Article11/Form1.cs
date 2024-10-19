using System;
using System.Windows.Forms;

namespace Article11

{
    public partial class Form1 : Form
    {
        private double result;
        private string operatorClicked;
        private bool isOperationPerformed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text += button.Text;
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            // Clear memory function
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            // Memory recall function
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            // Memory store function
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            // Memory add function
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            // Memory subtract function
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result = 0;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length > 0)
            {
                textBox_Result.Text = textBox_Result.Text.Substring(0, textBox_Result.Text.Length - 1);
                if (textBox_Result.Text == "")
                    textBox_Result.Text = "0";
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorClicked = button.Text;
            result = Double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    textBox_Result.Text = (result + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (result * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (result / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                    // Add any additional operations here
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = Math.Sqrt(Double.Parse(textBox_Result.Text)).ToString();
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = (1 / Double.Parse(textBox_Result.Text)).ToString();
        }
    }
}
