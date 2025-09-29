using System;
using System.Windows.Forms;

namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmApDung1_USCLN : Form
    {
        public frmApDung1_USCLN()
        {
            InitializeComponent();
        }
        private long TimUSCLN(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

       // Hàm tìm BSCNN dựa trên công thức: BSCNN(a,b) = |a*b| / USCLN(a,b)
        private long TimBSCNN(long a, long b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return Math.Abs(a * b) / TimUSCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu cho số a
            if (!long.TryParse(txtSoA.Text, out long soA))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho a!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoA.Focus();
                return;
            }

            // Kiểm tra nhập liệu cho số b
            if (!long.TryParse(txtSoB.Text, out long soB))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho b!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoB.Focus();
                return;
            }

            // Kiểm tra tùy chọn và tính toán
            if (radUSCLN.Checked)
            {
                long ketqua = TimUSCLN(soA, soB);
                txtKetQua.Text = ketqua.ToString();
            }
            else // radBSCNN.Checked
            {
                long ketqua = TimBSCNN(soA, soB);
                txtKetQua.Text = ketqua.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}