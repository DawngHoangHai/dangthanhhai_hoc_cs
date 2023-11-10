namespace WinFormThayTan
{
    partial class TinhLuyThua
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
            txtN = new TextBox();
            txtKQ = new TextBox();
            btnN = new Button();
            btnNChia = new Button();
            btnThoat = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 98);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 0;
            label1.Text = "&N = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 163);
            label2.Name = "label2";
            label2.Size = new Size(105, 31);
            label2.TabIndex = 0;
            label2.Text = "&Kết Quả";
            // 
            // txtN
            // 
            txtN.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtN.Location = new Point(142, 98);
            txtN.Name = "txtN";
            txtN.Size = new Size(211, 39);
            txtN.TabIndex = 1;
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKQ.Location = new Point(142, 160);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(211, 39);
            txtKQ.TabIndex = 1;
            // 
            // btnN
            // 
            btnN.Cursor = Cursors.Hand;
            btnN.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnN.Location = new Point(47, 231);
            btnN.Name = "btnN";
            btnN.Size = new Size(278, 66);
            btnN.TabIndex = 2;
            btnN.Text = "Tính N!";
            btnN.UseVisualStyleBackColor = true;
            btnN.Click += btnN_Click;
            // 
            // btnNChia
            // 
            btnNChia.Cursor = Cursors.Hand;
            btnNChia.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNChia.Location = new Point(47, 321);
            btnNChia.Name = "btnNChia";
            btnNChia.Size = new Size(278, 66);
            btnNChia.TabIndex = 2;
            btnNChia.Text = "Tính N! /(N+1)";
            btnNChia.UseVisualStyleBackColor = true;
            btnNChia.Click += btnNChia_Click;
            // 
            // btnThoat
            // 
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(47, 408);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(278, 66);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(14, 20);
            label3.Name = "label3";
            label3.Size = new Size(339, 36);
            label3.TabIndex = 0;
            label3.Text = "&Tính Lũy Thừa Của Số ";
            // 
            // TinhLuyThua
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 499);
            Controls.Add(btnThoat);
            Controls.Add(btnNChia);
            Controls.Add(btnN);
            Controls.Add(txtKQ);
            Controls.Add(txtN);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "TinhLuyThua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinhLuyThua";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtN;
        private TextBox txtKQ;
        private Button btnN;
        private Button btnNChia;
        private Button btnThoat;
        private Label label3;
    }
}