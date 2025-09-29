using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HoNhatAnh_1150080002_lab2
{
    public partial class frmApDung2_Security : Form
    {
        // Dùng Dictionary để lưu trữ mật khẩu, dễ quản lý và tra cứu
        private Dictionary<string, List<string>> passwordList;

        public frmApDung2_Security()
        {
            InitializeComponent();
        }

        private void frmApDung2_Security_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách mật khẩu khi form được tải
            passwordList = new Dictionary<string, List<string>>();
            passwordList.Add("Phát triển công nghệ", new List<string> { "1496", "2673" });
            passwordList.Add("Nghiên cứu viên", new List<string> { "7462" });
            passwordList.Add("Thiết kế mô hình", new List<string> { "8884", "3842", "3383" });

            // Gán sự kiện cho các nút bấm
            // Dùng chung một sự kiện cho tất cả các nút số
            btn1.Click += new EventHandler(btnNumber_Click);
            btn2.Click += new EventHandler(btnNumber_Click);
            btn3.Click += new EventHandler(btnNumber_Click);
            btn4.Click += new EventHandler(btnNumber_Click);
            btn5.Click += new EventHandler(btnNumber_Click);
            btn6.Click += new EventHandler(btnNumber_Click);
            btn7.Click += new EventHandler(btnNumber_Click);
            btn8.Click += new EventHandler(btnNumber_Click);
            btn9.Click += new EventHandler(btnNumber_Click);
            btn0.Click += new EventHandler(btnNumber_Click);

            btnClear.Click += new EventHandler(btnClear_Click);
            btnEnter.Click += new EventHandler(btnEnter_Click);
        }

        // Sự kiện dùng chung cho các nút số 0-9
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            if (pressedButton != null)
            {
                txtPassword.Text += pressedButton.Text;
            }
        }

        // Sự kiện cho nút Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        // Sự kiện cho nút Enter
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;
            string groupName = "Không có";
            string result = "Từ chối!";
            bool accessGranted = false;

            // Duyệt qua danh sách mật khẩu để kiểm tra
            foreach (var group in passwordList)
            {
                if (group.Value.Contains(enteredPassword))
                {
                    groupName = group.Key;
                    result = "Chấp nhận!";
                    accessGranted = true;
                    break; // Thoát khỏi vòng lặp khi đã tìm thấy
                }
            }

            // Ghi log lại
            LogAccessAttempt(groupName, result);

            // Xóa ô password để chuẩn bị cho lần nhập tiếp theo
            txtPassword.Clear();
        }

        // Hàm để ghi lại một lần truy cập vào ListView
        private void LogAccessAttempt(string group, string result)
        {
            // Lấy thời gian hiện tại
            string timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Tạo một mục mới cho ListView
            ListViewItem logEntry = new ListViewItem(timestamp);
            logEntry.SubItems.Add(group);
            logEntry.SubItems.Add(result);

            // Thêm mục mới vào đầu danh sách log để cái mới nhất luôn ở trên
            lvLog.Items.Insert(0, logEntry);
        }
    }
}