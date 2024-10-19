namespace Article08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 60);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Số x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 112);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Số y";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 170);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            label3.Click += label3_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(68, 269);
            btCong.Name = "btCong";
            btCong.Size = new Size(94, 29);
            btCong.TabIndex = 3;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += button1_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(248, 269);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(94, 29);
            btNhan.TabIndex = 4;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += button2_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(430, 269);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += button3_Click;
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(172, 57);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(125, 27);
            tbSoX.TabIndex = 6;
            tbSoX.TextChanged += textBox1_TextChanged;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(172, 109);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(125, 27);
            tbSoY.TabIndex = 7;
            tbSoY.TextChanged += textBox2_TextChanged;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(172, 167);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(125, 27);
            tbKetQua.TabIndex = 8;
            tbKetQua.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
    }
}
