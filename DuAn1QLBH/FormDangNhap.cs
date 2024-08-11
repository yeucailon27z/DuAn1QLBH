using BUS.Servisces;
using PRL;

namespace DuAn1QLBH
{
    public partial class FormDangNhap : Form
    {
        NhanVienServices _service;
        public FormDangNhap()
        {
            InitializeComponent();
            _service = new NhanVienServices();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            if (username == "")
            {
                MessageBox.Show("Vui lòng điền tài khoản");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu");
                return;
            }
            if (_service.Login(username, password) == "0")
            {
                MessageBox.Show("Đăng nhập thất bại, có thể tài khoản đã bị khóa hoặc sai thông tin");
                return;
            }
            else if (_service.Login(username, password) == "1")
            {
                MessageBox.Show("Đăng nhập thất bại, có ít nhất 2 tài khoản trùng");
                return;
            }
            else
            {
                string maNV = _service.GetNVID(username, password);
                string tenNV = _service.GetNVName(username, password);
                string accountInfor = _service.Login(username, password);
                FormTrangChu f = new FormTrangChu(maNV, tenNV, accountInfor);
                this.Hide();
                f.Show();
                // Điều hướng đến form đăng nhập hoặc form chínhFormTrangChu f = new FormTrangChu();
                f.FormClosed += F_FormClosed;

            }


        }

        private void F_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void chk_HienThiMk_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMk.Checked == true)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
