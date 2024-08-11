using DuAn1QLBH;
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
    public partial class FormTrangChu : Form
    {
        string accountInfors;
        string idNVs;
        string tenNVs;
        public FormTrangChu(string idNV, string tenNV, string accountInfor)
        {

            InitializeComponent();
            this.idNVs = idNV;
            this.tenNVs = tenNV;
            this.accountInfors = accountInfor;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mstr_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void tool_BanHang_MouseHover(object sender, EventArgs e)
        {

        }
        private void tool_BanHang_MouseLeave(object sender, EventArgs e)
        {
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormSanPham existingForm = pn_content.Controls.OfType<FormSanPham>().FirstOrDefault();

            if (existingForm == null)
            {
                FormSanPham f = new FormSanPham();
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon existingForm = pn_content.Controls.OfType<FormHoaDon>().FirstOrDefault();

            if (existingForm == null)
            {
                FormHoaDon f = new FormHoaDon();
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }
        }

        private void nhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaCungCap existingForm = pn_content.Controls.OfType<FormNhaCungCap>().FirstOrDefault();

            if (existingForm == null)
            {
                FormNhaCungCap f = new FormNhaCungCap();
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiSP existingForm = pn_content.Controls.OfType<FormLoaiSP>().FirstOrDefault();

            if (existingForm == null)
            {
                FormLoaiSP f = new FormLoaiSP();
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }
        }

        private void giảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiamGia existingForm = pn_content.Controls.OfType<FormGiamGia>().FirstOrDefault();

            if (existingForm == null)
            {
                FormGiamGia f = new FormGiamGia();
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang existingForm = pn_content.Controls.OfType<FormKhachHang>().FirstOrDefault();

            if (existingForm == null)
            {
                FormKhachHang f = new FormKhachHang();
            pn_content.Controls.Clear();
            f.TopLevel = false;
            f.BackColor = Color.FromArgb(255, 224, 192);

            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }

        }

        private void tool_BanHang_Click(object sender, EventArgs e)
        {
            FormBanHang existingForm = pn_content.Controls.OfType<FormBanHang>().FirstOrDefault();

            if (existingForm == null)
            {
                FormBanHang f = new FormBanHang(idNVs);
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {
                
                existingForm.BringToFront(); 
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            string[] infor = accountInfors.Split(':');

            if (infor[0] == "1")
            {
                sảnPhẩmToolStripMenuItem.Visible = false;
                hóaĐơnToolStripMenuItem.Visible = false;
                nhàToolStripMenuItem.Visible = false;
                loạiHàngToolStripMenuItem.Visible = false;
                giảmGiáToolStripMenuItem.Visible = false;
                kháchHàngToolStripMenuItem.Visible = false;
                doanhThuToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
            }
            lbl_TenNV.Text = tenNVs + " (" + idNVs + ")";

            timer1.Start();

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            pn_content.Controls.Add(pictureBox2);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_Time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            lb_Time.Text = DateTime.Now.ToString();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoanhThu existingForm = pn_content.Controls.OfType<FormDoanhThu>().FirstOrDefault();

            if (existingForm == null)
            {
                FormDoanhThu f = new FormDoanhThu();
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Close();
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien existingForm = pn_content.Controls.OfType<FormNhanVien>().FirstOrDefault();

            if (existingForm == null)
            {
                FormNhanVien f = new FormNhanVien();
                f.BackColor = Color.FromArgb(255, 224, 192);
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                pn_content.Controls.Clear();
                pn_content.Controls.Add(f);
                f.Show();
            }
            else
            {

                existingForm.BringToFront();
            }
        }
    }
}