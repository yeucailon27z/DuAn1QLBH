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
            dgv_BangPhieuGiamGia.DataSource = null;
            dgv_BangPhieuGiamGia.DataSource = _service.GetAll();
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
                    tb_magg.Text = row.Cells[0].Value.ToString();
                    tb_tengg.Text = row.Cells[1].Value.ToString();
                    tb_PhanTrum.Text = row.Cells[5].Value.ToString();
                    tb_mote.Text = row.Cells[2].Value.ToString();
                    tb_min.Text = row.Cells[3].Value.ToString();
                    tb_max.Text = row.Cells[4].Value.ToString();
                    dtp_nbd.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                    dtp_nkt.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                    cb_tthai.SelectedIndex = Convert.ToByte(row.Cells[8].Value);
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
                    TienMin = TienMin,TienMax=TienMax,


                };
                MessageBox.Show(_service.Create(g));
                LoadData();
            }

            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }

        }
    }
}
