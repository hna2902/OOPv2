using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmThucHanh2_NhaKhoa : Form
    {
        public frmThucHanh2_NhaKhoa()
        {
            InitializeComponent();
        }

        // Sự kiện xảy ra khi nhấn nút "Tính tiền"
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // ValidateChildren() sẽ kích hoạt sự kiện Validating của tất cả các control
            // Nếu có bất kỳ control nào không hợp lệ (e.Cancel = true), nó sẽ trả về false
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng hàm lại nếu thông tin không hợp lệ
            }

            // Khai báo biến tổng tiền, dùng kiểu decimal để tính toán tiền tệ chính xác
            decimal tongTien = 0;

            // Kiểm tra từng checkbox và cộng tiền tương ứng
            if (chkLayCaoRang.Checked)
            {
                tongTien += 50000;
            }
            if (chkTayTrang.Checked)
            {
                tongTien += 100000;
            }
            if (chkHanRang.Checked)
            {
                // Nhân giá tiền với số lượng từ NumericUpDown
                tongTien += 100000 * nupHanRang.Value;
            }
            if (chkBeRang.Checked)
            {
                tongTien += 10000 * nupBeRang.Value;
            }
            if (chkBocRang.Checked)
            {
                tongTien += 1000000 * nupBocRang.Value;
            }

            // Hiển thị tổng tiền ra textbox với định dạng tiền tệ (dấu phẩy ngăn cách hàng nghìn)
            txtTongTien.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        // Sự kiện này xảy ra khi người dùng rời khỏi TextBox Tên khách hàng
        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra xem textbox có trống hoặc chỉ chứa khoảng trắng không
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                // e.Cancel = true; sẽ ngăn người dùng di chuyển focus sang control khác
                e.Cancel = true;
                txtTenKH.Focus(); // Giữ focus lại ở textbox này
                // Hiển thị biểu tượng lỗi bên cạnh textbox
                errorProvider.SetError(txtTenKH, "Tên khách hàng không được để trống!");
            }
            else
            {
                // Nếu dữ liệu hợp lệ, cho phép di chuyển focus
                e.Cancel = false;
                // Xóa biểu tượng lỗi
                errorProvider.SetError(txtTenKH, null);
            }
        }

        // Sự kiện cho nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }
    }
}