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
    public partial class FormHoaDon : Form
    {
        KhachHangServices khachHangServices;
        NhanVienServices NhanVienServices;
        HoaDonServices _services;
        HDCTServices HDCTServices;

        public FormHoaDon()
        {
            NhanVienServices = new NhanVienServices();
            khachHangServices = new KhachHangServices();
            _services = new HoaDonServices();
            HDCTServices = new HDCTServices();
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            List<KhachHang> KHName = khachHangServices.GetALL();
            foreach (var item in KHName)
            {
                 cbb_TenKH.Items.Add(item.KhachHangId);
            }
            List<string> NVName = NhanVienServices.GetNhanVienId();
            foreach (var item in NVName)
            {
                cbb_TenNV.Items.Add(item);
            }
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
      
               txt_MaGG.Text= row.Cells[5].Value.ToString();
                txt_TongTien.Text = row.Cells[7].Value.ToString();
                cbb_httt.Text = row.Cells[6].Value.ToString();
                cbb_TrangThai.SelectedIndex = Convert.ToInt32(row.Cells[8].Value);

                // Assuming txt_Ma holds the HoaDonId (change this if it's a different control)
                Guid idHD = Guid.Parse(txt_Ma.Text);
                dgv_HDCT.Rows.Clear();
                int i = 0;
                var allDatas = HDCTServices.GetHDCTbyIDHD(idHD);
                dgv_HDCT.ColumnCount = 6;
                dgv_HDCT.Columns[0].HeaderText = "STT";
                dgv_HDCT.Columns[1].HeaderText = "Mã HĐCT";
                dgv_HDCT.Columns[2].HeaderText = "Mã Hóa Đơn";
                dgv_HDCT.Columns[3].HeaderText = "Mã Sản Phẩm";
                dgv_HDCT.Columns[4].HeaderText = "Số Lượng";
                dgv_HDCT.Columns[5].HeaderText = "Đơn Giá";

                foreach (var data in allDatas)
                {
                    i++;
                    dgv_HDCT.Rows.Add(i, data.HoaDonChiTietID, data.HoaDonID, data.SanPhamID, data.SoLuong, data.DonGia);
                }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            dgv_HoaDon.Rows.Clear();
            string tenkh = cbb_TenKH.Text;
            string tennv = cbb_TenNV.Text;
            byte trangthai = (byte)cbb_TrangThai.SelectedIndex;
            DateTime firstDate = dtp_Fngay.Value;
            DateTime endDate = dtp_Engay.Value;

            var searchResults = _services.GetALL().Where(hd =>
                (trangthai == -1 || hd.TrangThai == trangthai) &&
                (string.IsNullOrEmpty(tenkh) || hd.KhachHangId == tenkh) &&
                (string.IsNullOrEmpty(tennv) || hd.NhanVienId == tennv) &&
                (hd.NgayLap >= firstDate && hd.NgayLap <= endDate)
            ).ToList();

            int i = 0;
            foreach (var data in searchResults)
            {
                i++;
                dgv_HoaDon.Rows.Add(i, data.HoaDonId, data.NgayLap, data.KhachHangId, data.NhanVienId, data.GiamGiaId, data.HinhThucThanhToan, data.TongTien, data.TrangThai);
            }
        }

        private void dgv_HDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_HDCT.Rows.Count)
            {
                DataGridViewRow row = dgv_HDCT.Rows[e.RowIndex];
                txt_MaHDCT.Text = row.Cells[1].Value.ToString();
                txt_MaHD.Text = row.Cells[2].Value.ToString();
                txt_MaSP.Text = row.Cells[3].Value.ToString();
                txt_SoLuong.Text = row.Cells[4].Value.ToString();
                txt_DonGia.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
