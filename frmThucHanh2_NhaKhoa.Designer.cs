namespace HoNhatAnh_1150080002_lab2
{
    partial class frmThucHanh2_NhaKhoa
    {
        // Biến lưu trữ các component của form
        private System.ComponentModel.IContainer components = null;

        // Phương thức dọn dẹp tài nguyên
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Phương thức này do Designer tự động tạo ra, không nên sửa bằng tay
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.groupBoxDichVu = new System.Windows.Forms.GroupBox();
            this.nupBocRang = new System.Windows.Forms.NumericUpDown();
            this.nupBeRang = new System.Windows.Forms.NumericUpDown();
            this.nupHanRang = new System.Windows.Forms.NumericUpDown();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkLayCaoRang = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Blue;
            this.labelTitle.Location = new System.Drawing.Point(38, 16);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(362, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DỊCH VỤ TÍNH TIỀN NHA KHOA";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Location = new System.Drawing.Point(22, 57);
            this.labelTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(89, 13);
            this.labelTenKH.TabIndex = 1;
            this.labelTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(112, 54);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(248, 20);
            this.txtTenKH.TabIndex = 0;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);
            // 
            // groupBoxDichVu
            // 
            this.groupBoxDichVu.Controls.Add(this.nupBocRang);
            this.groupBoxDichVu.Controls.Add(this.nupBeRang);
            this.groupBoxDichVu.Controls.Add(this.nupHanRang);
            this.groupBoxDichVu.Controls.Add(this.chkBocRang);
            this.groupBoxDichVu.Controls.Add(this.chkBeRang);
            this.groupBoxDichVu.Controls.Add(this.chkHanRang);
            this.groupBoxDichVu.Controls.Add(this.chkTayTrang);
            this.groupBoxDichVu.Controls.Add(this.chkLayCaoRang);
            this.groupBoxDichVu.Location = new System.Drawing.Point(25, 89);
            this.groupBoxDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDichVu.Name = "groupBoxDichVu";
            this.groupBoxDichVu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDichVu.Size = new System.Drawing.Size(335, 162);
            this.groupBoxDichVu.TabIndex = 1;
            this.groupBoxDichVu.TabStop = false;
            this.groupBoxDichVu.Text = "Dịch vụ";
            // 
            // nupBocRang
            // 
            this.nupBocRang.Location = new System.Drawing.Point(262, 130);
            this.nupBocRang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupBocRang.Name = "nupBocRang";
            this.nupBocRang.Size = new System.Drawing.Size(52, 20);
            this.nupBocRang.TabIndex = 7;
            this.nupBocRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupBocRang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupBeRang
            // 
            this.nupBeRang.Location = new System.Drawing.Point(262, 104);
            this.nupBeRang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupBeRang.Name = "nupBeRang";
            this.nupBeRang.Size = new System.Drawing.Size(52, 20);
            this.nupBeRang.TabIndex = 6;
            this.nupBeRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupBeRang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupHanRang
            // 
            this.nupHanRang.Location = new System.Drawing.Point(262, 78);
            this.nupHanRang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupHanRang.Name = "nupHanRang";
            this.nupHanRang.Size = new System.Drawing.Size(52, 20);
            this.nupHanRang.TabIndex = 5;
            this.nupHanRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupHanRang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkBocRang
            // 
            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Location = new System.Drawing.Point(22, 131);
            this.chkBocRang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBocRang.Name = "chkBocRang";
            this.chkBocRang.Size = new System.Drawing.Size(133, 17);
            this.chkBocRang.TabIndex = 4;
            this.chkBocRang.Text = "Bọc răng (1.000.000đ)";
            this.chkBocRang.UseVisualStyleBackColor = true;
            // 
            // chkBeRang
            // 
            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Location = new System.Drawing.Point(22, 105);
            this.chkBeRang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBeRang.Name = "chkBeRang";
            this.chkBeRang.Size = new System.Drawing.Size(112, 17);
            this.chkBeRang.TabIndex = 3;
            this.chkBeRang.Text = "Bẻ răng (10.000đ)";
            this.chkBeRang.UseVisualStyleBackColor = true;
            // 
            // chkHanRang
            // 
            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Location = new System.Drawing.Point(22, 79);
            this.chkHanRang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkHanRang.Name = "chkHanRang";
            this.chkHanRang.Size = new System.Drawing.Size(125, 17);
            this.chkHanRang.TabIndex = 2;
            this.chkHanRang.Text = "Hàn răng (100.000đ)";
            this.chkHanRang.UseVisualStyleBackColor = true;
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Location = new System.Drawing.Point(22, 53);
            this.chkTayTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTayTrang.Name = "chkTayTrang";
            this.chkTayTrang.Size = new System.Drawing.Size(150, 17);
            this.chkTayTrang.TabIndex = 1;
            this.chkTayTrang.Text = "Tẩy trắng răng (100.000đ)";
            this.chkTayTrang.UseVisualStyleBackColor = true;
            // 
            // chkLayCaoRang
            // 
            this.chkLayCaoRang.AutoSize = true;
            this.chkLayCaoRang.Location = new System.Drawing.Point(22, 27);
            this.chkLayCaoRang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLayCaoRang.Name = "chkLayCaoRang";
            this.chkLayCaoRang.Size = new System.Drawing.Size(137, 17);
            this.chkLayCaoRang.TabIndex = 0;
            this.chkLayCaoRang.Text = "Lấy cao răng (50.000đ)";
            this.chkLayCaoRang.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(112, 292);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 24);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.CausesValidation = false;
            this.btnThoat.Location = new System.Drawing.Point(210, 292);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(110, 262);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(55, 13);
            this.labelTongTien.TabIndex = 5;
            this.labelTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(165, 260);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(196, 20);
            this.txtTongTien.TabIndex = 2;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmThucHanh2_NhaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(399, 336);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupBoxDichVu);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThucHanh2_NhaKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng khám nha khoa";
            this.groupBoxDichVu.ResumeLayout(false);
            this.groupBoxDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các biến control để có thể truy cập trong code
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox groupBoxDichVu;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkLayCaoRang;
        private System.Windows.Forms.NumericUpDown nupBocRang;
        private System.Windows.Forms.NumericUpDown nupBeRang;
        private System.Windows.Forms.NumericUpDown nupHanRang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}