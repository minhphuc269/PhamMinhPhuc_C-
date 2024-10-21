namespace Article05
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            bt_OK = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(196, 6);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(74, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(153, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 136);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(126, 57);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // bt_OK
            // 
            bt_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_OK.Location = new Point(102, 214);
            bt_OK.Name = "bt_OK";
            bt_OK.Size = new Size(80, 25);
            bt_OK.TabIndex = 8;
            bt_OK.Text = "OK";
            bt_OK.Click += bt_OK_Click;
            // 
            // button2
            // 
            button2.Location = new Point(188, 212);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(button2);
            Controls.Add(bt_OK);
            Controls.Add(richTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            KeyPreview = true;
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            Load += Form1_Load_1;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private Button bt_OK;
        private Button button2;
    }
}
