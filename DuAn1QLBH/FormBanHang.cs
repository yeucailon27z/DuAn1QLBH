using BUS.Servisces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        KhachHangServices _servicesKH;
        List<SanPham> sanPhams;
        List<SanPham> sp;
        HoaDonServices _HDservices;
        public Guid currentBillId = Guid.Empty;
        public FormBanHang(string idNVs)
        {
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
            Guid newGuid = Guid.NewGuid();
            currentBillId = newGuid;
            lbl_MaHD.Text = currentBillId.ToString();
            MessageBox.Show(_HDservices.Creates(currentBillId, idNVz, "KH001"));
            LoadDataHD();
        }



        private void FormBanHang_Load(object sender, EventArgs e)
        {
            List<string> loaiHangName = _servicesLH.GetLoaiHangIDs();
            cbb_LoaiHang.DataSource = loaiHangName;

            List<string> maGiamGia = _servicesGG.GetMaGG();
            cbb_Voucher.DataSource = maGiamGia;
            List<string> maKH = _servicesKH.GetKhachHangNames();
            cbb_MaKH.DataSource = maKH;
            LoadSPPanel(1);
            LoadDataHD();
            timer1.Start();
        }
        public void LoadSPPanel(int page)
        {
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
        public Panel CreatePanelSP(SanPham sp)//Mỗi sản phẩm được tạo ra và nằm trong 1 panel,
                                              //panel này sẽ được thêm vào tablelayoutpanel//phương thức này trả về 1 panel
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
                    MessageBox.Show( _HDCTservices.CheckSPinHD(idSP, idHD, Soluong));
                    LoadSPPanel(1);
                    dgv_HDCT.DataSource = null;
                    HDCTRepositories hDCTRepos = new HDCTRepositories();
                    var allHDCT = hDCTRepos.GetHDCTbyIDHD(currentBillId);
                    dgv_HDCT.DataSource = allHDCT;
                    long money = _HDCTservices.Caculator(currentBillId);
                    _HDservices = new HoaDonServices();
                    MessageBox.Show(_HDservices.Update(currentBillId, 1, money));
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
            LoadSPPanelSearch(1);
        }
        public void LoadSPPanelSearch(int page)
        {
            tableLayoutPanel1.Controls.Clear();
            string searchTen = txt_SearchTen.Text;
            string searchLoai = cbb_LoaiHang.Text;



            List<SanPham> searchResults = sanPhams.Where(p => (string.IsNullOrEmpty(searchLoai) || p.LoaiSanPhamId == searchLoai) &&
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

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           currentBillId = Guid.Parse(dgv_HoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());
            lbl_MaHD.Text = currentBillId.ToString();
            decimal ttsp = 0;
            int i = 0;
            var allDatas = _HDCTservices.GetHDCTbyIDHD(currentBillId);
           
            dgv_HDCT.DataSource = allDatas;
            decimal tthd = Convert.ToDecimal(dgv_HoaDon.Rows[e.RowIndex].Cells[7].Value.ToString());
            lbl_tthd.Text = tthd.ToString();
            lbl_ttsp.Text = ttsp.ToString();
            cbb_PTTT.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[6].Value.ToString();
            //cbb_Voucher.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbb_MaKH.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
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
    }
}
