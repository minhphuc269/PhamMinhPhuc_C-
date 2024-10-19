using System;
using System.IO;
using System.Windows.Forms;

namespace Article05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể thêm mã khởi tạo tại đây nếu cần.
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Phúc\Key_Logger.txt", true))
                {
                    sw.WriteLine("TextBox1: " + textBox1.Text);
                    sw.WriteLine("NumericUpDown1: " + numericUpDown1.Value);
                    sw.WriteLine("CheckBox1: " + checkBox1.Checked);
                    sw.WriteLine("RadioButton1: " + radioButton1.Checked);
                    sw.WriteLine("ComboBox1: " + comboBox1.SelectedItem);
                    sw.WriteLine("DateTimePicker1: " + dateTimePicker1.Value);
                    sw.WriteLine("---------------------");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Nếu bạn vẫn muốn ghi lại các phím bấm, hãy giữ lại mã này
            // Có thể bỏ qua nếu không cần
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Xử lý thay đổi trong textBox1 nếu cần.
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Xử lý thay đổi trong richTextBox1 nếu cần.
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Xử lý thay đổi giá trị numericUpDown1 nếu cần.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý thay đổi trong checkBox1 nếu cần.
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý thay đổi trong radioButton1 nếu cần.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý thay đổi trong comboBox1 nếu cần.
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Xử lý thay đổi trong dateTimePicker1 nếu cần.
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
