using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void btnApDung1_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form USCLN
            frmApDung1_USCLN formUSCLN = new frmApDung1_USCLN();
            formUSCLN.Show();
        }

        private void btnThucHanh1_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form
            frmThucHanh1_MayTinh formMayTinh = new frmThucHanh1_MayTinh();
            formMayTinh.Show();
        }

        private void btnApDung2_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form Security Panel
            frmApDung2_Security formSecurity = new frmApDung2_Security();
            formSecurity.Show();
        }

        private void btnThucHanh2_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form Nha Khoa
            frmThucHanh2_NhaKhoa formNhaKhoa = new frmThucHanh2_NhaKhoa();
            formNhaKhoa.Show();
        }

        private void btnApDung3_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form Dang Nhap
            frmApDung3_DangNhap formDangNhap = new frmApDung3_DangNhap();
            formDangNhap.Show();
        }

        private void btnThucHanh3_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form Xu ly
            frmThucHanh3_XuLyDaySo formXuLySo = new frmThucHanh3_XuLyDaySo();
            formXuLySo.Show();
        }

        private void btnApDung4_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị Form
            frmApDung4_ListBox formListBox = new frmApDung4_ListBox();
            formListBox.Show();
        }
    }
}