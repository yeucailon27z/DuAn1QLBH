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
            FormDangKy f = new FormDangKy();
            f.ShowDialog();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            bool isRegistered = _service.Login(username, password);
            if (username == "")
            {
                MessageBox.Show("Vui lòng điền tài khoản");
            }
            if (password == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu");
            }
            if (isRegistered)
            {
                MessageBox.Show("Đăng nhập thành công!");
                FormTrangChu f = new FormTrangChu();
                // Điều hướng đến form đăng nhập hoặc form chínhFormTrangChu f = new FormTrangChu();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
            }

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
    }
}
