using Azure.Core.Pipeline;
using BUS.Servisces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRL
{

    public partial class FormBanHang : Form
    {
        string idNVz;
        NhanVienServices _NVservices;
        LoaiHangServices _servicesLH;
        HDCTServices _HDCTservices;
        SanPhamServisces _services;
        GiamGiaServices _servicesGG;
        DoanhThuServices _DTservices;
        KhachHangServices _servicesKH;
        List<SanPham> sanPhams;
        List<SanPham> sp;
        HoaDonServices _HDservices;
        List<GiamGium> activeSale;
        public Guid currentBillId = Guid.Empty;
        public FormBanHang(string idNVs)
        {
            _DTservices = new DoanhThuServices();
            _NVservices = new NhanVienServices();
            _HDCTservices = new HDCTServices();
            _HDservices = new HoaDonServices();
            _servicesKH = new KhachHangServices();
            _servicesGG = new GiamGiaServices();
            _services = new SanPhamServisces();
            _servicesLH = new LoaiHangServices();
            sanPhams = _services.GetALL();
            InitializeComponent();
            this.idNVz = idNVs;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenKH = "";
            string maKH = "";

            if (cbb_MaKH.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng.");
                return;
            }
            else
            {
                // Lấy tên khách hàng từ ComboBox
                tenKH = cbb_MaKH.Text;

                // Tìm mã khách hàng dựa trên tên khách hàng
                maKH = _servicesKH.GetALL()
                    .Where(p => p.HoTen == tenKH)
                    .Select(p => p.KhachHangId)
                    .FirstOrDefault() ?? "";

                // Nếu không tìm thấy khách hàng
                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng.");
                    return;
                }

                // Tạo Guid mới cho hóa đơn
                currentBillId = Guid.NewGuid();

                // Hiển thị mã hóa đơn trên giao diện
                lbl_MaHD.Text = currentBillId.ToString();

                // Tạo hóa đơn và hiển thị kết quả
                string result = _HDservices.Creates(currentBillId, idNVz, maKH);
                MessageBox.Show(result);

                // Tải lại dữ liệu hóa đơn sau khi tạo
                LoadDataHD();
            }

        }



        private void FormBanHang_Load(object sender, EventArgs e)
        {

            List<LoaiSanPham> loaiHangName = _servicesLH.GetAll().ToList();
            foreach (var item in loaiHangName)
            {
                cbb_LoaiHang.Items.Add(item.TenLoai);
            }




            string tenKH = cbb_MaKH.Text;
            if (!string.IsNullOrEmpty(tenKH))
            {
                List<KhachHang> nameKH = _servicesKH.GetALL()

                    .ToList();
                foreach (var item in nameKH)
                {
                    cbb_MaKH.Items.Add(item.HoTen);
                }
            }
            else
            {
                cbb_MaKH.DataSource = null;
            }
            LoadSPPanel(1);
            LoadDataHD();
            timer1.Start();
        }
        public void LoadSPPanel(int page)
        {
            SanPhamRepositories repositories = new SanPhamRepositories();
            List<SanPham> sanPhams = repositories.GetAll();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            int numberOfPage = (int)Math.Ceiling((decimal)sanPhams.Count / 4);
            if (page < 1 || page > numberOfPage)
            {
                return;
            }
            else
            {
                if (page * 4 - 4 < sanPhams.Count)
                {
                    Panel s1 = CreatePanelSP(sanPhams[page * 4 - 4]);
                    tableLayoutPanel1.Controls.Add(s1, 0, 0);
                }
                if (page * 4 - 3 < sanPhams.Count)
                {
                    Panel s2 = CreatePanelSP(sanPhams[page * 4 - 3]);
                    tableLayoutPanel1.Controls.Add(s2, 1, 0);
                }
                if (page * 4 - 2 < sanPhams.Count)
                {
                    Panel s3 = CreatePanelSP(sanPhams[page * 4 - 2]);
                    tableLayoutPanel1.Controls.Add(s3, 0, 1);
                }
                if (page * 4 - 1 < sanPhams.Count)
                {
                    Panel s4 = CreatePanelSP(sanPhams[page * 4 - 1]);
                    tableLayoutPanel1.Controls.Add(s4, 1, 1);
                }

            }
        }
        public Panel CreatePanelSP(SanPham sp)//Mỗi sản phẩm được tạo ra và nằm trong 1 panel,                                         //panel này sẽ được thêm vào tablelayoutpanel//phương thức này trả về 1 panel
        {
            Panel p = new Panel();
            p.Name = sp.SanPhamId.ToString();
            p.BorderStyle = BorderStyle.Fixed3D;
            p.Size = new Size(600, 550);
            PictureBox ptb = new PictureBox();
            Panel pn = new Panel();
            pn.Location = new Point(12, 12);
            pn.Size = new Size(260, 240);
            pn.BorderStyle = BorderStyle.Fixed3D;
            ptb.Size = new Size(260, 240);


            ptb.Image = Image.FromFile(sp.Anh);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb.Location = new Point(3, 3);
            Label lbTen = new Label(); lbTen.Text = "Tên sản phẩm :";
            lbTen.TextAlign = ContentAlignment.MiddleLeft; lbTen.MaximumSize = new Size(200, 0); lbTen.AutoSize = true;
            lbTen.Font = new Font(lbTen.Font.FontFamily, 12, FontStyle.Regular);
            // Đặt kích thước tối đa cho chiều rộng


            lbTen.Location = new Point(278, 12);
            Label lbTenValue = new Label(); lbTenValue.Text = sp.TenSanPham; lbTenValue.Font = new Font(lbTenValue.Font.FontFamily, 12, FontStyle.Bold);
            lbTenValue.Location = new Point(291, 33);
            lbTenValue.TextAlign = ContentAlignment.MiddleLeft; lbTenValue.MaximumSize = new Size(200, 0); lbTenValue.AutoSize = true;
            Label lbGia = new Label(); lbGia.Text = "Giá bán :"; lbGia.Font = new Font(lbGia.Font.FontFamily, 12, FontStyle.Regular);
            lbGia.Location = new Point(278, 64);
            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.Gia + ""; lbGiaValue.Font = new Font(lbGiaValue.Font.FontFamily, 12, FontStyle.Bold);
            lbGiaValue.Location = new Point(291, 85);
            lbGiaValue.Name = "GiaBan";
            Label lbSL = new Label(); lbSL.Text = "Số lượng :"; lbSL.Font = new Font(lbSL.Font.FontFamily, 12, FontStyle.Regular);
            lbSL.Location = new Point(278, 118);
            Label lbSLValue = new Label(); lbSLValue.Text = sp.SoLuong + ""; lbSLValue.Font = new Font(lbSLValue.Font.FontFamily, 12, FontStyle.Bold);
            lbSLValue.Location = new Point(291, 139);
            lbSLValue.Name = "SoLuong";
            Label lbMua = new Label(); lbMua.Text = "Số lượng mua :"; lbMua.TextAlign = ContentAlignment.MiddleLeft; lbMua.MaximumSize = new Size(200, 0); lbMua.AutoSize = true;
            lbMua.Font = new Font(lbMua.Font.FontFamily, 12, FontStyle.Regular); ;
            lbMua.Location = new Point(278, 170);
            TextBox lbSLmua = new TextBox();
            lbSLmua.Text = "0";
            lbSLmua.Font = new Font(Font.FontFamily, 11, FontStyle.Regular); lbSLmua.TextAlign = HorizontalAlignment.Center;

            lbSLmua.Location = new Point(323, 203); lbSLmua.Name = "SoLuongMua";

            lbSLmua.Size = new Size(44, 23);
            Label tru = new Label();
            tru.Location = new Point(295, 196);
            tru.Name = "Tru";
            tru.Text = "-";
            tru.MouseClick += Tru_MouseClick;
            tru.Size = new Size(22, 30);
            tru.Font = new Font("Segoe UI", 15, FontStyle.Bold);

            Label cong = new Label();
            cong.Location = new Point(373, 200);
            cong.Name = "Cong";

            cong.Text = "+";
            cong.MouseClick += Cong_MouseClick;
            cong.Size = new Size(22, 30);
            cong.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            Button btnMua = new Button();
            btnMua.Location = new Point(311, 244);
            btnMua.MouseClick += BtnMua_MouseClick; ;
            btnMua.Size = new Size(103, 30); btnMua.Text = "Mua"; btnMua.BackColor = Color.OrangeRed;
            Label lbid = new Label();
            lbid.Text = "Sản phẩm ID:"; lbid.Font = new Font(lbid.Font.FontFamily, 12, FontStyle.Bold);
            lbid.Location = new Point(12, 265); lbid.AutoSize = true; lbid.TextAlign = ContentAlignment.MiddleLeft; lbid.MaximumSize = new Size(200, 0);
            Label lbidvalue = new Label();
            lbidvalue.Name = "SanPhamId";
            lbidvalue.Location = new Point(133, 265);
            lbidvalue.Text = sp.SanPhamId + ""; lbidvalue.Font = new Font(lbidvalue.Font.FontFamily, 12, FontStyle.Bold);
            p.Controls.Add(ptb);
            p.Controls.Add(tru); p.Controls.Add(cong);
            p.Controls.Add(lbTen); ; p.Controls.Add(lbTenValue); p.Controls.Add(pn); p.Controls.Add(lbGia); p.Controls.Add(lbGiaValue); p.Controls.Add(lbSL); p.Controls.Add(lbSLValue); pn.Controls.Add(ptb); p.Controls.Add(lbMua); p.Controls.Add(lbSLmua); p.Controls.Add(btnMua);
            p.Controls.Add(lbid); p.Controls.Add(lbidvalue);
            return p;
        }

        private void Cong_MouseClick(object? sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            Panel p = (Panel)l.Parent;
            TextBox t = p.Controls["SoLuongMua"] as TextBox;

            if (t != null)
            {
                int soluongmua;
                bool isNumber = int.TryParse(t.Text, out soluongmua);

                if (isNumber && soluongmua >= 0)
                {
                    soluongmua++;
                    t.Text = soluongmua.ToString();
                }
                else
                {
                    MessageBox.Show("Dữ liệu đầu vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t.Text = "";
                }
            }
        }

        private void Tru_MouseClick(object? sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            Panel p = (Panel)l.Parent;
            TextBox t = p.Controls["SoLuongMua"] as TextBox;

            if (t != null)
            {
                int soluongmua;
                bool isNumber = int.TryParse(t.Text, out soluongmua);

                if (isNumber && soluongmua > 0)
                {
                    soluongmua--;
                    t.Text = soluongmua.ToString();
                }
                else
                {
                    MessageBox.Show("Dữ liệu đầu vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t.Text = "";
                }
            }

        }

        private void BtnMua_MouseClick(object? sender, MouseEventArgs e)
        {

            try
            {
                Button b = (Button)sender;
                Panel p = (Panel)b.Parent;
                TextBox t = p.Controls["SoLuongMua"] as TextBox;

                Label gia = p.Controls["GiaBan"] as Label;
                decimal giaban = Convert.ToDecimal(gia.Text);
                Label soluong = p.Controls["SoLuong"] as Label;
                int soluongcon = Convert.ToInt32(soluong.Text);
                int soluongmua;

                if (!int.TryParse(t.Text, out soluongmua))
                {
                    MessageBox.Show("Định dạng số lượng không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (soluongmua == 0)
                {
                    MessageBox.Show("Vui lòng thêm số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (currentBillId == Guid.Empty)
                {
                    MessageBox.Show("Chưa chọn hóa đơn để mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (soluongmua > soluongcon)
                {
                    MessageBox.Show($"Không thể mua nhiều hơn {soluongcon}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    MessageBox.Show($"Đã mua thành công {p.Name}, Số lượng: {soluongmua}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guid idHD = currentBillId;
                    string idSP = p.Name;
                    int Soluong = soluongmua;
                    decimal Gia = giaban;
                    byte trangthai = 1;
                    MessageBox.Show(_HDCTservices.CheckSPinHD(idSP, idHD, Soluong));
                    string httt = cbb_PTTT.Text;
                    dgv_HDCT.DataSource = null;
                    _HDCTservices = new HDCTServices();
                    decimal money = _HDCTservices.Caculator(currentBillId);
                    var allHDCT = _HDCTservices.GetHDCTViewModel(currentBillId);
                    dgv_HDCT.DataSource = allHDCT;

                    _HDservices = new HoaDonServices();
                    MessageBox.Show(_HDservices.Update(currentBillId, 1, money, "Chưa có", "GG000"));
                    LoadSPPanel(Convert.ToInt32(lbl_Trang.Text));
                    LoadDataHD();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void lbl_Phai_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_Trang.Text) < (int)Math.Ceiling((decimal)sanPhams.Count / 4))
            {

                lbl_Trang.Text = Convert.ToInt32(lbl_Trang.Text) + 1 + "";
                LoadSPPanel(Convert.ToInt32(lbl_Trang.Text));
            }
        }

        private void lbl_Trai_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_Trang.Text) > 1)
            {

                lbl_Trang.Text = Convert.ToInt32(lbl_Trang.Text) - 1 + "";
                LoadSPPanel(Convert.ToInt32(lbl_Trang.Text));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadSPPanelSearch(Convert.ToInt32(lbl_Trang.Text));
        }
        public void LoadSPPanelSearch(int page)
        {
            tableLayoutPanel1.Controls.Clear();
            string searchTen = txt_SearchTen.Text.ToLower(); // Chuyển chuỗi tìm kiếm về chữ thường
            var searchLoai = _servicesLH.GetAll().Where(p => p.TenLoai == cbb_LoaiHang.Text).Select(p => p.LoaiSanPhamId).FirstOrDefault();

            List<SanPham> searchResults = sanPhams.Where(p => (searchLoai == null || p.LoaiSanPhamId == searchLoai) &&
                              (string.IsNullOrEmpty(searchTen) || p.TenSanPham.ToLower().Contains(searchTen))).ToList();

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            int numberOfPage = (int)Math.Ceiling((decimal)searchResults.Count / 4);
            if (page < 1 || page > numberOfPage)
            {
                return;
            }
            else
            {
                if (page * 4 - 4 < searchResults.Count)
                {
                    Panel s1 = CreatePanelSP(searchResults[page * 4 - 4]);
                    tableLayoutPanel1.Controls.Add(s1, 0, 0);
                }
                if (page * 4 - 3 < searchResults.Count)
                {
                    Panel s2 = CreatePanelSP(searchResults[page * 4 - 3]);
                    tableLayoutPanel1.Controls.Add(s2, 1, 0);
                }
                if (page * 4 - 2 < searchResults.Count)
                {
                    Panel s3 = CreatePanelSP(searchResults[page * 4 - 2]);
                    tableLayoutPanel1.Controls.Add(s3, 0, 1);
                }
                if (page * 4 - 1 < searchResults.Count)
                {
                    Panel s4 = CreatePanelSP(searchResults[page * 4 - 1]);
                    tableLayoutPanel1.Controls.Add(s4, 1, 1);
                }

            }
        }
        public void LoadDataHD()
        {
            dgv_HoaDon.Rows.Clear();
            dgv_HoaDon.BorderStyle = BorderStyle.None;

            var allDatas = _HDservices.GetAllnotPaid();
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
        public HoaDon hd;
        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];
            DateTime ngay = DateTime.Parse(row.Cells[2].Value.ToString());
            Convert.ToDecimal(lbl_tthd.Text);

            string makh = row.Cells[3].Value.ToString();
            string tenkh = _servicesKH.GetALL()
                         .Where(p => p.KhachHangId == makh)
                         .Select(p => p.HoTen)
                         .FirstOrDefault();

            currentBillId = Guid.Parse(dgv_HoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());
            lbl_MaHD.Text = currentBillId.ToString();
            int i = 0;
            var allDatas = _HDCTservices.GetHDCTViewModel(currentBillId);

            dgv_HDCT.DataSource = allDatas;
            decimal ttsp = Convert.ToDecimal(dgv_HoaDon.Rows[e.RowIndex].Cells[7].Value.ToString());
            lbl_ttsp.Text = ttsp.ToString();

            cbb_PTTT.Text = null;
            cbb_Voucher.Text = null;
            lbl_tthd.Text = "0";
            cbb_MaKH.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
            activeSale = _servicesGG.GetAll().Where(p => p.TienMin <= Convert.ToDecimal(lbl_ttsp.Text)).ToList();
            cbb_Voucher.Items.Clear();
            foreach (var item in activeSale)
            {
                cbb_Voucher.Items.Add(item.MaGiamGia);
            }
            hd = new HoaDon()
            {
                HoaDonId = currentBillId,
                NgayLap = ngay,

                KhachHangId = makh,
                NhanVienId = tenkh,
            };
        }

        private void txt_TienKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_PTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_PTTT.SelectedIndex == 0)
            {
                txt_TienKhach.ReadOnly = false;
                txt_TienKhach.Text = "";
                txt_TienKhach.TextChanged += Txt_TienKhach_TextChanged;
            }
            else
            {
                txt_TienKhach.ReadOnly = true;
                txt_TienKhach.Text = lbl_tthd.Text;
            };


        }

        private void Txt_TienKhach_TextChanged(object? sender, EventArgs e)
        {
            if (txt_TienKhach.Text == "")
            {
                txt_TienThua.Text = "0";
                return;
            }
            decimal tienkhach = Convert.ToDecimal(txt_TienKhach.Text);
            decimal tthd = Convert.ToDecimal(lbl_tthd.Text);
            txt_TienThua.Text = (tienkhach - tthd).ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentBillId != null)
            {
                string magg = _servicesGG.GetAll()
    .Where(p => p.MaGiamGia == cbb_Voucher.Text)
    .Select(p => p.GiamGiaId)
    .FirstOrDefault() ?? "";
                decimal giagg = 0;
                if (!string.IsNullOrEmpty(lbl_tthd.Text))
                {
                    giagg = decimal.Parse(lbl_tthd.Text);
                }
                string maggs = cbb_Voucher.Text;
                hd.GiamGiaId = maggs;
                hd.TongTien = Convert.ToDecimal(lbl_tthd.Text);
                string httt = cbb_PTTT.Text;
                _HDservices.Update(currentBillId, 0, giagg, httt, magg);
                MessageBox.Show("Thanh toán thành công");
                DialogResult xuathd = MessageBox.Show("Bạn có muốn xuất hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xuathd == DialogResult.Yes)
                {
                    InHoaDon();
                };
                LoadDataHD(); dgv_HDCT.DataSource = null;
                MessageBox.Show(_DTservices.AddDoanhThu(currentBillId, giagg));

            }
        }

        private void cbb_Voucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal discountPercentage = 0;
            if (!string.IsNullOrEmpty(cbb_Voucher.Text))
            {
                discountPercentage = Convert.ToDecimal(_servicesGG.GetAll()
                    .Where(p => p.MaGiamGia == cbb_Voucher.Text)
                    .Select(p => p.PhanTramGiam)
                    .FirstOrDefault());
            }
            decimal tthd;
            tthd = Math.Round(Convert.ToDecimal(lbl_ttsp.Text) - (Convert.ToDecimal(lbl_ttsp.Text) * (discountPercentage / 100)), 2);
            lbl_tthd.Text = tthd.ToString();
        }

        private void btn_HuyHD_Click(object sender, EventArgs e)
        {
            if (currentBillId != null)
            {
                MessageBox.Show(_HDservices.DeleteHD(currentBillId));
                LoadDataHD(); dgv_HDCT.DataSource = null;
                LoadSPPanel(Convert.ToInt32(lbl_Trang.Text));
            }

        }

        private void printDocument_HD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tencuahang = "Pet Food Shop";
            var diachi = "2 P. Lê Văn Hiến, Đông Ngạc, Bắc Từ Liêm, Hà Nội";
            var sdt = "0855 886 660";
            var now = DateTime.Now;
            var formattedDate = now.ToString("dd/MM/yyyy HH:mm:ss"); // Định dạng ngày giờ hiện tại
            var idhd = currentBillId;

            var w = printDocument_HD.DefaultPageSettings.PaperSize.Width;

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
                new Point(w / 2 + 150, 20)
            );
            e.Graphics.DrawString(
                string.Format(hd.NhanVienId),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 300, 20)
            );

            string text = string.Format("HD:{0}", currentBillId);
            e.Graphics.DrawString(
                text,
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new PointF(w / 2, 100)
            );
            string texts = string.Format("Địa chỉ: " + diachi);
            e.Graphics.DrawString(
    texts,
    new Font("Courier New", 10, FontStyle.Regular),
    Brushes.Black,
    new PointF(10, 45) // Vị trí cần điều chỉnh nếu cần
);
            string textz = string.Format("Số điện thoại: " + sdt);
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
   string.Format("Ngày tạo HD: {0}", hd.NgayLap),
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
new PointF(w / 2 - 50, y));
            e.Graphics.DrawString(
 string.Format("Số lượng"),
 new Font("Courier New", 10, FontStyle.Bold),
 Brushes.Black,
 new PointF(w / 2 + 150, y));
            e.Graphics.DrawString(
string.Format("Đơn giá"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 + 300, y));

            int i = 0;
            var allDatas = _HDCTservices.GetHDCTViewModel(idhd);
            decimal tongtien = 0;
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
 new PointF(w / 2 + 150, y));
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
            e.Graphics.DrawString(string.Format(tongtien + " đ"),
new Font("Courier New", 10, FontStyle.Bold),
Brushes.Black,
new PointF(w / 2 + 300, y));
            y += 20;
            e.Graphics.DrawString(string.Format("Thành tiền:"),
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
            printPreviewHD.Document = printDocument_HD;
            printPreviewHD.ShowDialog();
        }
    }
}
