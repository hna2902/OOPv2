using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmApDung4_ListBox : Form
    {
        public frmApDung4_ListBox()
        {
            InitializeComponent();
        }

        // Sự kiện xảy ra khi form được tải lên lần đầu
        private void frmApDung4_ListBox_Load(object sender, EventArgs e)
        {
            // Tạo một mảng chứa danh sách các mặt hàng
            string[] danhSachMatHang = { "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN" };

            // Thêm tất cả các mặt hàng từ mảng vào ListBox bên trái
            lstDanhSach.Items.AddRange(danhSachMatHang);
        }

        // Sự kiện cho nút > (chuyển các mục được chọn sang phải)
        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            // Tạo một danh sách tạm để lưu các mục được chọn
            var selectedItems = new List<object>();
            foreach (var item in lstDanhSach.SelectedItems)
            {
                selectedItems.Add(item);
            }

            // Duyệt qua danh sách tạm và xử lý
            foreach (var item in selectedItems)
            {
                lstDaChon.Items.Add(item); // Thêm vào danh sách bên phải
                lstDanhSach.Items.Remove(item); // Xóa khỏi danh sách bên trái
            }
        }

        // Sự kiện cho nút >> (chuyển tất cả sang phải)
        private void btnTatCaSangPhai_Click(object sender, EventArgs e)
        {
            // Thêm tất cả các mục từ danh sách trái sang phải
            lstDaChon.Items.AddRange(lstDanhSach.Items);

            // Xóa sạch danh sách bên trái
            lstDanhSach.Items.Clear();
        }

        // Sự kiện cho nút < (chuyển các mục được chọn sang trái)
        private void btnSangTrai_Click(object sender, EventArgs e)
        {
            // Logic tương tự nút >, nhưng đảo ngược
            var selectedItems = new List<object>();
            foreach (var item in lstDaChon.SelectedItems)
            {
                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                lstDanhSach.Items.Add(item); // Thêm vào danh sách trái
                lstDaChon.Items.Remove(item); // Xóa khỏi danh sách phải
            }
        }

        // Sự kiện cho nút << (chuyển tất cả sang trái)
        private void btnTatCaSangTrai_Click(object sender, EventArgs e)
        {
            // Thêm tất cả các mục từ danh sách phải sang trái
            lstDanhSach.Items.AddRange(lstDaChon.Items);

            // Xóa sạch danh sách bên phải
            lstDaChon.Items.Clear();
        }
    }
}