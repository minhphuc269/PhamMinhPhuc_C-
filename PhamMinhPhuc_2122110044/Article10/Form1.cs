using System;
using System.Windows.Forms;

namespace Article10
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private string operation = "";
        private double firstNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization can be done here if needed
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                currentInput += button.Text;
                textBoxResult.Text = currentInput;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (!string.IsNullOrEmpty(currentInput))
                {
                    firstNumber = double.Parse(currentInput);
                    operation = button.Text;
                    currentInput = "";
                }
            }
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !string.IsNullOrEmpty(operation))
            {
                double secondNumber = double.Parse(currentInput);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                        // You can add more operations here (e.g., *, /)
                }

                textBoxResult.Text = result.ToString();
                currentInput = ""; // Reset for the next calculation
                operation = ""; // Reset the operation
            }
        }
    }
}
