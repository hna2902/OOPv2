using System;
using System.Windows.Forms;

namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmThucHanh1_MayTinh : Form
    {
        public frmThucHanh1_MayTinh()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                txtKetQua.Text = (a + b).ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                txtKetQua.Text = (a - b).ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                txtKetQua.Text = (a * b).ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtKetQua.Text = (a / b).ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại
            }
        }

        // Hàm kiểm tra dữ liệu nhập vào có phải là số hay không
        private bool KiemTraDuLieu()
        {
            double ketQuaParse;
            if (!double.TryParse(txtA.Text, out ketQuaParse))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho a!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return false;
            }
            if (!double.TryParse(txtB.Text, out ketQuaParse))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho b!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                return false;
            }
            return true;
        }
    }
}