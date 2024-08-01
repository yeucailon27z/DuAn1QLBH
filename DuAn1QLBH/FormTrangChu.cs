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
        string idNVs;
        string tenNVs;
        public FormTrangChu(string idNV,string tenNV)
        {

            InitializeComponent();
            this.idNVs = idNV;
            this.tenNVs=tenNV;
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
            pn_content.Controls.Clear();

            FormSanPham f = new FormSanPham();
            f.BackColor = Color.FromArgb(255, 224, 192);

            f.TopLevel = false;
            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();


        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pn_content.Controls.Clear();
            FormHoaDon f = new FormHoaDon();
            f.BackColor = Color.FromArgb(255, 224, 192);

            f.TopLevel = false;
            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void nhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaCungCap f = new FormNhaCungCap();
            pn_content.Controls.Clear();
            f.BackColor = Color.FromArgb(255, 224, 192);

            f.TopLevel = false;
            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiSP f = new FormLoaiSP();
            pn_content.Controls.Clear();
            f.BackColor = Color.FromArgb(255, 224, 192);

            f.TopLevel = false;
            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void giảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiamGia f = new FormGiamGia();
            pn_content.Controls.Clear();
            f.BackColor = Color.FromArgb(255, 224, 192);

            f.TopLevel = false;
            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();
            pn_content.Controls.Clear();
            f.TopLevel = false;
            f.BackColor = Color.FromArgb(255, 224, 192);

            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void tool_BanHang_Click(object sender, EventArgs e)
        {
            pn_content.Controls.Clear();
            FormBanHang f = new FormBanHang(idNVs);
            f.BackColor = Color.FromArgb(255, 224, 192);
            f.TopLevel = false;
            pn_content.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            lbl_TenNV.Text = tenNVs;
            lb_Time.TopLevelControl.Text = Text; lb_Time.Visible = true;
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
    }
}