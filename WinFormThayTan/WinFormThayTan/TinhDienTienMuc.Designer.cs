namespace WinFormThayTan
{
    partial class TinhDienTienMuc
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
            label1 = new Label();
            label2 = new Label();
            txtKH = new TextBox();
            label3 = new Label();
            nUDDinhMuc = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtSoCu = new TextBox();
            txtSoMoi = new TextBox();
            txtgia1 = new TextBox();
            txtGia2 = new TextBox();
            txtTongTien = new TextBox();
            btThoat = new Button();
            btTinhDien = new Button();
            ((System.ComponentModel.ISupportInitialize)nUDDinhMuc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(515, 48);
            label1.TabIndex = 0;
            label1.Text = "Tính Điện Mức Tiêu Thụ ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "&Khách hàng";
            // 
            // txtKH
            // 
            txtKH.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtKH.Location = new Point(166, 69);
            txtKH.Name = "txtKH";
            txtKH.Size = new Size(340, 33);
            txtKH.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 1;
            label3.Text = "&Định mức ";
            // 
            // nUDDinhMuc
            // 
            nUDDinhMuc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nUDDinhMuc.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nUDDinhMuc.Location = new Point(166, 137);
            nUDDinhMuc.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUDDinhMuc.Name = "nUDDinhMuc";
            nUDDinhMuc.ReadOnly = true;
            nUDDinhMuc.Size = new Size(340, 33);
            nUDDinhMuc.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 1;
            label4.Text = "&Số Cũ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 381);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 1;
            label5.Text = "&Tổng Tiền ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 246);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 1;
            label8.Text = "&Số Mới";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 291);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 1;
            label9.Text = "&Giá 1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 342);
            label10.Name = "label10";
            label10.Size = new Size(57, 25);
            label10.TabIndex = 1;
            label10.Text = "&Giá 2";
            // 
            // txtSoCu
            // 
            txtSoCu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoCu.Location = new Point(166, 194);
            txtSoCu.Name = "txtSoCu";
            txtSoCu.Size = new Size(340, 33);
            txtSoCu.TabIndex = 2;
            // 
            // txtSoMoi
            // 
            txtSoMoi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoMoi.Location = new Point(166, 243);
            txtSoMoi.Name = "txtSoMoi";
            txtSoMoi.Size = new Size(340, 33);
            txtSoMoi.TabIndex = 2;
            // 
            // txtgia1
            // 
            txtgia1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtgia1.Location = new Point(166, 288);
            txtgia1.Name = "txtgia1";
            txtgia1.Size = new Size(340, 33);
            txtgia1.TabIndex = 2;
            // 
            // txtGia2
            // 
            txtGia2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtGia2.Location = new Point(166, 334);
            txtGia2.Name = "txtGia2";
            txtGia2.Size = new Size(340, 33);
            txtGia2.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.Location = new Point(166, 378);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(340, 33);
            txtTongTien.TabIndex = 2;
            // 
            // btThoat
            // 
            btThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btThoat.Location = new Point(299, 436);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(100, 51);
            btThoat.TabIndex = 4;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            // 
            // btTinhDien
            // 
            btTinhDien.FlatAppearance.BorderSize = 10;
            btTinhDien.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btTinhDien.Location = new Point(95, 436);
            btTinhDien.Name = "btTinhDien";
            btTinhDien.Size = new Size(100, 51);
            btTinhDien.TabIndex = 5;
            btTinhDien.Text = "Tính Điện";
            btTinhDien.UseVisualStyleBackColor = true;
            // 
            // TinhDienTienMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 499);
            Controls.Add(btThoat);
            Controls.Add(btTinhDien);
            Controls.Add(nUDDinhMuc);
            Controls.Add(txtTongTien);
            Controls.Add(txtGia2);
            Controls.Add(txtgia1);
            Controls.Add(txtSoMoi);
            Controls.Add(txtSoCu);
            Controls.Add(txtKH);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TinhDienTienMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinhDienTienMuc";
            ((System.ComponentModel.ISupportInitialize)nUDDinhMuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKH;
        private Label label3;
        private NumericUpDown nUDDinhMuc;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtSoCu;
        private TextBox txtSoMoi;
        private TextBox txtgia1;
        private TextBox txtGia2;
        private TextBox txtTongTien;
        private Button btThoat;
        private Button btTinhDien;
    }
}