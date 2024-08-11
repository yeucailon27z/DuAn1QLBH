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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRL
{
    public partial class FormHoaDon : Form
    {
        public Guid currentBillId;
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

                txt_MaGG.Text = row.Cells[5].Value.ToString();
                txt_TongTien.Text = row.Cells[7].Value.ToString();
                cbb_httt.Text = row.Cells[6].Value.ToString();
                cbb_TrangThai.SelectedIndex = Convert.ToInt32(row.Cells[8].Value);

                // Assuming txt_Ma holds the HoaDonId (change this if it's a different control)
                Guid idHD = Guid.Parse(txt_Ma.Text);
                dgv_HDCT.Rows.Clear();
                int i = 0;
                var allDatas = HDCTServices.GetHDCTViewModel(idHD);
                dgv_HDCT.ColumnCount = 7;
                dgv_HDCT.Columns[0].HeaderText = "STT";
                dgv_HDCT.Columns[1].HeaderText = "Mã HĐCT";
                dgv_HDCT.Columns[2].HeaderText = "Mã Hóa Đơn";
                dgv_HDCT.Columns[3].HeaderText = "Tên Sản Phẩm";
                dgv_HDCT.Columns[4].HeaderText = "Số Lượng";
                dgv_HDCT.Columns[5].HeaderText = "Đơn Giá";
                dgv_HDCT.Columns[6].HeaderText = "Mã Sản Phẩm";
               

                foreach (var data in allDatas)
                {
                    i++;
                    dgv_HDCT.Rows.Add(i, data.HoaDonChiTietID, data.HoaDonID, data.TenSanPham, data.SoLuong, data.DonGia,data.SanPhamID);
                }
                currentBillId = idHD;
             
            }

        }
        public void LoadData()
        {
            dgv_HoaDon.Rows.Clear();
            dgv_HoaDon.BorderStyle = BorderStyle.None;

            var allDatas = _services.GetViewModel();
            dgv_HoaDon.ColumnCount = 12;
            dgv_HoaDon.Columns[0].HeaderText = "STT";
            dgv_HoaDon.Columns[1].HeaderText = "Mã Hóa Đơn";
            dgv_HoaDon.Columns[2].HeaderText = "Ngày Tạo HĐ";
            dgv_HoaDon.Columns[3].HeaderText = "Tên Khách Hàng";
            dgv_HoaDon.Columns[4].HeaderText = "Tên Nhân Viên";
            dgv_HoaDon.Columns[5].HeaderText = "Tên Giảm Giá";


            dgv_HoaDon.Columns[6].HeaderText = "Hình Thức Thanh Toán";
            dgv_HoaDon.Columns[7].HeaderText = "Tổng Tiền";
            dgv_HoaDon.Columns[8].HeaderText = "Trạng Thái";
 dgv_HoaDon.Columns[9].HeaderText = "Mã Khách Hàng";
dgv_HoaDon.Columns[10].HeaderText = "Mã Nhân Viên";dgv_HoaDon.Columns[11].HeaderText = "Mã Giảm Giá";
            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                dgv_HoaDon.Rows.Add(i, data.HoaDonId, data.NgayLap, data.TenKhachHang, data.TenNhanVien, data.MaGiamGia, data.HinhThucThanhToan, data.TongTien, data.TrangThai,data.KhachHangId,data.NhanVienId,data.GiamGiaId);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
           
            string tenkh = cbb_TenKH.Text;
            string tennv = cbb_TenNV.Text;
            byte trangthai = (byte)cbb_TrangThai.SelectedIndex;
            DateTime firstDate = dtp_Fngay.Value;
            DateTime endDate = dtp_Engay.Value;

            var searchResults = _services.GetViewModel().Where(hd =>
                (trangthai == -1 || hd.TrangThai == trangthai) &&
                (string.IsNullOrEmpty(tenkh) || hd.KhachHangId == tenkh) &&
                (string.IsNullOrEmpty(tennv) || hd.NhanVienId == tennv) &&
                (hd.NgayLap >= firstDate && hd.NgayLap <= endDate)
            ).ToList();
            dgv_HoaDon.Rows.Clear();
            dgv_HoaDon.ColumnCount = 12;
            dgv_HoaDon.Columns[0].HeaderText = "STT";
            dgv_HoaDon.Columns[1].HeaderText = "Mã Hóa Đơn";
            dgv_HoaDon.Columns[2].HeaderText = "Ngày Tạo HĐ";
            dgv_HoaDon.Columns[3].HeaderText = "Tên Khách Hàng";
            dgv_HoaDon.Columns[4].HeaderText = "Tên Nhân Viên"; 
            dgv_HoaDon.Columns[5].HeaderText = "Tên Giảm Giá";
            dgv_HoaDon.Columns[6].HeaderText = "Hình Thức Thanh Toán";
            dgv_HoaDon.Columns[7].HeaderText = "Tổng Tiền";
            dgv_HoaDon.Columns[8].HeaderText = "Trạng Thái";
            dgv_HoaDon.Columns[9].HeaderText = "Mã Khách Hàng";
            dgv_HoaDon.Columns[10].HeaderText = "Mã Nhân Viên"; 
            dgv_HoaDon.Columns[11].HeaderText = "Mã Giảm Giá";
            int i = 0;
            foreach (var data in searchResults)
            {
                i++;
                dgv_HoaDon.Rows.Add(i, data.HoaDonId, data.NgayLap, data.TenKhachHang, data.TenNhanVien, data.MaGiamGia, data.HinhThucThanhToan, data.TongTien, data.TrangThai, data.KhachHangId, data.NhanVienId, data.GiamGiaId);
            }
        }

        private void dgv_HDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_HDCT.Rows.Count)
            {
                DataGridViewRow row = dgv_HDCT.Rows[e.RowIndex];
                txt_MaHDCT.Text = row.Cells[1].Value.ToString();
                txt_MaHD.Text = row.Cells[2].Value.ToString();
                txt_MaSP.Text = row.Cells[6].Value.ToString();
                txt_SoLuong.Text = row.Cells[4].Value.ToString();
                txt_DonGia.Text = row.Cells[5].Value.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tencuahang = "Pet Food Shop";
            var diachi = "2 P. Lê Văn Hiến, Đông Ngạc, Bắc Từ Liêm, Hà Nội";
            var sdt = "0855 886 660";
            var now = DateTime.Now;
            var formattedDate = now.ToString("dd/MM/yyyy HH:mm:ss"); // Định dạng ngày giờ hiện tại
            var idhd = currentBillId;

            var w = printDocument1.DefaultPageSettings.PaperSize.Width;

            // Vẽ tên cửa hàng lên tài liệu in
            e.Graphics.DrawString(
                tencuahang.ToUpper(),
                new Font("Courier New", 14, FontStyle.Bold),
                Brushes.Black,
                new Point(10, 20)
            );
            e.Graphics.DrawString(
                string.Format(hd.KhachHangId),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w/2+150, 20)
            );
            e.Graphics.DrawString(
                string.Format(hd.NhanVienId),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2+300, 20)
            );

            string text = string.Format("HD:{0}", currentBillId);
            e.Graphics.DrawString(
                text,
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new PointF(w / 2, 100)
            );
            string texts = string.Format("Địa chỉ: "+diachi);
            e.Graphics.DrawString(
    texts,
    new Font("Courier New", 10, FontStyle.Regular),
    Brushes.Black,
    new PointF(10, 45) // Vị trí cần điều chỉnh nếu cần
);
            string textz = string.Format("Số điện thoại: "+sdt);
            e.Graphics.DrawString(
    textz,
    new Font("Courier New", 10, FontStyle.Regular),
    Brushes.Black,
    new PointF(10, 70) // Vị trí cần điều chỉnh nếu cần
);
            e.Graphics.DrawString(
    formattedDate,
    new Font("Courier New", 10, FontStyle.Regular),
    Brushes.Black,
    new PointF(w / 2 + 200, 45) // Vị trí cần điều chỉnh nếu cần
);
            Pen pen = new Pen(Color.Black, 1);

            var y = 90;

            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);

            e.Graphics.DrawLine(pen, p1, p2);

            y += 10;

            e.Graphics.DrawString(
   string.Format("Ngày tạo HD: {0}",hd.NgayLap),
   new Font("Courier New", 10, FontStyle.Bold),
   Brushes.Black,
   new PointF(10, y));
            y += 20;
            Point p3 = new Point(10, y);
            Point p4 = new Point(w - 10, y);
            e.Graphics.DrawLine(pen, p3, p4);
            y += 20;
            e.Graphics.DrawString(string.Format("STT"),
   new Font("Courier New", 10, FontStyle.Bold),
   Brushes.Black,
   new PointF(50, y));
            e.Graphics.DrawString(
  string.Format("Mã sản phẩm"),
  new Font("Courier New", 10, FontStyle.Bold),
  Brushes.Black,
  new PointF(150, y));
            e.Graphics.DrawString(
string.Format("Tên sản phẩm"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w/2-50, y));
            e.Graphics.DrawString(
 string.Format("Số lượng"),
 new Font("Courier New", 10, FontStyle.Bold),
 Brushes.Black,
 new PointF(w / 2 +150, y));
            e.Graphics.DrawString(
string.Format("Đơn giá"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2+300, y));
     
            int i = 0;
            var allDatas = HDCTServices.GetHDCTViewModel(idhd);
            decimal tongtien=0;
            foreach (var data in allDatas)
            {
                i++;
                y += 20;
                e.Graphics.DrawString(
   string.Format(i.ToString()),
   new Font("Courier New", 10, FontStyle.Bold),
   Brushes.Black,
   new PointF(50, y));
                e.Graphics.DrawString(
string.Format(data.SanPhamID),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(150, y));
                e.Graphics.DrawString(
string.Format(data.TenSanPham),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 - 50, y));
                e.Graphics.DrawString(string.Format(data.SoLuong.ToString()),
 new Font("Courier New", 10, FontStyle.Bold),
 Brushes.Black,
 new PointF(w / 2+150, y));
                e.Graphics.DrawString(string.Format(data.DonGia.ToString() + " đ"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 + 300, y));
              
                tongtien += Convert.ToDecimal(data.DonGia.Value);
            }
            y += 20;
            Point p5 = new Point(10, y);
            Point p6 = new Point(w - 10, y);
            e.Graphics.DrawLine(pen, p5, p6);
            y += 20;
            e.Graphics.DrawString(
  string.Format("Mã Giảm Giá:"),
  new Font("Courier New", 10, FontStyle.Regular),
  Brushes.Black,
  new PointF(50, y));
            e.Graphics.DrawString(
  string.Format(hd.GiamGiaId),
  new Font("Courier New", 10, FontStyle.Regular),
  Brushes.Black,
  new PointF(150, y));
            e.Graphics.DrawString(string.Format("Tổng tiền:"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 + 150, y));
            e.Graphics.DrawString(string.Format(tongtien+" đ"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 + 300, y));
            y += 20;
            e.Graphics.DrawString(string.Format("Thành tiền tiền:"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 + 150, y));
            e.Graphics.DrawString(string.Format(hd.TongTien + " đ"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 + 300, y));
            y += 30;
            e.Graphics.DrawString(
string.Format("Cảm ơn quý khách đã mua hàng, chúc quý khách một ngày tốt lành!"),
new Font("Courier New", 10, FontStyle.Italic),
Brushes.Black,
new PointF(200, y));
        }
        private void InHoaDon()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        public HoaDon hd;
        private void dgv_HoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_HoaDon.Rows.Count)
            {
                DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];

                Guid idhd = Guid.Parse(row.Cells[1].Value.ToString());
                DateTime ngay = DateTime.Parse(row.Cells[2].Value.ToString());
                decimal tongtien =Convert.ToDecimal(row.Cells[7].Value.ToString());
                string magg = row.Cells[5].Value.ToString();
                string makh = row.Cells[9].Value.ToString();
                string tenkh = row.Cells[3].Value.ToString();
                currentBillId = idhd;

                hd = new HoaDon()
                {
                    HoaDonId = idhd,
                    NgayLap = ngay,
                    TongTien = tongtien,
                    GiamGiaId = magg,
                    KhachHangId=makh,
                    NhanVienId=tenkh,
                }; 
                InHoaDon();
            }
        }
    }
}
