namespace HoNhatAnh_1150080002_lab2
{
    partial class frmApDung4_ListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDaChon = new System.Windows.Forms.ListBox();
            this.btnSangPhai = new System.Windows.Forms.Button();
            this.btnTatCaSangPhai = new System.Windows.Forms.Button();
            this.btnSangTrai = new System.Windows.Forms.Button();
            this.btnTatCaSangTrai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách các mặt hàng";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(21, 37);
            this.lstDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSach.Size = new System.Drawing.Size(136, 212);
            this.lstDanhSach.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Các mặt hàng lựa chọn";
            // 
            // lstDaChon
            // 
            this.lstDaChon.FormattingEnabled = true;
            this.lstDaChon.Location = new System.Drawing.Point(244, 37);
            this.lstDaChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDaChon.Name = "lstDaChon";
            this.lstDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDaChon.Size = new System.Drawing.Size(136, 212);
            this.lstDaChon.TabIndex = 5;
            // 
            // btnSangPhai
            // 
            this.btnSangPhai.Location = new System.Drawing.Point(169, 62);
            this.btnSangPhai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSangPhai.Name = "btnSangPhai";
            this.btnSangPhai.Size = new System.Drawing.Size(60, 24);
            this.btnSangPhai.TabIndex = 1;
            this.btnSangPhai.Text = ">";
            this.btnSangPhai.UseVisualStyleBackColor = true;
            this.btnSangPhai.Click += new System.EventHandler(this.btnSangPhai_Click);
            // 
            // btnTatCaSangPhai
            // 
            this.btnTatCaSangPhai.Location = new System.Drawing.Point(169, 102);
            this.btnTatCaSangPhai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTatCaSangPhai.Name = "btnTatCaSangPhai";
            this.btnTatCaSangPhai.Size = new System.Drawing.Size(60, 24);
            this.btnTatCaSangPhai.TabIndex = 2;
            this.btnTatCaSangPhai.Text = ">>";
            this.btnTatCaSangPhai.UseVisualStyleBackColor = true;
            this.btnTatCaSangPhai.Click += new System.EventHandler(this.btnTatCaSangPhai_Click);
            // 
            // btnSangTrai
            // 
            this.btnSangTrai.Location = new System.Drawing.Point(169, 142);
            this.btnSangTrai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSangTrai.Name = "btnSangTrai";
            this.btnSangTrai.Size = new System.Drawing.Size(60, 24);
            this.btnSangTrai.TabIndex = 3;
            this.btnSangTrai.Text = "<";
            this.btnSangTrai.UseVisualStyleBackColor = true;
            this.btnSangTrai.Click += new System.EventHandler(this.btnSangTrai_Click);
            // 
            // btnTatCaSangTrai
            // 
            this.btnTatCaSangTrai.Location = new System.Drawing.Point(169, 183);
            this.btnTatCaSangTrai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTatCaSangTrai.Name = "btnTatCaSangTrai";
            this.btnTatCaSangTrai.Size = new System.Drawing.Size(60, 24);
            this.btnTatCaSangTrai.TabIndex = 4;
            this.btnTatCaSangTrai.Text = "<<";
            this.btnTatCaSangTrai.UseVisualStyleBackColor = true;
            this.btnTatCaSangTrai.Click += new System.EventHandler(this.btnTatCaSangTrai_Click);
            // 
            // frmApDung4_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 271);
            this.Controls.Add(this.btnTatCaSangTrai);
            this.Controls.Add(this.btnSangTrai);
            this.Controls.Add(this.btnTatCaSangPhai);
            this.Controls.Add(this.btnSangPhai);
            this.Controls.Add(this.lstDaChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmApDung4_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập 7";
            this.Load += new System.EventHandler(this.frmApDung4_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDaChon;
        private System.Windows.Forms.Button btnSangPhai;
        private System.Windows.Forms.Button btnTatCaSangPhai;
        private System.Windows.Forms.Button btnSangTrai;
        private System.Windows.Forms.Button btnTatCaSangTrai;
    }
}