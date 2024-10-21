using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MainMenu
{
    public partial class Quanlinhanvien : Form
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();

        public Quanlinhanvien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtTuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra tuổi hợp lệ
            if (!int.TryParse(txtTuoi.Text, out int tuoi))
            {
                MessageBox.Show("Tuổi không hợp lệ!");
                return;
            }

            // Xác định giới tính
            string gioiTinh = checkBoxGioiTinh.Checked ? "Nam" : "Nữ";

            // Tạo đối tượng nhân viên mới
            NhanVien nv = new NhanVien
            {
                MaNV = txtMa.Text,
                TenNV = txtTen.Text,
                Tuoi = tuoi,
                GioiTinh = gioiTinh
            };

            // Thêm nhân viên vào danh sách
            danhSachNhanVien.Add(nv);

            // Cập nhật lại DataGridView
            CapNhatDanhSach();

            // Xóa các trường nhập liệu sau khi thêm
            ResetInputFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string maNV = row.Cells[0].Value.ToString();
                    var nv = danhSachNhanVien.Find(n => n.MaNV == maNV);
                    if (nv != null)
                    {
                        danhSachNhanVien.Remove(nv);
                    }
                }

                CapNhatDanhSach();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapNhatDanhSach()
        {
            dataGridView1.Rows.Clear();
            foreach (var nv in danhSachNhanVien)
            {
                dataGridView1.Rows.Add(nv.MaNV, nv.TenNV, nv.Tuoi, nv.GioiTinh == "Nam", nv.GioiTinh == "Nữ");
            }
        }

        private void ResetInputFields()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtTuoi.Clear();
            checkBoxGioiTinh.Checked = false;
            checkBox2.Checked = false;
        }

        private void checkBoxGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGioiTinh.Checked)
            {
                checkBox2.Checked = false; // Bỏ chọn "Nữ" nếu chọn "Nam"
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBoxGioiTinh.Checked = false; // Bỏ chọn "Nam" nếu chọn "Nữ"
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có hàng nào được chọn
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                string maNV = row.Cells[0].Value.ToString();
                var nv = danhSachNhanVien.Find(n => n.MaNV == maNV);

                if (nv != null)
                {
                    // Cập nhật thông tin nhân viên
                    nv.TenNV = txtTen.Text;
                    nv.Tuoi = int.TryParse(txtTuoi.Text, out int tuoi) ? tuoi : nv.Tuoi;
                    nv.GioiTinh = checkBoxGioiTinh.Checked ? "Nam" : "Nữ";

                    // Cập nhật lại DataGridView
                    CapNhatDanhSach();

                    // Xóa các trường nhập liệu sau khi sửa
                    ResetInputFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtTuoi.Text = row.Cells[2].Value.ToString();
                checkBoxGioiTinh.Checked = row.Cells[3].Value != null && (bool)row.Cells[3].Value;
                checkBox2.Checked = row.Cells[4].Value != null && (bool)row.Cells[4].Value;
            }
            else
            {
                ResetInputFields();
            }
        }

        private void Quanlinhanvien_Load(object sender, EventArgs e)
        {

        }
    }

    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
    }
}
