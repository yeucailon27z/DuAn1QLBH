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
    public partial class FormKhachHang : Form
    {
        KhachHangServices _service;
        public FormKhachHang()
        {
            _service = new KhachHangServices();
            InitializeComponent();
        }
        public void LoadData()
        {
            // Xóa các hàng hiện tại và đặt kiểu đường viền
            dataGridView1.Rows.Clear();
            dataGridView1.BorderStyle = BorderStyle.None;

            // Lấy dữ liệu từ dịch vụ
            var allDatas = _service.GetALL();

            // Cấu hình số lượng cột và tiêu đề (nên thực hiện điều này chỉ một lần ở nơi khác trong mã của bạn)
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[2].HeaderText = "Tên Khách Hàng";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[5].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[6].HeaderText = "Email";
            dataGridView1.Columns[7].HeaderText = "Trạng Thái";
            // Thêm dữ liệu vào DataGridView
            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                dataGridView1.Rows.Add(i, data.KhachHangId, data.HoTen, data.NgaySinh, data.DienThoai, data.DiaChi, data.Email, data.TrangThai);
            }
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
 if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbt_makhachhang.Text = row.Cells[1].Value.ToString();
                tbt_hovaten.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                tbt_diachi.Text = row.Cells[5].Value.ToString();
                tbt_sdt.Text = row.Cells[4].Value.ToString();
                tbt_email.Text = row.Cells[6].Value.ToString();
                cbb_trangthai.Text = row.Cells[7].Value.ToString();
            }
            }
            catch (Exception)
            {
                
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string Id = tbt_makhachhang.Text;
                string ten = tbt_hovaten.Text;

                DateOnly ngaysinh = DateOnly.FromDateTime(dateTimePicker1.Value);
                string sdt = tbt_sdt.Text;
                string diaChi = tbt_diachi.Text;
                string email = tbt_email.Text;
                byte trangthai = (byte)cbb_trangthai.SelectedIndex;
                KhachHang kh = new KhachHang
                {
                    KhachHangId = Id,
                    HoTen = ten,
                    NgaySinh = ngaysinh,
                    DienThoai = sdt,
                    DiaChi = diaChi,
                    Email = email,
                    TrangThai = trangthai
                };
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(_service.Create(kh));
                    LoadData();
                    reset();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
        }
        public void reset()
        {
            tbt_makhachhang.Text = "";
            tbt_hovaten.Text = "";
            dateTimePicker1 = new DateTimePicker();
            tbt_sdt.Text = "";
            tbt_diachi.Text = "";
            tbt_email.Text = "";
            cbb_trangthai.Text = "";
        }
        private void SearchData()
        {
            dataGridView1.Rows.Clear();
            int trangthai = cb_search.SelectedIndex;
            string ten = tb_searchTen.Text.ToLower();

            var searchResults = _service.GetALL()
                .Where(kh => (trangthai == -1 || kh.TrangThai == trangthai) &&
                              (string.IsNullOrEmpty(ten) || kh.HoTen.ToLower().Contains(ten)))
                .ToList();
            if (searchResults.Count < 1)
            {
                MessageBox.Show("Không tìm thấy sản phẩm có Tên: " + ten + " Trạng thái: " + cb_search.Text);

            }
            int i = 0;
            
            foreach (var data in searchResults)
            {
                i++;
                dataGridView1.Rows.Add(i, data.KhachHangId, data.HoTen, data.NgaySinh, data.DienThoai, data.DiaChi, data.Email, data.TrangThai);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string ma = tbt_makhachhang.Text;
                string ten = tbt_hovaten.Text;
                DateOnly ngaysinh = DateOnly.FromDateTime(dateTimePicker1.Value);
                string sdt = tbt_sdt.Text;
                string diaChi = tbt_diachi.Text;
                string email = tbt_email.Text;
                byte trangthai = (byte)cbb_trangthai.SelectedIndex;

                KhachHang kh = new KhachHang()
                {
                    KhachHangId = ma,
                    HoTen = ten,
                    DienThoai = sdt,
                    NgaySinh = ngaysinh,
                    DiaChi = diaChi,
                    Email = email,
                    TrangThai = trangthai
                };
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(_service.Updatee(kh, ma));
                    LoadData();
                    reset();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string Id = tbt_makhachhang.Text.Trim();

                if (string.IsNullOrWhiteSpace(Id))
                {
                    MessageBox.Show("Mã khách hàng không thể để trống.");
                    return;
                }

                // Gọi phương thức xóa dữ liệu từ dịch vụ với mã nhà cung cấp
                string resultMessage = _service.Delete(Id);
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
    }
}
