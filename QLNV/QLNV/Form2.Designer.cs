namespace QLNV
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThêm = new System.Windows.Forms.Button();
            this.btnSửa = new System.Windows.Forms.Button();
            this.btnXóa = new System.Windows.Forms.Button();
            this.qlnvDataSet1 = new QLNV.QLNVDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlnvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thôngTinProjectToolStripMenuItem
            // 
            this.thôngTinProjectToolStripMenuItem.Name = "thôngTinProjectToolStripMenuItem";
            this.thôngTinProjectToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.thôngTinProjectToolStripMenuItem.Text = "Thông tin Project";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýMónĂnToolStripMenuItem
            // 
            this.quảnLýMónĂnToolStripMenuItem.Name = "quảnLýMónĂnToolStripMenuItem";
            this.quảnLýMónĂnToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.quảnLýMónĂnToolStripMenuItem.Text = "Quản lý món ăn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýMónĂnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThêm
            // 
            this.btnThêm.Location = new System.Drawing.Point(43, 321);
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(75, 23);
            this.btnThêm.TabIndex = 9;
            this.btnThêm.Text = "Thêm";
            this.btnThêm.UseVisualStyleBackColor = true;
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // btnSửa
            // 
            this.btnSửa.Location = new System.Drawing.Point(249, 321);
            this.btnSửa.Name = "btnSửa";
            this.btnSửa.Size = new System.Drawing.Size(75, 23);
            this.btnSửa.TabIndex = 10;
            this.btnSửa.Text = "Sửa";
            this.btnSửa.UseVisualStyleBackColor = true;
            this.btnSửa.Click += new System.EventHandler(this.btnSửa_Click);
            // 
            // btnXóa
            // 
            this.btnXóa.Location = new System.Drawing.Point(484, 321);
            this.btnXóa.Name = "btnXóa";
            this.btnXóa.Size = new System.Drawing.Size(75, 23);
            this.btnXóa.TabIndex = 11;
            this.btnXóa.Text = "Xóa";
            this.btnXóa.UseVisualStyleBackColor = true;
            this.btnXóa.Click += new System.EventHandler(this.btnXóa_Click);
            // 
            // qlnvDataSet1
            // 
            this.qlnvDataSet1.DataSetName = "QLNVDataSet";
            this.qlnvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi,
            this.DienThoai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 251);
            this.dataGridView1.TabIndex = 12;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên nhân viên:";
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(219, 363);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(253, 24);
            this.cbTenNV.TabIndex = 14;
            // 
            // btnTracuu
            // 
            this.btnTracuu.Location = new System.Drawing.Point(546, 364);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(75, 23);
            this.btnTracuu.TabIndex = 15;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = true;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 407);
            this.Controls.Add(this.btnTracuu);
            this.Controls.Add(this.cbTenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXóa);
            this.Controls.Add(this.btnSửa);
            this.Controls.Add(this.btnThêm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlnvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMónĂnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnThêm;
        private System.Windows.Forms.Button btnSửa;
        private System.Windows.Forms.Button btnXóa;
        private QLNVDataSet qlnvDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.Button btnTracuu;
    }
}