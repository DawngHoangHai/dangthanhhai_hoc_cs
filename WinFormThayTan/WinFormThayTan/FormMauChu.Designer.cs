namespace WinFormThayTan
{
    partial class FormMauChu
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
            groupBox1 = new GroupBox();
            txtMessage = new TextBox();
            txtYourName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdBlack = new RadioButton();
            rdGreen = new RadioButton();
            rdBlue = new RadioButton();
            rdRed = new RadioButton();
            groupBox3 = new GroupBox();
            cbUnderline = new CheckBox();
            cbItalic = new CheckBox();
            cbBold = new CheckBox();
            lbHienThi = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(txtYourName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(198, 81);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(257, 32);
            txtMessage.TabIndex = 1;
            // 
            // txtYourName
            // 
            txtYourName.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtYourName.Location = new Point(198, 26);
            txtYourName.Name = "txtYourName";
            txtYourName.Size = new Size(257, 32);
            txtYourName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 82);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 0;
            label2.Text = "&Messgage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            label1.Text = "&YourName";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(rdBlack);
            groupBox2.Controls.Add(rdGreen);
            groupBox2.Controls.Add(rdBlue);
            groupBox2.Controls.Add(rdRed);
            groupBox2.Location = new Point(12, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 214);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "&Color";
            // 
            // rdBlack
            // 
            rdBlack.AutoSize = true;
            rdBlack.Location = new Point(49, 168);
            rdBlack.Name = "rdBlack";
            rdBlack.Size = new Size(70, 25);
            rdBlack.TabIndex = 0;
            rdBlack.TabStop = true;
            rdBlack.Text = "&Black";
            rdBlack.UseVisualStyleBackColor = true;
            rdBlack.CheckedChanged += rdBlack_CheckedChanged;
            // 
            // rdGreen
            // 
            rdGreen.AutoSize = true;
            rdGreen.ForeColor = Color.Lime;
            rdGreen.Location = new Point(49, 125);
            rdGreen.Name = "rdGreen";
            rdGreen.Size = new Size(73, 25);
            rdGreen.TabIndex = 0;
            rdGreen.TabStop = true;
            rdGreen.Text = "&Green";
            rdGreen.UseVisualStyleBackColor = true;
            rdGreen.CheckedChanged += rdGreen_CheckedChanged;
            // 
            // rdBlue
            // 
            rdBlue.AutoSize = true;
            rdBlue.ForeColor = Color.Blue;
            rdBlue.Location = new Point(49, 81);
            rdBlue.Name = "rdBlue";
            rdBlue.Size = new Size(61, 25);
            rdBlue.TabIndex = 0;
            rdBlue.TabStop = true;
            rdBlue.Text = "&Blue";
            rdBlue.UseVisualStyleBackColor = true;
            rdBlue.CheckedChanged += rdBlue_CheckedChanged;
            // 
            // rdRed
            // 
            rdRed.AutoSize = true;
            rdRed.ForeColor = Color.Red;
            rdRed.Location = new Point(49, 40);
            rdRed.Name = "rdRed";
            rdRed.Size = new Size(59, 25);
            rdRed.TabIndex = 0;
            rdRed.TabStop = true;
            rdRed.Text = "&Red";
            rdRed.UseVisualStyleBackColor = true;
            rdRed.CheckedChanged += rdRed_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gainsboro;
            groupBox3.Controls.Add(cbUnderline);
            groupBox3.Controls.Add(cbItalic);
            groupBox3.Controls.Add(cbBold);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(262, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(229, 214);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "&Style";
            // 
            // cbUnderline
            // 
            cbUnderline.AutoSize = true;
            cbUnderline.Font = new Font("Times New Roman", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            cbUnderline.Location = new Point(52, 140);
            cbUnderline.Name = "cbUnderline";
            cbUnderline.Size = new Size(100, 25);
            cbUnderline.TabIndex = 0;
            cbUnderline.Text = "Underline";
            cbUnderline.UseVisualStyleBackColor = true;
            cbUnderline.CheckedChanged += cbUnderline_CheckedChanged;
            // 
            // cbItalic
            // 
            cbItalic.AutoSize = true;
            cbItalic.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            cbItalic.Location = new Point(52, 94);
            cbItalic.Name = "cbItalic";
            cbItalic.Size = new Size(73, 25);
            cbItalic.TabIndex = 0;
            cbItalic.Text = "&Itanic";
            cbItalic.UseVisualStyleBackColor = true;
            cbItalic.CheckedChanged += cbItalic_CheckedChanged;
            // 
            // cbBold
            // 
            cbBold.AutoSize = true;
            cbBold.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbBold.Location = new Point(52, 46);
            cbBold.Name = "cbBold";
            cbBold.Size = new Size(67, 26);
            cbBold.TabIndex = 0;
            cbBold.Text = "Blod";
            cbBold.UseVisualStyleBackColor = true;
            cbBold.CheckedChanged += cbBold_CheckedChanged;
            // 
            // lbHienThi
            // 
            lbHienThi.BorderStyle = BorderStyle.FixedSingle;
            lbHienThi.Location = new Point(12, 401);
            lbHienThi.Name = "lbHienThi";
            lbHienThi.Size = new Size(281, 111);
            lbHienThi.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(365, 401);
            button1.Name = "button1";
            button1.Size = new Size(80, 42);
            button1.TabIndex = 2;
            button1.Text = "&Đisplay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(365, 467);
            button2.Name = "button2";
            button2.Size = new Size(80, 42);
            button2.TabIndex = 2;
            button2.Text = "&Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormMauChu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 521);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbHienThi);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormMauChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMauChu";
            Load += FormMauChu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtMessage;
        private TextBox txtYourName;
        private Label label2;
        private Label label1;
        private RadioButton rdBlack;
        private RadioButton rdGreen;
        private RadioButton rdBlue;
        private RadioButton rdRed;
        private CheckBox cbUnderline;
        private CheckBox cbItalic;
        private CheckBox cbBold;
        private Label lbHienThi;
        private Button button1;
        private Button button2;
    }
}