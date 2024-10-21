namespace Article11

{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonInverse;

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
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();

            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(12, 12);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(258, 35);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";

            // 
            // buttonMC
            // 
            this.buttonMC.Location = new System.Drawing.Point(12, 53);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(50, 50);
            this.buttonMC.TabIndex = 1;
            this.buttonMC.Text = "MC";
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);

            // 
            // buttonMR
            // 
            this.buttonMR.Location = new System.Drawing.Point(68, 53);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(50, 50);
            this.buttonMR.TabIndex = 2;
            this.buttonMR.Text = "MR";
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);

            // 
            // buttonMS
            // 
            this.buttonMS.Location = new System.Drawing.Point(124, 53);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(50, 50);
            this.buttonMS.TabIndex = 3;
            this.buttonMS.Text = "MS";
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);

            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Location = new System.Drawing.Point(180, 53);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(50, 50);
            this.buttonMPlus.TabIndex = 4;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);

            // 
            // buttonMMinus
            // 
            this.buttonMMinus.Location = new System.Drawing.Point(236, 53);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(50, 50);
            this.buttonMMinus.TabIndex = 5;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.Click += new System.EventHandler(this.buttonMMinus_Click);

            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(12, 109);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 50);
            this.buttonCE.TabIndex = 6;
            this.buttonCE.Text = "CE";
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);

            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(68, 109);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "C";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(124, 109);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(50, 50);
            this.buttonBackspace.TabIndex = 8;
            this.buttonBackspace.Text = "<-";
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);

            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(180, 109);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(50, 50);
            this.buttonSqrt.TabIndex = 9;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);

            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(236, 109);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 50);
            this.buttonDivide.TabIndex = 10;
            this.buttonDivide.Text = "/";
            this.buttonDivide.Click += new System.EventHandler(this.operator_Click);

            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.button_Click);

            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(68, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.button_Click);

            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(124, 165);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.button_Click);

            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(180, 165);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiply.TabIndex = 14;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.Click += new System.EventHandler(this.operator_Click);

            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.button_Click);

            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(68, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 16;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.button_Click);

            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 17;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.button_Click);

            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(180, 221);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(50, 50);
            this.buttonSubtract.TabIndex = 18;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.Click += new System.EventHandler(this.operator_Click);

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.button_Click);

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.button_Click);

            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.button_Click);

            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(180, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "+";
            this.buttonAdd.Click += new System.EventHandler(this.operator_Click);

            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 333);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(106, 50);
            this.button0.TabIndex = 23;
            this.button0.Text = "0";
            this.button0.Click += new System.EventHandler(this.button_Click);

            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(124, 333);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(106, 50);
            this.buttonEquals.TabIndex = 24;
            this.buttonEquals.Text = "=";
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);

            // 
            // buttonInverse
            // 
            this.buttonInverse.Location = new System.Drawing.Point(236, 165);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(50, 50);
            this.buttonInverse.TabIndex = 25;
            this.buttonInverse.Text = "1/x";
            this.buttonInverse.Click += new System.EventHandler(this.buttonInverse_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.buttonInverse);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.textBox_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
