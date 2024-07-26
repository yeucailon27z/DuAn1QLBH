using BUS.Servisces;
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
    public partial class FormHoaDon : Form
    {
        HoaDonServices _services;
        public FormHoaDon()
        {
            _services = new HoaDonServices();
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_HoaDon.Rows.Count)
            {
                DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];
                txt_Ma.Text = row.Cells[1].Value.ToString();
                dtp_Ngay.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                txt_MaNV.Text = row.Cells[3].Value.ToString();
                txt_MaKH.Text = row.Cells[4].Value.ToString();
                txt_MaGG.Text = row.Cells[5].Value.ToString();
                txt_TongTien.Text = row.Cells[6].Value.ToString();
                cbb_httt.Text = row.Cells[7].Value.ToString();
                cbb_TrangThai.SelectedIndex = Convert.ToByte(row.Cells[8].Value);

            }
        }
        public void LoadData()
        {
            dgv_HoaDon.Rows.Clear();
            dgv_HoaDon.BorderStyle = BorderStyle.None;

            var allDatas = _services.GetALL();
                dgv_HoaDon.ColumnCount = 9;
            dgv_HoaDon.Columns[0].HeaderText = "STT";
            dgv_HoaDon.Columns[1].HeaderText = "Mã Hóa Đơn";
            dgv_HoaDon.Columns[2].HeaderText = "Ngày Tạo HĐ";
            dgv_HoaDon.Columns[3].HeaderText = "Mã Khách Hàng";
            dgv_HoaDon.Columns[4].HeaderText = "Mã Nhân Viên";
            dgv_HoaDon.Columns[5].HeaderText = "Mã Giảm Giá";
            dgv_HoaDon.Columns[6].HeaderText = "Hình Thức Thanh Toán";
            dgv_HoaDon.Columns[7].HeaderText = "Tổng Tiền";
            dgv_HoaDon.Columns[8].HeaderText = "Trạng Thái";
           

            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                dgv_HoaDon.Rows.Add(i, data.HoaDonId, data.NgayLap, data.KhachHangId, data.NhanVienId, data.GiamGiaId, data.HinhThucThanhToan, data.TongTien, data.TrangThai);
            }
        }
    }
}
