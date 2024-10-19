using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Article10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonDot = new Button();
            buttonEquals = new Button();
            textBoxResult = new TextBox();

            SuspendLayout();

            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(10, 10);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(260, 40);
            textBoxResult.TabIndex = 0;
            textBoxResult.ReadOnly = true;
            textBoxResult.TextAlign = HorizontalAlignment.Right;

            // 
            // button1
            // 
            button1.Location = new Point(10, 60);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;

            // 
            // button2
            // 
            button2.Location = new Point(70, 60);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;

            // 
            // button3
            // 
            button3.Location = new Point(130, 60);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;

            // 
            // button4
            // 
            button4.Location = new Point(190, 60);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;

            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(10, 120);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 50);
            buttonPlus.TabIndex = 5;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += Operator_Click;

            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(70, 120);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 50);
            buttonMinus.TabIndex = 6;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += Operator_Click;

            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(130, 120);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(50, 50);
            buttonDot.TabIndex = 7;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += Button_Click;

            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(190, 120);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(50, 50);
            buttonEquals.TabIndex = 8;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += ButtonEquals_Click;

            // 
            // Form1
            // 
            ClientSize = new Size(280, 200);
            Controls.Add(textBoxResult);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(buttonDot);
            Controls.Add(buttonEquals);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();

            // Add Form Load event
            this.Load += Form1_Load;
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonDot;
        private Button buttonEquals;
        private TextBox textBoxResult;
    }
}
