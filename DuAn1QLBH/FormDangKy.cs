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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
