namespace Quản_lý_bán_hàng
{
    partial class FormMain
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
            this.btnQuanlysanpham = new System.Windows.Forms.Button();
            this.btnQuanlyhoadon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuanlysanpham
            // 
            this.btnQuanlysanpham.Location = new System.Drawing.Point(32, 72);
            this.btnQuanlysanpham.Name = "btnQuanlysanpham";
            this.btnQuanlysanpham.Size = new System.Drawing.Size(173, 61);
            this.btnQuanlysanpham.TabIndex = 0;
            this.btnQuanlysanpham.Text = "Quản lý sản phẩm";
            this.btnQuanlysanpham.UseVisualStyleBackColor = true;
            this.btnQuanlysanpham.Click += new System.EventHandler(this.btnQuanlysanpham_Click);
            // 
            // btnQuanlyhoadon
            // 
            this.btnQuanlyhoadon.Location = new System.Drawing.Point(32, 170);
            this.btnQuanlyhoadon.Name = "btnQuanlyhoadon";
            this.btnQuanlyhoadon.Size = new System.Drawing.Size(173, 60);
            this.btnQuanlyhoadon.TabIndex = 1;
            this.btnQuanlyhoadon.Text = "Quản lý hóa đơn";
            this.btnQuanlyhoadon.UseVisualStyleBackColor = true;
            this.btnQuanlyhoadon.Click += new System.EventHandler(this.btnQuanlyhoadon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "GIAO DIỆN CHÍNH";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuanlyhoadon);
            this.Controls.Add(this.btnQuanlysanpham);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuanlysanpham;
        private System.Windows.Forms.Button btnQuanlyhoadon;
        private System.Windows.Forms.Label label1;
    }
}