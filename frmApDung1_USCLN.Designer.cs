namespace HoNhatAnh_1150080002_lab2
{
    partial class frmApDung1_USCLN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.labelSoB = new System.Windows.Forms.Label();
            this.labelSoA = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.radBSCNN = new System.Windows.Forms.RadioButton();
            this.radUSCLN = new System.Windows.Forms.RadioButton();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.txtSoB);
            this.groupBoxInput.Controls.Add(this.txtSoA);
            this.groupBoxInput.Controls.Add(this.labelSoB);
            this.groupBoxInput.Controls.Add(this.labelSoA);
            this.groupBoxInput.Location = new System.Drawing.Point(19, 20);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Size = new System.Drawing.Size(188, 81);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Nhập dữ liệu";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(82, 49);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(91, 20);
            this.txtSoB.TabIndex = 1;
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(82, 24);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(91, 20);
            this.txtSoA.TabIndex = 0;
            // 
            // labelSoB
            // 
            this.labelSoB.AutoSize = true;
            this.labelSoB.Location = new System.Drawing.Point(15, 51);
            this.labelSoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoB.Name = "labelSoB";
            this.labelSoB.Size = new System.Drawing.Size(70, 13);
            this.labelSoB.TabIndex = 1;
            this.labelSoB.Text = "Số nguyên b:";
            // 
            // labelSoA
            // 
            this.labelSoA.AutoSize = true;
            this.labelSoA.Location = new System.Drawing.Point(15, 27);
            this.labelSoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoA.Name = "labelSoA";
            this.labelSoA.Size = new System.Drawing.Size(70, 13);
            this.labelSoA.TabIndex = 0;
            this.labelSoA.Text = "Số nguyên a:";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radBSCNN);
            this.groupBoxOptions.Controls.Add(this.radUSCLN);
            this.groupBoxOptions.Location = new System.Drawing.Point(225, 20);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOptions.Size = new System.Drawing.Size(112, 81);
            this.groupBoxOptions.TabIndex = 1;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Tùy chọn";
            // 
            // radBSCNN
            // 
            this.radBSCNN.AutoSize = true;
            this.radBSCNN.Location = new System.Drawing.Point(22, 50);
            this.radBSCNN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radBSCNN.Name = "radBSCNN";
            this.radBSCNN.Size = new System.Drawing.Size(62, 17);
            this.radBSCNN.TabIndex = 1;
            this.radBSCNN.TabStop = true;
            this.radBSCNN.Text = "BSCNN";
            this.radBSCNN.UseVisualStyleBackColor = true;
            // 
            // radUSCLN
            // 
            this.radUSCLN.AutoSize = true;
            this.radUSCLN.Checked = true;
            this.radUSCLN.Location = new System.Drawing.Point(22, 25);
            this.radUSCLN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radUSCLN.Name = "radUSCLN";
            this.radUSCLN.Size = new System.Drawing.Size(61, 17);
            this.radUSCLN.TabIndex = 0;
            this.radUSCLN.TabStop = true;
            this.radUSCLN.Text = "USCLN";
            this.radUSCLN.UseVisualStyleBackColor = true;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.txtKetQua);
            this.groupBoxResult.Location = new System.Drawing.Point(19, 114);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult.Size = new System.Drawing.Size(319, 49);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(82, 20);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(222, 20);
            this.txtKetQua.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(117, 179);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 24);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(199, 179);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmApDung1_USCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 222);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmApDung1_USCLN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm USCLN và BSCNN";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label labelSoB;
        private System.Windows.Forms.Label labelSoA;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radBSCNN;
        private System.Windows.Forms.RadioButton radUSCLN;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }
}