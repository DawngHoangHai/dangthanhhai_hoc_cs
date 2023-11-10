namespace WinFormThayTan
{
    partial class Bai19
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
            txtHienThi = new TextBox();
            btnCapNhap = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnSoNguyenTo = new Button();
            btnSapXepGiam = new Button();
            btnSxTang = new Button();
            btnSoChan = new Button();
            btnSoLe = new Button();
            btnBinhPhuong = new Button();
            btnTangThem2 = new Button();
            btnXoa = new Button();
            btnXoaDauCuoi = new Button();
            btnTongCacSo = new Button();
            groupBox2 = new GroupBox();
            listBoxArrays = new ListBox();
            btnKetThuc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập Vào Số";
            // 
            // txtHienThi
            // 
            txtHienThi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHienThi.Location = new Point(137, 48);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(219, 26);
            txtHienThi.TabIndex = 1;
            txtHienThi.KeyDown += txtHienThi_KeyDown;
            // 
            // btnCapNhap
            // 
            btnCapNhap.Cursor = Cursors.Hand;
            btnCapNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCapNhap.Location = new Point(392, 40);
            btnCapNhap.Name = "btnCapNhap";
            btnCapNhap.Size = new Size(148, 41);
            btnCapNhap.TabIndex = 2;
            btnCapNhap.Text = "Cập Nhập ";
            btnCapNhap.UseVisualStyleBackColor = true;
            btnCapNhap.Click += btnCapNhap_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnSoNguyenTo);
            groupBox1.Controls.Add(btnSapXepGiam);
            groupBox1.Controls.Add(btnSxTang);
            groupBox1.Controls.Add(btnSoChan);
            groupBox1.Controls.Add(btnSoLe);
            groupBox1.Controls.Add(btnBinhPhuong);
            groupBox1.Controls.Add(btnTangThem2);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnXoaDauCuoi);
            groupBox1.Controls.Add(btnTongCacSo);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(304, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 461);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các Chức Năng";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(8, 297);
            button2.Name = "button2";
            button2.Size = new Size(252, 33);
            button2.TabIndex = 2;
            button2.Text = "Chọn Số Chẵn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSoChan_Click;
            // 
            // btnSoNguyenTo
            // 
            btnSoNguyenTo.Cursor = Cursors.Hand;
            btnSoNguyenTo.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoNguyenTo.Location = new Point(8, 414);
            btnSoNguyenTo.Name = "btnSoNguyenTo";
            btnSoNguyenTo.Size = new Size(252, 33);
            btnSoNguyenTo.TabIndex = 2;
            btnSoNguyenTo.Text = "Tìm Số Nguyên Tố";
            btnSoNguyenTo.UseVisualStyleBackColor = true;
            btnSoNguyenTo.Click += btnTimSoNGuyenTo;
            // 
            // btnSapXepGiam
            // 
            btnSapXepGiam.Cursor = Cursors.Hand;
            btnSapXepGiam.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSapXepGiam.Location = new Point(8, 375);
            btnSapXepGiam.Name = "btnSapXepGiam";
            btnSapXepGiam.Size = new Size(252, 33);
            btnSapXepGiam.TabIndex = 2;
            btnSapXepGiam.Text = "Sắp Xếp Giảm Dần";
            btnSapXepGiam.UseVisualStyleBackColor = true;
            btnSapXepGiam.Click += btnSapXepGiamDan_Click;
            // 
            // btnSxTang
            // 
            btnSxTang.Cursor = Cursors.Hand;
            btnSxTang.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSxTang.Location = new Point(8, 336);
            btnSxTang.Name = "btnSxTang";
            btnSxTang.Size = new Size(252, 33);
            btnSxTang.TabIndex = 2;
            btnSxTang.Text = "Sắp Xếp tăng Dần";
            btnSxTang.UseVisualStyleBackColor = true;
            btnSxTang.Click += btnSapXepTangDan_Click;
            // 
            // btnSoChan
            // 
            btnSoChan.Cursor = Cursors.Hand;
            btnSoChan.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoChan.Location = new Point(6, 258);
            btnSoChan.Name = "btnSoChan";
            btnSoChan.Size = new Size(252, 33);
            btnSoChan.TabIndex = 2;
            btnSoChan.Text = "Chọn Số Chẵn";
            btnSoChan.UseVisualStyleBackColor = true;
            btnSoChan.Click += btnSoChan_Click;
            // 
            // btnSoLe
            // 
            btnSoLe.Cursor = Cursors.Hand;
            btnSoLe.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoLe.Location = new Point(6, 219);
            btnSoLe.Name = "btnSoLe";
            btnSoLe.Size = new Size(252, 33);
            btnSoLe.TabIndex = 2;
            btnSoLe.Text = "Chọn Số Lẻ";
            btnSoLe.UseVisualStyleBackColor = true;
            btnSoLe.Click += btnSoLe_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Cursor = Cursors.Hand;
            btnBinhPhuong.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBinhPhuong.Location = new Point(6, 180);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(252, 33);
            btnBinhPhuong.TabIndex = 2;
            btnBinhPhuong.Text = "Nhân Đôi Lên";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnTangThem2
            // 
            btnTangThem2.Cursor = Cursors.Hand;
            btnTangThem2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTangThem2.Location = new Point(6, 141);
            btnTangThem2.Name = "btnTangThem2";
            btnTangThem2.Size = new Size(252, 33);
            btnTangThem2.TabIndex = 2;
            btnTangThem2.Text = "Tăng Thêm 2";
            btnTangThem2.UseVisualStyleBackColor = true;
            btnTangThem2.Click += btnTangThem2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(6, 102);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(252, 33);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa Phần Tử Đã Chọn";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Cursor = Cursors.Hand;
            btnXoaDauCuoi.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaDauCuoi.Location = new Point(6, 63);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(252, 33);
            btnXoaDauCuoi.TabIndex = 2;
            btnXoaDauCuoi.Text = "Xóa Phần Tử Đầu Cuối";
            btnXoaDauCuoi.UseVisualStyleBackColor = true;
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            // 
            // btnTongCacSo
            // 
            btnTongCacSo.Cursor = Cursors.Hand;
            btnTongCacSo.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTongCacSo.Location = new Point(6, 24);
            btnTongCacSo.Name = "btnTongCacSo";
            btnTongCacSo.Size = new Size(252, 33);
            btnTongCacSo.TabIndex = 2;
            btnTongCacSo.Text = "Tổng Các Số ";
            btnTongCacSo.UseVisualStyleBackColor = true;
            btnTongCacSo.Click += btnTongCacSo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxArrays);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 461);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "lớp A";
            // 
            // listBoxArrays
            // 
            listBoxArrays.Dock = DockStyle.Fill;
            listBoxArrays.FormattingEnabled = true;
            listBoxArrays.ItemHeight = 17;
            listBoxArrays.Location = new Point(3, 21);
            listBoxArrays.Name = "listBoxArrays";
            listBoxArrays.SelectionMode = SelectionMode.MultiSimple;
            listBoxArrays.Size = new Size(259, 437);
            listBoxArrays.TabIndex = 0;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Cursor = Cursors.Hand;
            btnKetThuc.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKetThuc.Location = new Point(126, 575);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(317, 56);
            btnKetThuc.TabIndex = 2;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Bai19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 643);
            Controls.Add(btnKetThuc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCapNhap);
            Controls.Add(txtHienThi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai19";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai19";
            Load += Bai19_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHienThi;
        private Button btnCapNhap;
        private GroupBox groupBox1;
        private Button btnSoChan;
        private Button btnSoLe;
        private Button btnBinhPhuong;
        private Button btnTangThem2;
        private Button btnXoa;
        private Button btnXoaDauCuoi;
        private Button btnTongCacSo;
        private GroupBox groupBox2;
        private ListBox listBoxArrays;
        private Button btnKetThuc;
        private Button button2;
        private Button btnSxTang;
        private Button btnSapXepGiam;
        private Button btnSoNguyenTo;
    }
}