using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Quanlisinhvien : Form
    {
        private List<SinhVien> sinhVienList = new List<SinhVien>();

        public Quanlisinhvien()
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

            // Thêm sinh viên vào danh sách sinhVienList
            sinhVienList.Add(new SinhVien(hoTen, ngaySinh.ToString("dd/MM/yyyy"), gioiTinh, khoa));
            DisplayStudents();

            // Xóa dữ liệu nhập
            textBoxName.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            radioButtonMale.Checked = true;
            comboBoxMajor.SelectedIndex = -1;
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
