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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL
{
    public partial class FormGiamGia : Form
    {
        GiamGiaServices _service;
        public FormGiamGia()
        {
            _service = new GiamGiaServices();
            InitializeComponent();
        }
        public void LoadData()
        {
            dgv_BangPhieuGiamGia.Rows.Clear();

            dgv_BangPhieuGiamGia.BorderStyle = BorderStyle.None;

            var allDatas = _service.GetAll();
            dgv_BangPhieuGiamGia.ColumnCount = 10;
            dgv_BangPhieuGiamGia.Columns[0].HeaderText = "STT";
            dgv_BangPhieuGiamGia.Columns[1].HeaderText = "ID Giảm Giá";
            dgv_BangPhieuGiamGia.Columns[2].HeaderText = "Mã Giảm Giá";
            dgv_BangPhieuGiamGia.Columns[3].HeaderText = "Mô tả";
            dgv_BangPhieuGiamGia.Columns[4].HeaderText = "Tiền Min";
            dgv_BangPhieuGiamGia.Columns[5].HeaderText = "Tiền Max";
            dgv_BangPhieuGiamGia.Columns[6].HeaderText = "Phần Trăm Giảm";
            dgv_BangPhieuGiamGia.Columns[7].HeaderText = "Ngày Bắt Đầu";
            dgv_BangPhieuGiamGia.Columns[8].HeaderText = "Ngày Kết Thúc";
            dgv_BangPhieuGiamGia.Columns[9].HeaderText = "Trạng Thái";
            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                dgv_BangPhieuGiamGia.Rows.Add(i, data.GiamGiaId, data.MaGiamGia, data.MoTa, data.TienMin, data.TienMax, data.PhanTramGiam, data.NgayBatDau, data.NgayKetThuc, data.TrangThai);
            }
        }

        private void FormGiamGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_BangPhieuGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_BangPhieuGiamGia.Rows.Count)
                {
                    DataGridViewRow row = dgv_BangPhieuGiamGia.Rows[e.RowIndex];
                    tb_magg.Text = row.Cells[1].Value.ToString();
                    tb_tengg.Text = row.Cells[2].Value.ToString();
                    tb_PhanTrum.Text = row.Cells[6].Value.ToString();
                    tb_mote.Text = row.Cells[3].Value.ToString();
                    tb_min.Text = row.Cells[4].Value.ToString();
                    tb_max.Text = row.Cells[5].Value.ToString();
                    dtp_nbd.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                    dtp_nkt.Value = DateTime.Parse(row.Cells[8].Value.ToString());
                    cb_tthai.SelectedIndex = Convert.ToByte(row.Cells[9].Value);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = tb_magg.Text;
                string ten = tb_tengg.Text;
                string mota = tb_mote.Text;

                decimal phantramgiam = Convert.ToDecimal(tb_PhanTrum.Text);
                decimal TienMin = Convert.ToDecimal(tb_min.Text);
                decimal TienMax = Convert.ToDecimal(tb_max.Text);
                DateOnly ngaybatdau = DateOnly.FromDateTime(dtp_nbd.Value);
                DateOnly ngayketthuc = DateOnly.FromDateTime(dtp_nkt.Value);
                byte trangthai = (byte)cb_tthai.SelectedIndex;
                GiamGium g = new GiamGium()
                {
                    MaGiamGia = ten,
                    MoTa = mota,
                    PhanTramGiam = phantramgiam,
                    NgayBatDau = ngaybatdau,
                    NgayKetThuc = ngayketthuc,
                    TrangThai = trangthai,
                    TienMin = TienMin,
                    TienMax = TienMax,
                };

                MessageBox.Show(_service.UpdateGG(g, ma));
                LoadData();

            }

            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
            tb_magg.Text = "";
            tb_max.Text = "";
            tb_min.Text = "";
            tb_mote.Text = "";
            tb_PhanTrum.Text = "";
            tb_tengg.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = tb_magg.Text;
                string ten = tb_tengg.Text;
                string mota = tb_mote.Text;

                decimal TienMin = Convert.ToDecimal(tb_min.Text);
                decimal TienMax = Convert.ToDecimal(tb_max.Text);
                decimal phantramgiam = Convert.ToDecimal(tb_PhanTrum.Text);
                DateOnly ngaybatdau = DateOnly.FromDateTime(dtp_nbd.Value);
                DateOnly ngayketthuc = DateOnly.FromDateTime(dtp_nkt.Value);
                byte trangthai = (byte)cb_tthai.SelectedIndex;
                GiamGium g = new GiamGium()
                {
                    GiamGiaId = ma,
                    MaGiamGia = ten,
                    MoTa = mota,
                    PhanTramGiam = phantramgiam,
                    NgayBatDau = ngaybatdau,
                    NgayKetThuc = ngayketthuc,
                    TrangThai = trangthai,
                    TienMin = TienMin,
                    TienMax = TienMax,


                };
                MessageBox.Show(_service.Create(g));
                LoadData();
            }

            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
            tb_magg.Text = "";
            tb_max.Text = "";
            tb_min.Text = "";
            tb_mote.Text = "";
            tb_PhanTrum.Text = "";
            tb_tengg.Text = "";
            cb_tthai.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchData();
        }
        private void SearchData()
        {
            // Xóa các hàng hiện có trong DataGridView
            dgv_BangPhieuGiamGia.Rows.Clear();

            string ten = txt_SearchTen.Text;
            decimal gia;
            bool isGiaValid = decimal.TryParse(txt_KhoangGG.Text, out gia);

            // Tìm các phiếu giảm giá dựa trên điều kiện tìm kiếm
            var searchResults = _service.GetAll()
                .Where(gg => (string.IsNullOrEmpty(ten) || gg.MaGiamGia.ToLower().Contains(ten.ToLower())) &&
                             (!isGiaValid || gg.TienMin <= gia))
                .ToList();

            // Kiểm tra kết quả tìm kiếm
            if (searchResults.Count < 1)
            {
                // Thông báo nếu không tìm thấy kết quả
                MessageBox.Show("Không tìm thấy giảm giá với Tên: " + ten + " và Khoảng giá: " + (isGiaValid ? gia.ToString() : "Không xác định"));
                return;
            }

            // Hiển thị kết quả tìm kiếm lên DataGridView
            int i = 0;
            foreach (var data in searchResults)
            {
                i++;
                dgv_BangPhieuGiamGia.Rows.Add(i, data.GiamGiaId, data.MaGiamGia, data.MoTa, data.TienMin, data.TienMax, data.PhanTramGiam, data.NgayBatDau, data.NgayKetThuc, data.TrangThai);
            }
            txt_KhoangGG.Text = "";
            txt_SearchTen.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txt_KhoangGG.Text = "";
            txt_SearchTen.Text = "";
            tb_magg.Text = "";
            tb_max.Text = "";
            tb_min.Text = "";
            tb_mote.Text = "";
            tb_PhanTrum.Text = "";
            tb_tengg.Text = "";
            cb_tthai.SelectedIndex = 0;
        }
    }
}
