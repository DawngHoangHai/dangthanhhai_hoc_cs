namespace WinFormThayTan
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
            label1 = new Label();
            label2 = new Label();
            textBoxKetQua = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btGiaiPT = new Button();
            button2 = new Button();
            button3 = new Button();
            numberOne = new NumericUpDown();
            numberTwo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numberOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberTwo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 20);
            label1.Name = "label1";
            label1.Size = new Size(316, 32);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương trình Bậc 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 260);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 1;
            label2.Text = "Kết Quả  =";
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKetQua.Location = new Point(216, 257);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(180, 25);
            textBoxKetQua.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 114);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            label3.Text = "Hệ Số A = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 188);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 1;
            label4.Text = "Hệ Số B = ";
            // 
            // btGiaiPT
            // 
            btGiaiPT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btGiaiPT.Location = new Point(40, 353);
            btGiaiPT.Name = "btGiaiPT";
            btGiaiPT.Size = new Size(100, 51);
            btGiaiPT.TabIndex = 3;
            btGiaiPT.Text = "Giải PT";
            btGiaiPT.UseVisualStyleBackColor = true;
            btGiaiPT.Click += btGiaiPT_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(177, 353);
            button2.Name = "button2";
            button2.Size = new Size(100, 51);
            button2.TabIndex = 3;
            button2.Text = "Giải Lại";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(321, 353);
            button3.Name = "button3";
            button3.Size = new Size(100, 51);
            button3.TabIndex = 3;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numberOne
            // 
            numberOne.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            numberOne.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numberOne.Location = new Point(216, 108);
            numberOne.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numberOne.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            numberOne.Name = "numberOne";
            numberOne.Size = new Size(176, 32);
            numberOne.TabIndex = 4;
            numberOne.KeyDown += numberOne_KeyDown;
            // 
            // numberTwo
            // 
            numberTwo.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            numberTwo.Location = new Point(216, 179);
            numberTwo.Name = "numberTwo";
            numberTwo.Size = new Size(176, 32);
            numberTwo.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 435);
            Controls.Add(numberTwo);
            Controls.Add(numberOne);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btGiaiPT);
            Controls.Add(textBoxKetQua);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numberOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberTwo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxKetQua;
        private Label label3;
        private Label label4;
        private Button btGiaiPT;
        private Button button2;
        private Button button3;
        private NumericUpDown numberOne;
        private NumericUpDown numberTwo;
    }
}