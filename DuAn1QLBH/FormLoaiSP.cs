using BUS.Servisces;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormLoaiSP : Form
    {
        LoaiHangServices services = new LoaiHangServices();
        private bool loaiSanPham;

        public FormLoaiSP()
        {
            InitializeComponent();
        }

        private void FormLoaiSP_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {


        }
        public void LoadData()
        {
            dgv_LoaiSP.Rows.Clear();
            var data = services.GetAll();
            dgv_LoaiSP.ColumnCount = 5;
            dgv_LoaiSP.Columns[0].HeaderText = "STT";
            dgv_LoaiSP.Columns[1].HeaderText = " Mã loại";
            dgv_LoaiSP.Columns[2].HeaderText = "Tên loại";
            dgv_LoaiSP.Columns[3].HeaderText = " Mô tả";
            dgv_LoaiSP.Columns[4].HeaderText = " Trạng thái";

            int i = 0;
            foreach (var item in data)
            {
                i++;
                dgv_LoaiSP.Rows.Add(i, item.LoaiSanPhamId, item.TenLoai, item.MoTa, item.TrangThai);
            }

        }

        public void Reset()
        {
            txt_MaLoai.Text = "";
            txt_TenLoai.Text = "";
            txt_Mota.Text = "";
            cbb_TrangThai.Text = "";
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
            Reset();
        }
        public void Search()
        {
         
            int trangThai = cb_trangThai.SelectedIndex;
            string ten = txt_TenloaiSearch.Text.ToLower();
            var search = services.GetAll().Where(loaiSanPham => (trangThai == -1 || loaiSanPham.TrangThai == trangThai) &&
            (string.IsNullOrEmpty(ten) || loaiSanPham.TenLoai.ToLower().Contains(ten))).ToList();
            if (search.Count < 1)
            {
                MessageBox.Show("Không tìm thấy sản phẩm có Tên: " + ten + " Trạng thái: " + cb_trangThai.Text);

            } dgv_LoaiSP.Rows.Clear();
            int i = 0;
            foreach (var item in search)
            {
                i++;
                dgv_LoaiSP.Rows.Add(i, item.LoaiSanPhamId, item.TenLoai, item.MoTa, item.TrangThai);
            }
            txt_TenloaiSearch.Text = "";
            cb_trangThai.Text = "";
        }

        private void txt_Tenloai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenloaiSearch.Text) && cb_trangThai.SelectedIndex == -1)
            {
                LoadData();
            }

        }
        private void cbb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenloaiSearch.Text) && cb_trangThai.SelectedIndex == -1)
            {
                LoadData();
            }
        }
        private void FormLoaiSP_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_LoaiSP.Rows.Count)
                {
                    DataGridViewRow row = dgv_LoaiSP.Rows[e.RowIndex];
                    txt_MaLoai.Text = row.Cells[1].Value.ToString();
                    txt_TenLoai.Text = row.Cells[2].Value.ToString();
                    txt_Mota.Text = row.Cells[3].Value.ToString();
                    cbb_TrangThai.SelectedIndex = Convert.ToByte(row.Cells[4].Value.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            string ma = txt_MaLoai.Text;
            string ten = txt_TenLoai.Text;
            string mota = txt_Mota.Text;
            byte trangthai = (byte)cbb_TrangThai.SelectedIndex;

            LoaiSanPham loaiSanPham = new LoaiSanPham()
            {
                LoaiSanPhamId = ma,
                TenLoai = ten,
                MoTa = mota,
                TrangThai = trangthai,
            };
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MessageBox.Show(services.CreateLoaiSP(loaiSanPham));
                LoadData();
            }

        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            dgv_LoaiSP.Rows.Clear();
            try
            {
                string id = txt_MaLoai.Text;
                string ten = txt_TenLoai.Text;
                string mota = txt_Mota.Text;
                byte trangthai = (byte)cbb_TrangThai.SelectedIndex;

                LoaiSanPham lsp = new LoaiSanPham()
                {
                    LoaiSanPhamId = id,
                    TenLoai = ten,
                    MoTa = mota,
                    TrangThai = trangthai
                };
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(services.UpdateLoaiSP(lsp, id));
                    LoadData();
                    Reset();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            Reset();
            txt_TenloaiSearch.Text = "";
            cb_trangThai.Text = "";
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            Search();
            Reset();
        }
    }
}
