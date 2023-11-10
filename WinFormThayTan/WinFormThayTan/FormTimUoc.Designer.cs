namespace WinFormThayTan
{
    partial class FormTimUoc
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
            txtNhap = new TextBox();
            groupBox1 = new GroupBox();
            lbhienThi = new Label();
            btTinh = new Button();
            btexit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 26);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập số cần tìm ước chung ";
            // 
            // txtNhap
            // 
            txtNhap.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhap.Location = new Point(79, 70);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(248, 33);
            txtNhap.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbhienThi);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 184);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "&Kết Quả";
            // 
            // lbhienThi
            // 
            lbhienThi.BackColor = Color.White;
            lbhienThi.Location = new Point(16, 35);
            lbhienThi.Name = "lbhienThi";
            lbhienThi.Size = new Size(334, 130);
            lbhienThi.TabIndex = 0;
            // 
            // btTinh
            // 
            btTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btTinh.Location = new Point(44, 362);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(99, 61);
            btTinh.TabIndex = 3;
            btTinh.Text = "Thực Hiện ";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // btexit
            // 
            btexit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btexit.Location = new Point(263, 362);
            btexit.Name = "btexit";
            btexit.Size = new Size(99, 61);
            btexit.TabIndex = 3;
            btexit.Text = "Thoát";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // FormTimUoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(396, 450);
            Controls.Add(btexit);
            Controls.Add(btTinh);
            Controls.Add(groupBox1);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormTimUoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTimUoc";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbhienThi;
        private System.Windows.Forms.NumericUpDown numericUpDownOne;
        private System.Windows.Forms.NumericUpDown numericUpDownTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKQ;
        private TextBox txtNhap;
        private GroupBox groupBox1;
        private Button btTinh;
        private Button btexit;
    }
}