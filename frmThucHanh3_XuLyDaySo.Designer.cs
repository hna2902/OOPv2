namespace HoNhatAnh_1150080002_lab2
{
    partial class frmThucHanh3_XuLyDaySo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.groupBoxFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.btnNhap);
            this.groupBoxInput.Controls.Add(this.txtInput);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Location = new System.Drawing.Point(9, 10);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Size = new System.Drawing.Size(345, 57);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Nhập số";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(255, 20);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 24);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(90, 24);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(151, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.lsbDaySo);
            this.groupBoxList.Location = new System.Drawing.Point(9, 72);
            this.groupBoxList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxList.Size = new System.Drawing.Size(150, 260);
            this.groupBoxList.TabIndex = 1;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Dãy số";
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbDaySo.FormattingEnabled = true;
            this.lsbDaySo.Location = new System.Drawing.Point(2, 15);
            this.lsbDaySo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(146, 243);
            this.lsbDaySo.TabIndex = 0;
            // 
            // groupBoxFunctions
            // 
            this.groupBoxFunctions.Controls.Add(this.btnXoaDaySo);
            this.groupBoxFunctions.Controls.Add(this.btnXoaCuoi);
            this.groupBoxFunctions.Controls.Add(this.btnXoaDau);
            this.groupBoxFunctions.Controls.Add(this.btnXoaChon);
            this.groupBoxFunctions.Controls.Add(this.btnLeCuoi);
            this.groupBoxFunctions.Controls.Add(this.btnChanDau);
            this.groupBoxFunctions.Controls.Add(this.btnTang2);
            this.groupBoxFunctions.Location = new System.Drawing.Point(164, 72);
            this.groupBoxFunctions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFunctions.Size = new System.Drawing.Size(190, 260);
            this.groupBoxFunctions.TabIndex = 2;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "Chức năng";
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.Location = new System.Drawing.Point(15, 219);
            this.btnXoaDaySo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(161, 24);
            this.btnXoaDaySo.TabIndex = 6;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = true;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(15, 187);
            this.btnXoaCuoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(161, 24);
            this.btnXoaCuoi.TabIndex = 5;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Location = new System.Drawing.Point(15, 154);
            this.btnXoaDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(161, 24);
            this.btnXoaDau.TabIndex = 4;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(15, 122);
            this.btnXoaChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(161, 24);
            this.btnXoaChon.TabIndex = 3;
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnLeCuoi
            // 
            this.btnLeCuoi.Location = new System.Drawing.Point(15, 89);
            this.btnLeCuoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeCuoi.Name = "btnLeCuoi";
            this.btnLeCuoi.Size = new System.Drawing.Size(161, 24);
            this.btnLeCuoi.TabIndex = 2;
            this.btnLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnLeCuoi.UseVisualStyleBackColor = true;
            this.btnLeCuoi.Click += new System.EventHandler(this.btnLeCuoi_Click);
            // 
            // btnChanDau
            // 
            this.btnChanDau.Location = new System.Drawing.Point(15, 57);
            this.btnChanDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChanDau.Name = "btnChanDau";
            this.btnChanDau.Size = new System.Drawing.Size(161, 24);
            this.btnChanDau.TabIndex = 1;
            this.btnChanDau.Text = "Chọn số chẵn đầu";
            this.btnChanDau.UseVisualStyleBackColor = true;
            this.btnChanDau.Click += new System.EventHandler(this.btnChanDau_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(15, 24);
            this.btnTang2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(161, 24);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(9, 341);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(345, 24);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // frmThucHanh3_XuLyDaySo
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 375);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBoxFunctions);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThucHanh3_XuLyDaySo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng xử lý dãy số";
            this.Load += new System.EventHandler(this.frmThucHanh3_XuLyDaySo_Load);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.Button btnXoaDaySo;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnLeCuoi;
        private System.Windows.Forms.Button btnChanDau;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnKetThuc;
    }
}