namespace QuanLyNongSan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNhapNS = new System.Windows.Forms.Button();
            this.buttonXuatNS = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonLSThanhToan = new System.Windows.Forms.Button();
            this.buttonQLKhachHang = new System.Windows.Forms.Button();
            this.buttonQLNongSan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.buttonQLNongSan);
            this.panel1.Controls.Add(this.buttonQLKhachHang);
            this.panel1.Controls.Add(this.buttonLSThanhToan);
            this.panel1.Controls.Add(this.buttonCapNhat);
            this.panel1.Controls.Add(this.buttonXuatNS);
            this.panel1.Controls.Add(this.buttonNhapNS);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 419);
            this.panel1.TabIndex = 0;
            // 
            // buttonNhapNS
            // 
            this.buttonNhapNS.Location = new System.Drawing.Point(57, 121);
            this.buttonNhapNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNhapNS.Name = "buttonNhapNS";
            this.buttonNhapNS.Size = new System.Drawing.Size(313, 51);
            this.buttonNhapNS.TabIndex = 1;
            this.buttonNhapNS.Text = "Nhập Nông Sản";
            this.buttonNhapNS.UseVisualStyleBackColor = true;
            // 
            // buttonXuatNS
            // 
            this.buttonXuatNS.Location = new System.Drawing.Point(57, 196);
            this.buttonXuatNS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatNS.Name = "buttonXuatNS";
            this.buttonXuatNS.Size = new System.Drawing.Size(313, 51);
            this.buttonXuatNS.TabIndex = 2;
            this.buttonXuatNS.Text = "Bán Nông Sản";
            this.buttonXuatNS.UseVisualStyleBackColor = true;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(396, 196);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(313, 51);
            this.buttonCapNhat.TabIndex = 4;
            this.buttonCapNhat.Text = "Cập nhật - Sao lưu Dữ liệu";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            // 
            // buttonLSThanhToan
            // 
            this.buttonLSThanhToan.Location = new System.Drawing.Point(396, 272);
            this.buttonLSThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLSThanhToan.Name = "buttonLSThanhToan";
            this.buttonLSThanhToan.Size = new System.Drawing.Size(313, 51);
            this.buttonLSThanhToan.TabIndex = 5;
            this.buttonLSThanhToan.Text = "Lịch sử Thanh toán";
            this.buttonLSThanhToan.UseVisualStyleBackColor = true;
            this.buttonLSThanhToan.Click += new System.EventHandler(this.buttonLSThanhToan_Click);
            // 
            // buttonQLKhachHang
            // 
            this.buttonQLKhachHang.Location = new System.Drawing.Point(396, 121);
            this.buttonQLKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQLKhachHang.Name = "buttonQLKhachHang";
            this.buttonQLKhachHang.Size = new System.Drawing.Size(313, 51);
            this.buttonQLKhachHang.TabIndex = 6;
            this.buttonQLKhachHang.Text = "Quản lý khách hàng";
            this.buttonQLKhachHang.UseVisualStyleBackColor = true;
            // 
            // buttonQLNongSan
            // 
            this.buttonQLNongSan.Location = new System.Drawing.Point(57, 272);
            this.buttonQLNongSan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQLNongSan.Name = "buttonQLNongSan";
            this.buttonQLNongSan.Size = new System.Drawing.Size(313, 51);
            this.buttonQLNongSan.TabIndex = 7;
            this.buttonQLNongSan.Text = "Quản lý nông sản";
            this.buttonQLNongSan.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 412);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Menu Chính ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQLKhachHang;
        private System.Windows.Forms.Button buttonLSThanhToan;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonXuatNS;
        private System.Windows.Forms.Button buttonNhapNS;
        private System.Windows.Forms.Button buttonQLNongSan;
    }
}