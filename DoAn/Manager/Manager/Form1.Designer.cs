namespace Manager
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.cbGiamGia = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTamTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhVien = new System.Windows.Forms.TextBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Enabled = false;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(597, 457);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.dgvHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(610, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 457);
            this.panel1.TabIndex = 2;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(88, 51);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(210, 20);
            this.txtMaSP.TabIndex = 9;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(87, 11);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(209, 20);
            this.txtTenSP.TabIndex = 8;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // dgvHang
            // 
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(5, 90);
            this.dgvHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowTemplate.Height = 24;
            this.dgvHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(520, 365);
            this.dgvHang.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sản  phẩm :";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::Manager.Properties.Resources.icons8_favorite_cart_100;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(313, 11);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 54);
            this.btnThem.TabIndex = 2;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm :";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(898, 486);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.ReadOnly = true;
            this.txtGiamGia.Size = new System.Drawing.Size(133, 20);
            this.txtGiamGia.TabIndex = 5;
            this.txtGiamGia.Text = "0";
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // cbGiamGia
            // 
            this.cbGiamGia.AutoSize = true;
            this.cbGiamGia.Location = new System.Drawing.Point(824, 488);
            this.cbGiamGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGiamGia.Name = "cbGiamGia";
            this.cbGiamGia.Size = new System.Drawing.Size(73, 17);
            this.cbGiamGia.TabIndex = 6;
            this.cbGiamGia.Text = "Giảm giá :";
            this.cbGiamGia.UseVisualStyleBackColor = true;
            this.cbGiamGia.CheckedChanged += new System.EventHandler(this.cbGiamGia_CheckedChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Image = global::Manager.Properties.Resources.icons8_money_bag_50;
            this.btnThanhToan.Location = new System.Drawing.Point(1039, 484);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(98, 57);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTamTinh
            // 
            this.txtTamTinh.Location = new System.Drawing.Point(668, 488);
            this.txtTamTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTamTinh.Name = "txtTamTinh";
            this.txtTamTinh.ReadOnly = true;
            this.txtTamTinh.Size = new System.Drawing.Size(126, 20);
            this.txtTamTinh.TabIndex = 7;
            this.txtTamTinh.Text = "0";
            this.txtTamTinh.TextChanged += new System.EventHandler(this.txtTamTinh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 491);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tạm tính:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(668, 521);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(126, 20);
            this.txtThanhTien.TabIndex = 7;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(832, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thành viên:";
            // 
            // txtThanhVien
            // 
            this.txtThanhVien.Location = new System.Drawing.Point(899, 522);
            this.txtThanhVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThanhVien.Name = "txtThanhVien";
            this.txtThanhVien.Size = new System.Drawing.Size(132, 20);
            this.txtThanhVien.TabIndex = 11;
            this.txtThanhVien.Leave += new System.EventHandler(this.txtThanhVien_Leave);
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(460, 493);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(116, 38);
            this.btnInHD.TabIndex = 24;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 569);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.txtThanhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTamTinh);
            this.Controls.Add(this.cbGiamGia);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.CheckBox cbGiamGia;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.TextBox txtTamTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhVien;
        private System.Windows.Forms.Button btnInHD;
    }
}

