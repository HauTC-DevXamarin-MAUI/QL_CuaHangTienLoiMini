namespace Manager
{
    partial class UCKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.butback = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhach
            // 
            this.dgvKhach.AllowUserToAddRows = false;
            this.dgvKhach.AllowUserToDeleteRows = false;
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(447, 159);
            this.dgvKhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhach.MultiSelect = false;
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhach.Size = new System.Drawing.Size(729, 362);
            this.dgvKhach.TabIndex = 80;
            this.dgvKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            this.dgvKhach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvKhach_DataBindingComplete);
            this.dgvKhach.SelectionChanged += new System.EventHandler(this.dgvKhach_SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-4, 697);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 63);
            this.button1.TabIndex = 79;
            this.button1.Text = "QUAY LẠI";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(976, 105);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(173, 52);
            this.btnSua.TabIndex = 70;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(711, 105);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 52);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(447, 105);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(175, 52);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 72;
            this.label6.Text = "ĐIỂM TÍCH LŨY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 73;
            this.label4.Text = "MẬT KHẨU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "ĐỊA CHỈ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-5, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 75;
            this.label2.Text = "TÊN KHÁCH HÀNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, -59);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(483, 52);
            this.label5.TabIndex = 76;
            this.label5.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "SỐ ĐIỆN THOẠI";
            // 
            // txtdiem
            // 
            this.txtdiem.Enabled = false;
            this.txtdiem.Location = new System.Drawing.Point(203, 460);
            this.txtdiem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(233, 22);
            this.txtdiem.TabIndex = 67;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(203, 391);
            this.txtmk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(233, 22);
            this.txtmk.TabIndex = 66;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(203, 241);
            this.txtten.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtten.Name = "txtten";
            this.txtten.ShortcutsEnabled = false;
            this.txtten.Size = new System.Drawing.Size(233, 22);
            this.txtten.TabIndex = 64;
            this.txtten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtten_KeyPress);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(203, 167);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtsdt.MaxLength = 10;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.ShortcutsEnabled = false;
            this.txtsdt.Size = new System.Drawing.Size(233, 22);
            this.txtsdt.TabIndex = 63;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            this.txtsdt.Leave += new System.EventHandler(this.txtsdt_Leave);
            // 
            // butback
            // 
            this.butback.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butback.CausesValidation = false;
            this.butback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butback.ForeColor = System.Drawing.Color.White;
            this.butback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butback.Location = new System.Drawing.Point(28, 726);
            this.butback.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.butback.Name = "butback";
            this.butback.Size = new System.Drawing.Size(13, 0);
            this.butback.TabIndex = 71;
            this.butback.Text = "QUAY LẠI";
            this.butback.UseVisualStyleBackColor = false;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(203, 316);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(233, 22);
            this.txtdiachi.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(546, 51);
            this.label7.TabIndex = 81;
            this.label7.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvKhach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.butback);
            this.Controls.Add(this.txtdiachi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCKhachHang";
            this.Size = new System.Drawing.Size(1193, 567);
            this.Load += new System.EventHandler(this.UCKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button butback;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}
