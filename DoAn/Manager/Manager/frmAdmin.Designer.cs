namespace Manager
{
    partial class frmAdmin
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
            this.btnKhangHang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKhangHang
            // 
            this.btnKhangHang.Location = new System.Drawing.Point(17, 146);
            this.btnKhangHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhangHang.Name = "btnKhangHang";
            this.btnKhangHang.Size = new System.Drawing.Size(151, 59);
            this.btnKhangHang.TabIndex = 1;
            this.btnKhangHang.Text = "Khách hàng";
            this.btnKhangHang.UseVisualStyleBackColor = true;
            this.btnKhangHang.Click += new System.EventHandler(this.btnKhangHang_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(16, 229);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(151, 59);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Location = new System.Drawing.Point(16, 316);
            this.btnHangHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(151, 59);
            this.btnHangHoa.TabIndex = 3;
            this.btnHangHoa.Text = "Hàng hóa";
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(192, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 562);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1127, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Cửa Hàng Tiện Lợi";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(17, 399);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(151, 59);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(17, 476);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(150, 60);
            this.btnNhapHang.TabIndex = 5;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 688);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHangHoa);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.btnKhangHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKhangHang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnNhapHang;

    }
}