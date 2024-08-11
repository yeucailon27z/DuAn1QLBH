using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormNhanVien : Form
    {
        NhanVienRepositories _nhanvien;
        public FormNhanVien()
        {
            _nhanvien = new NhanVienRepositories();
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_NhanVien.Rows.Count)
                {
                    DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];
                    txt_Ma.Text = row.Cells[1].Value.ToString();

                    txt_Username.Text = row.Cells[2].Value.ToString();
                    txt_Password.Text = row.Cells[3].Value.ToString();
                    txt_Ten.Text = row.Cells[4].Value.ToString();
                    txt_SDT.Text = row.Cells[5].Value.ToString();
                    cbb_ChucVu.SelectedIndex = Convert.ToByte(row.Cells[6].Value);
                    cbb_TrangThai.SelectedIndex = Convert.ToByte(row.Cells[7].Value);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Click vào khoảng trống " + ex.Message, "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            // Xóa các hàng hiện tại và đặt kiểu đường viền
            dgv_NhanVien.Rows.Clear();
            dgv_NhanVien.BorderStyle = BorderStyle.None;

            // Lấy dữ liệu từ dịch vụ
            var allDatas = _nhanvien.GetAccont();

            // Cấu hình số lượng cột và tiêu đề (nên thực hiện điều này chỉ một lần ở nơi khác trong mã của bạn)
            dgv_NhanVien.ColumnCount = 8;
            dgv_NhanVien.Columns[0].HeaderText = "STT";
            dgv_NhanVien.Columns[1].HeaderText = "Mã Nhân Viên";
            dgv_NhanVien.Columns[2].HeaderText = "Username";
            dgv_NhanVien.Columns[3].HeaderText = "Password";
            dgv_NhanVien.Columns[4].HeaderText = "Tên Nhân Viên";
            dgv_NhanVien.Columns[5].HeaderText = "Số Điện Thoại";
            dgv_NhanVien.Columns[6].HeaderText = "Chức Vụ";
            dgv_NhanVien.Columns[7].HeaderText = "Trạng Thái";
            // Thêm dữ liệu vào DataGridView
            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                dgv_NhanVien.Rows.Add(i, data.NhanVienId, data.Username, data.Password, data.HoTen, data.DienThoai, data.ChucVu, data.TrangThai);
            }
        }
        public void Reset()
        {
            txt_Ma.Text = "";
            txt_Password.Text = "";
            txt_Username.Text = "";
            txt_SDT.Text = "";
            txt_Ten.Text = "";
            cbb_TrangThai.SelectedIndex = 0;
            cbb_ChucVu.SelectedIndex = 0;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_Ma.Text == "")
            {
                MessageBox.Show("Hãy nhập mã nhân viên");
                return;
            }
            else if (txt_Username.Text == "")
            {
                MessageBox.Show("Hãy nhập Username");
                return;
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Hãy nhập Password");
                return;
            }
            else if (txt_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập Họ Tên");
                return;
            }
            else if (txt_SDT.Text == "")
            {
                MessageBox.Show("Hãy nhập Số điện thoại");
                return;
            }
            else if (cbb_ChucVu.Text == "")
            {
                MessageBox.Show("Hãy chọn chức vụ");
                return;
            }
            else if (cbb_TrangThai.Text == "")
            {
                MessageBox.Show("Hãy chọn trạng thái");
                return;
            }
            else
            {
                NhanVien nv = new NhanVien()
                {
                    NhanVienId = txt_Ma.Text,
                    Username = txt_Username.Text,
                    Password = txt_Password.Text,
                    HoTen = txt_Ten.Text,
                    DienThoai = txt_SDT.Text,
                    ChucVu = Convert.ToByte(cbb_ChucVu.SelectedIndex),
                    TrangThai = Convert.ToByte(cbb_TrangThai.SelectedIndex)
                };
                MessageBox.Show(_nhanvien.CreateAcc(nv));
                LoadData();
                Reset();
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string ma = txt_Ma.Text;
            if (txt_Ma.Text == "")
            {
                MessageBox.Show("Hãy nhập mã nhân viên");
                return;
            }
            else if (txt_Username.Text == "")
            {
                MessageBox.Show("Hãy nhập Username");
                return;
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Hãy nhập Password");
                return;
            }
            else if (txt_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập Họ Tên");
                return;
            }
            else if (txt_SDT.Text == "")
            {
                MessageBox.Show("Hãy nhập Số điện thoại");
                return;
            }
            else if (cbb_ChucVu.Text == "")
            {
                MessageBox.Show("Hãy chọn chức vụ");
                return;
            }
            else if (cbb_TrangThai.Text == "")
            {
                MessageBox.Show("Hãy chọn trạng thái");
                return;
            }
            else
            {
                NhanVien nv = new NhanVien()
                {
                    NhanVienId = txt_Ma.Text,
                    Username = txt_Username.Text,
                    Password = txt_Password.Text,
                    HoTen = txt_Ten.Text,
                    DienThoai = txt_SDT.Text,
                    ChucVu = Convert.ToByte(cbb_ChucVu.SelectedIndex),
                    TrangThai = Convert.ToByte(cbb_TrangThai.SelectedIndex)
                };
                MessageBox.Show(_nhanvien.updateAcc(nv, ma));
                LoadData();
                Reset();
            }
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            string ma = txt_Ma.Text;
            if (ma == "")
            {
                MessageBox.Show("Hãy chọn nhân viên cần khóa");
                return;
            }
            else
            {
                MessageBox.Show(_nhanvien.LockAccount(ma));
                LoadData();
            }
        }

        private void btn_Unlock_Click(object sender, EventArgs e)
        {
            string ma = txt_Ma.Text;
            if (ma == "")
            {
                MessageBox.Show("Hãy chọn nhân viên cần mở khóa");
                return;
            }
            else
            {
                MessageBox.Show(_nhanvien.Unlock(ma));
                LoadData();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int trangthai = cbb_SearchTT.SelectedIndex;
            string ten = txt_SearchTenNV.Text.ToLower();

            var searchResults = _nhanvien.GetAccont()
                .Where(nv => (trangthai == -1 || nv.TrangThai == trangthai) &&
                              (string.IsNullOrEmpty(ten) || nv.HoTen.ToLower().Contains(ten)))
                .ToList();
            if (searchResults.Count < 1)
            {
                MessageBox.Show("Không tìm thấy Nhà cung cấp có Tên: " + ten + " và Trạng thái: " + trangthai);
            }
            else
            {
                dgv_NhanVien.Rows.Clear();
                int i = 0;
                foreach (var data in searchResults)
                {
                    i++;
                    dgv_NhanVien.Rows.Add(i, data.NhanVienId, data.Username, data.Password, data.HoTen, data.DienThoai, data.ChucVu,data.TrangThai);
                }
            }
            txt_SearchTenNV.Text = "";
            cbb_SearchTT.Text = "";
        }
    }
}
