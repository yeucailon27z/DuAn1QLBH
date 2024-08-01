using BUS.Servisces;
using DAL.Models;
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
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapServices _service;

        public FormNhaCungCap()
        {
            _service = new NhaCungCapServices();
            InitializeComponent();
        }
        public void LoadData()
        {
            // Xóa các hàng hiện tại và đặt kiểu đường viền
            dgv_NhaCC.Rows.Clear();
            dgv_NhaCC.BorderStyle = BorderStyle.None;

            // Lấy dữ liệu từ dịch vụ
            var allDatas = _service.GetALL();

            // Cấu hình số lượng cột và tiêu đề (nên thực hiện điều này chỉ một lần ở nơi khác trong mã của bạn)
            dgv_NhaCC.ColumnCount = 7;
            dgv_NhaCC.Columns[0].HeaderText = "STT";
            dgv_NhaCC.Columns[1].HeaderText = "Mã Nhà Cung Cấp";
            dgv_NhaCC.Columns[2].HeaderText = "Tên Nhà Cung Cấp";
            dgv_NhaCC.Columns[3].HeaderText = "Số Điện Thoại";
            dgv_NhaCC.Columns[4].HeaderText = "Địa Chỉ";
            dgv_NhaCC.Columns[5].HeaderText = "Email";
            dgv_NhaCC.Columns[6].HeaderText = "Trạng Thái";
            // Thêm dữ liệu vào DataGridView
            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                dgv_NhaCC.Rows.Add(i, data.MaNhaCungCap, data.TenNhaCungCap, data.SoDienThoai, data.DiaChi, data.Email, data.TrangThai);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_NhaCC.Rows.Clear();
            try
            {
                string ma = txt_Ma.Text;
                string ten = txt_Ten.Text;
                string sdt = txt_SDT.Text;
                string diaChi = txt_DiaChi.Text;
                string email = txt_Email.Text;
                byte trangthai = (byte)cbb_TrangThai.SelectedIndex;
                NhaCungCap ncc = new NhaCungCap
                {
                    MaNhaCungCap = ma,
                    TenNhaCungCap = ten,
                    SoDienThoai = sdt,
                    DiaChi = diaChi,
                    Email = email,
                    TrangThai = trangthai
                };
                MessageBox.Show(_service.Create(ncc));
                LoadData();
                reset();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
        }
        public void reset()
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
            txt_Email.Text = "";
            cbb_TrangThai.Text="";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgv_NhaCC.Rows.Clear();
            try
            {
                string ma = txt_Ma.Text;
                string ten = txt_Ten.Text;
                string sdt = txt_SDT.Text;
                string diaChi = txt_DiaChi.Text;
                string email = txt_Email.Text;
                byte trangthai = (byte)cbb_TrangThai.SelectedIndex;

                NhaCungCap ncc = new NhaCungCap()
                {
                    MaNhaCungCap = ma,
                    TenNhaCungCap = ten,
                    SoDienThoai = sdt,
                    DiaChi = diaChi,
                    Email = email,
                    TrangThai = trangthai
                };
                MessageBox.Show(_service.Updatee(ncc, ma));
                LoadData();
                reset();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgv_NhaCC.Rows.Clear();
            try
            {
                string ma = txt_Ma.Text.Trim();

                if (string.IsNullOrWhiteSpace(ma))
                {
                    MessageBox.Show("Mã nhà cung cấp không thể để trống.");
                    return;
                }

                // Gọi phương thức xóa dữ liệu từ dịch vụ với mã nhà cung cấp
                string resultMessage = _service.Delete(ma);
                MessageBox.Show(resultMessage);

                // Tải lại dữ liệu sau khi xóa
                LoadData();
                reset();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }

        }

        private void dgv_NhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_NhaCC.Rows.Count)
            {
                DataGridViewRow row = dgv_NhaCC.Rows[e.RowIndex];
                txt_Ma.Text = row.Cells[1].Value.ToString();
                txt_Ten.Text = row.Cells[2].Value.ToString();
                txt_SDT.Text = row.Cells[3].Value.ToString();
                txt_DiaChi.Text = row.Cells[4].Value.ToString();
                txt_Email.Text = row.Cells[5].Value.ToString();
                cbb_TrangThai.SelectedIndex = Convert.ToByte(row.Cells[6].Value);

            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchData();
            txt_SearchTen.Text = "";
            cbb_SearcTT.Text="";
        }
        private void SearchData()
        {
            dgv_NhaCC.Rows.Clear();
            int trangthai = cbb_SearcTT.SelectedIndex;
            string ten = txt_SearchTen.Text.ToLower();

            var searchResults = _service.GetALL()
                .Where(ncc => (trangthai == -1 || ncc.TrangThai == trangthai) &&
                              (string.IsNullOrEmpty(ten) || ncc.TenNhaCungCap.ToLower().Contains(ten)))
                .ToList();

            int i = 0;
            foreach (var data in searchResults)
            {
                i++;
                dgv_NhaCC.Rows.Add(i, data.MaNhaCungCap, data.TenNhaCungCap, data.SoDienThoai, data.DiaChi, data.Email, data.TrangThai);
            }

        }

        private void txt_SearchTen_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbb_SearcTT_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
