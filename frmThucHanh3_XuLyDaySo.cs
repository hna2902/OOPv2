using System;
using System.Windows.Forms;

namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmThucHanh3_XuLyDaySo : Form
    {
        public frmThucHanh3_XuLyDaySo()
        {
            InitializeComponent();
        }

        // Sự kiện khi form được tải lên
        private void frmThucHanh3_XuLyDaySo_Load(object sender, EventArgs e)
        {
            // Dọn dẹp ListBox để đảm bảo nó trống khi bắt đầu
            lsbDaySo.Items.Clear();
        }

        // Sự kiện cho nút "Nhập số"
        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Cố gắng chuyển đổi text trong textbox thành số nguyên
            if (int.TryParse(txtInput.Text.Trim(), out int number))
            {
                // Nếu thành công, thêm số vào ListBox
                lsbDaySo.Items.Add(number);
                txtInput.Clear(); // Xóa textbox
                txtInput.Focus(); // Trả con trỏ về textbox
            }
            else
            {
                // Nếu không phải là số, hiển thị cảnh báo
                MessageBox.Show("Không phải số nguyên! Hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        // Sự kiện này ngăn người dùng nhập ký tự không phải là số
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar == (char)Keys.Back là để cho phép phím xóa (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bỏ qua ký tự không hợp lệ
            }
        }

        // Sự kiện cho nút "Tăng mỗi phần tử lên 2"
        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInput.Focus();
                return;
            }

            // Duyệt qua tất cả các phần tử trong ListBox
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                // Lấy giá trị, cộng thêm 2, rồi gán lại
                int value = (int)lsbDaySo.Items[i];
                lsbDaySo.Items[i] = value + 2;
            }
        }

        // Sự kiện cho nút "Chọn số chẵn đầu"
        private void btnChanDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) return; // Không làm gì nếu list trống

            // Duyệt từ đầu đến cuối
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int value = (int)lsbDaySo.Items[i];
                if (value % 2 == 0) // Nếu là số chẵn
                {
                    lsbDaySo.SelectedIndex = i; // Chọn nó
                    break; // Và thoát khỏi vòng lặp
                }
            }
        }

        // Sự kiện cho nút "Chọn số lẻ cuối"
        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) return;

            // Duyệt ngược từ cuối về đầu
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int value = (int)lsbDaySo.Items[i];
                if (value % 2 != 0) // Nếu là số lẻ
                {
                    lsbDaySo.SelectedIndex = i; // Chọn nó
                    break; // Và thoát
                }
            }
        }

        // Sự kiện cho nút "Xóa phần tử đang chọn"
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có phần tử nào đang được chọn không
            if (lsbDaySo.SelectedIndex != -1)
            {
                // Xóa phần tử tại vị trí đang được chọn
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn số cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện cho nút "Xóa phần tử đầu"
        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                // Xóa phần tử ở vị trí đầu tiên (index = 0)
                lsbDaySo.Items.RemoveAt(0);
            }
        }

        // Sự kiện cho nút "Xóa phần tử cuối"
        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                // Xóa phần tử ở vị trí cuối cùng
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
            }
        }

        // Sự kiện cho nút "Xóa dãy số"
        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear(); // Xóa tất cả các phần tử
        }

        // Sự kiện cho nút "Kết thúc"
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}