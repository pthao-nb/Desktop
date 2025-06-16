namespace QUANLYXE
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboBienso = new System.Windows.Forms.ComboBox();
            this.dgvLichSuBaoDuong = new System.Windows.Forms.DataGridView();
            this.cboMagoi = new System.Windows.Forms.ComboBox();
            this.txtSokm = new System.Windows.Forms.TextBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.btnThemchitiet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.cboThoigian = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuBaoDuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số";
            // 
            // cboBienso
            // 
            this.cboBienso.FormattingEnabled = true;
            this.cboBienso.Location = new System.Drawing.Point(120, 17);
            this.cboBienso.Name = "cboBienso";
            this.cboBienso.Size = new System.Drawing.Size(350, 24);
            this.cboBienso.TabIndex = 1;
            this.cboBienso.SelectedIndexChanged += new System.EventHandler(this.cboBienso_SelectedIndexChanged);
            // 
            // dgvLichSuBaoDuong
            // 
            this.dgvLichSuBaoDuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuBaoDuong.Location = new System.Drawing.Point(12, 79);
            this.dgvLichSuBaoDuong.Name = "dgvLichSuBaoDuong";
            this.dgvLichSuBaoDuong.RowHeadersWidth = 51;
            this.dgvLichSuBaoDuong.RowTemplate.Height = 24;
            this.dgvLichSuBaoDuong.Size = new System.Drawing.Size(730, 150);
            this.dgvLichSuBaoDuong.TabIndex = 2;
            this.dgvLichSuBaoDuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuBaoDuong_CellContentClick);
            // 
            // cboMagoi
            // 
            this.cboMagoi.FormattingEnabled = true;
            this.cboMagoi.Location = new System.Drawing.Point(120, 279);
            this.cboMagoi.Name = "cboMagoi";
            this.cboMagoi.Size = new System.Drawing.Size(326, 24);
            this.cboMagoi.TabIndex = 4;
            // 
            // txtSokm
            // 
            this.txtSokm.Location = new System.Drawing.Point(120, 334);
            this.txtSokm.Name = "txtSokm";
            this.txtSokm.Size = new System.Drawing.Size(243, 22);
            this.txtSokm.TabIndex = 5;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Location = new System.Drawing.Point(120, 392);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(243, 22);
            this.txtGiatien.TabIndex = 6;
            // 
            // btnThemchitiet
            // 
            this.btnThemchitiet.Location = new System.Drawing.Point(356, 492);
            this.btnThemchitiet.Name = "btnThemchitiet";
            this.btnThemchitiet.Size = new System.Drawing.Size(114, 23);
            this.btnThemchitiet.TabIndex = 7;
            this.btnThemchitiet.Text = "Thêm chi tiết";
            this.btnThemchitiet.UseVisualStyleBackColor = true;
            this.btnThemchitiet.Click += new System.EventHandler(this.btnThemchitiet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã gói";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thời gian";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(24, 492);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(66, 16);
            this.lblTongtien.TabIndex = 13;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // cboThoigian
            // 
            this.cboThoigian.FormattingEnabled = true;
            this.cboThoigian.Location = new System.Drawing.Point(120, 440);
            this.cboThoigian.Name = "cboThoigian";
            this.cboThoigian.Size = new System.Drawing.Size(243, 24);
            this.cboThoigian.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 543);
            this.Controls.Add(this.cboThoigian);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemchitiet);
            this.Controls.Add(this.txtGiatien);
            this.Controls.Add(this.txtSokm);
            this.Controls.Add(this.cboMagoi);
            this.Controls.Add(this.dgvLichSuBaoDuong);
            this.Controls.Add(this.cboBienso);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuBaoDuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBienso;
        private System.Windows.Forms.DataGridView dgvLichSuBaoDuong;
        private System.Windows.Forms.ComboBox cboMagoi;
        private System.Windows.Forms.TextBox txtSokm;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.Button btnThemchitiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.ComboBox cboThoigian;
    }
}