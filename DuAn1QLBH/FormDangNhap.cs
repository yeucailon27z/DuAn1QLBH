using PRL;

namespace DuAn1QLBH
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy f = new FormDangKy();
            f.ShowDialog();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            FormTrangChu f = new FormTrangChu();
            f.ShowDialog();
            this.Close();
        }
    }
}
