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

    public partial class FormBanHang : Form
    {
        SanPhamServisces _services;
        List<SanPham> sanPhams;
        public FormBanHang()
        {

            _services = new SanPhamServisces();
            sanPhams = _services.GetALL();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            LoadSPPanel(1);
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
            p.Name = sp.TenSanPham.ToString();
            p.BorderStyle = BorderStyle.Fixed3D;
            p.Size = new Size(600, 550);
            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(270, 230);
            ptb.Image = Image.FromFile(sp.Anh);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb.Location = new Point(4, 9);
            Label lbTen = new Label(); lbTen.Text = "Tên sản phẩm"; lbTen.AutoSize = true; lbTen.TextAlign = ContentAlignment.MiddleLeft;
            lbTen.Font = new Font(lbTen.Font.FontFamily, 12,FontStyle.Bold);
            lbTen.MaximumSize = new Size(200, 0); // Đặt kích thước tối đa cho chiều rộng


            lbTen.Location = new Point(300, 20);
            Label lbTenValue = new Label(); lbTenValue.Text = sp.TenSanPham; lbTenValue.Font = new Font(lbTenValue.Font.FontFamily, 12, FontStyle.Regular);
            lbTenValue.Location = new Point(320, 45);
            Label lbGia = new Label(); lbGia.Text = "Giá bán"; lbGia.Font = new Font(lbGia.Font.FontFamily, 12, FontStyle.Bold);
            lbGia.Location = new Point(300, 70);
            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.Gia + ""; lbGiaValue.Font = new Font(lbGiaValue.Font.FontFamily, 12, FontStyle.Underline);
            lbGiaValue.Location = new Point(320, 90);
            Label lbSL = new Label(); lbSL.Text = "Số lượng"; lbSL.Font = new Font(lbSL.Font.FontFamily, 12, FontStyle.Bold);
            lbSL.Location = new Point(300, 115);
            Label lbSLValue = new Label(); lbSLValue.Text = sp.SoLuong + ""; lbSLValue.Font = new Font(lbSLValue.Font.FontFamily, 12, FontStyle.Italic);
            lbSLValue.Location = new Point(320, 135);
            lbSLValue.Name = "SoLuong";
            Label lbMua = new Label(); lbMua.Text = "Số lượng mua"; lbMua.AutoSize = true; lbMua.TextAlign = ContentAlignment.MiddleLeft;
            lbMua.Font = new Font(lbMua.Font.FontFamily, 12, FontStyle.Bold); ;
            lbMua.Location = new Point(300, 160);
            TextBox lbSLmua = new TextBox();
            
            lbSLmua.Location = new Point(300, 200);lbSLmua.Name = "SoLuongMua";
            Button btnMua = new Button();
            btnMua.Location = new Point(320, 240);
            btnMua.MouseClick += BtnMua_MouseClick; ;
            btnMua.Size = new Size(100, 30); btnMua.Text = "Mua"; btnMua.BackColor = Color.Yellow;
            Label lbid = new Label();
            lbid.Text = "Sản phẩm ID:"; lbid.Font = new Font(lbid.Font.FontFamily, 12, FontStyle.Bold);
            lbid.Location = new Point(17, 260); lbid.AutoSize = true; lbid.TextAlign = ContentAlignment.MiddleLeft; lbid.MaximumSize = new Size(200, 0);
            Label lbidvalue = new Label();
            lbidvalue.Location = new Point(140, 260);
            lbidvalue.Text = sp.SanPhamId + ""; lbidvalue.Font = new Font(lbidvalue.Font.FontFamily, 12, FontStyle.Bold);
            p.Controls.Add(ptb);
            p.Controls.Add(lbTen); ; p.Controls.Add(lbTenValue); p.Controls.Add(lbGia); p.Controls.Add(lbGiaValue); p.Controls.Add(lbSL); p.Controls.Add(lbSLValue); p.Controls.Add(ptb); p.Controls.Add(lbMua); p.Controls.Add(lbSLmua); p.Controls.Add(btnMua);
            p.Controls.Add(lbid); p.Controls.Add(lbidvalue);
            return p;
        }

        private void BtnMua_MouseClick(object? sender, MouseEventArgs e)
        {

            Button b = (Button)sender;
            Panel p = (Panel)b.Parent;
            TextBox t = p.Controls["SoLuongMua"] as TextBox;
            int soluongmua = Convert.ToInt32(t.Text);
            Label soluong = p.Controls["SoLuong"] as Label;
            int soluongcon = Convert.ToInt32(soluong.Text);
            if (soluongmua > soluongcon)
            {
                MessageBox.Show($"Không thể mua {soluongmua} vì quá {soluongcon} sản phẩm");
            }
            else
            {
                MessageBox.Show("Bạn vừa chọn mua sản phẩm có id là  " + p.Name + " Với số lượng là: " + t.Text);
            }
            MessageBox.Show("Bạn Đã Mua" + p.Name);
        }
    }
}
