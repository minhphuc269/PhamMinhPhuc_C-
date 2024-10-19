using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Article16
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=MINHPHUC;Initial Catalog=SinhVien;User ID=sa;Password=sa";
        private List<SinhVien> sinhVienList = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
            // Thêm các khoa vào ComboBox
            comboBoxMajor.Items.Add("Công nghệ thông tin");
            comboBoxMajor.Items.Add("Khoa học máy tính");
            comboBoxMajor.Items.Add("Mạng máy tính");
            comboBoxMajor.Items.Add("Quản trị kinh doanh");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển
            string hoTen = textBoxName.Text;
            DateTime ngaySinh = dateTimePickerDOB.Value;
            string gioiTinh = radioButtonMale.Checked ? "Nam" : "Nữ";
            string khoa = comboBoxMajor.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(hoTen) || khoa == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Thêm sinh viên vào cơ sở dữ liệu
            AddStudentToDatabase(hoTen, ngaySinh, gioiTinh, khoa);
            DisplayStudents();

            // Xóa dữ liệu nhập
            textBoxName.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            radioButtonMale.Checked = true;
            comboBoxMajor.SelectedIndex = -1;
        }

        private void AddStudentToDatabase(string hoTen, DateTime ngaySinh, string gioiTinh, string khoa)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SinhVien (HoTen, NgaySinh, GioiTinh, Khoa) VALUES (@HoTen, @NgaySinh, @GioiTinh, @Khoa)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@Khoa", khoa);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm sinh viên thành công!");

                        // Thêm sinh viên mới vào danh sách
                        sinhVienList.Add(new SinhVien(hoTen, ngaySinh.ToString("dd/MM/yyyy"), gioiTinh, khoa));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void DisplayStudents()
        {
            listBoxStudents.Items.Clear();
            foreach (var sv in sinhVienList)
            {
                listBoxStudents.Items.Add(sv.ToString());
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class SinhVien
    {
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Khoa { get; set; }

        public SinhVien(string hoTen, string ngaySinh, string gioiTinh, string khoa)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Khoa = khoa;
        }

        public override string ToString()
        {
            return $"{HoTen} - Ngày sinh: {NgaySinh} - Giới tính: {GioiTinh} - Khoa: {Khoa}";
        }
    }
}
