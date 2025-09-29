using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmApDung3_DangNhap : Form
    {
        public frmApDung3_DangNhap()
        {
            InitializeComponent();
        }

        // Sự kiện cho nút Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra tất cả các control trên form có hợp lệ hay không
            if (!this.ValidateChildren())
            {
                // Nếu có control không hợp lệ, hiển thị thông báo chung
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xử lý logic đăng nhập (ở đây ta chỉ hiển thị thông báo thành công)
            // Trong thực tế, bạn sẽ kiểm tra username và password với CSDL hoặc một danh sách
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sự kiện cho nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện kiểm tra khi người dùng rời khỏi ô Username
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true; // Ngăn không cho chuyển focus
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Tên đăng nhập không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsername, null); // Xóa lỗi
            }
        }

        // Sự kiện kiểm tra khi người dùng rời khỏi ô Password
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true; // Ngăn không cho chuyển focus
                txtPassword.Focus();
                errorProvider.SetError(txtPassword, "Mật khẩu không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null); // Xóa lỗi
            }
        }
    }
}