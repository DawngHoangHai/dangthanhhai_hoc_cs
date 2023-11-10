namespace WinFormThayTan
{
    partial class FormPTBac2
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
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            lbNghiemMot = new Label();
            lbNghiemHai = new Label();
            buttonGiai = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 31);
            label1.Name = "label1";
            label1.Size = new Size(316, 32);
            label1.TabIndex = 1;
            label1.Text = "Giải Phương trình Bậc 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 121);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Hệ Số A = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 186);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 3;
            label4.Text = "Hệ Số B = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 251);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 3;
            label2.Text = "Hệ Số C = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 371);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 3;
            label5.Text = "Nghiệm X2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(43, 312);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 3;
            label6.Text = "Nghiệm X1";
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxA.Location = new Point(193, 120);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(214, 29);
            textBoxA.TabIndex = 4;
            textBoxA.KeyDown += textBoxA_KeyDown;
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxB.Location = new Point(193, 180);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(214, 29);
            textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            textBoxC.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxC.Location = new Point(193, 245);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(214, 29);
            textBoxC.TabIndex = 4;
            // 
            // lbNghiemMot
            // 
            lbNghiemMot.BackColor = Color.White;
            lbNghiemMot.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNghiemMot.Location = new Point(193, 312);
            lbNghiemMot.Name = "lbNghiemMot";
            lbNghiemMot.Size = new Size(214, 33);
            lbNghiemMot.TabIndex = 5;
            // 
            // lbNghiemHai
            // 
            lbNghiemHai.BackColor = Color.White;
            lbNghiemHai.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNghiemHai.Location = new Point(193, 371);
            lbNghiemHai.Name = "lbNghiemHai";
            lbNghiemHai.Size = new Size(214, 33);
            lbNghiemHai.TabIndex = 6;
            // 
            // buttonGiai
            // 
            buttonGiai.Cursor = Cursors.Hand;
            buttonGiai.Location = new Point(41, 436);
            buttonGiai.Name = "buttonGiai";
            buttonGiai.Size = new Size(126, 42);
            buttonGiai.TabIndex = 7;
            buttonGiai.Text = "Giải PT";
            buttonGiai.UseVisualStyleBackColor = true;
            buttonGiai.Click += buttonGiai_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Cursor = Cursors.Hand;
            buttonThoat.Location = new Point(281, 436);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(126, 42);
            buttonThoat.TabIndex = 7;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // FormPTBac2
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 490);
            Controls.Add(buttonThoat);
            Controls.Add(buttonGiai);
            Controls.Add(lbNghiemHai);
            Controls.Add(lbNghiemMot);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPTBac2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPTBac2";
            Load += FormPTBac2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label lbNghiemMot;
        private Label lbNghiemHai;
        private Button buttonGiai;
        private Button buttonThoat;
    }
}