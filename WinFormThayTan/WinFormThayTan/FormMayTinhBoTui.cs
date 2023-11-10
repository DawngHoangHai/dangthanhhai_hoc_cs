using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormThayTan
{
    public partial class FormMayTinhBoTui : Form
    {
        double TH1 = 0;
        string TT = "";
        public FormMayTinhBoTui()
        {
            InitializeComponent();
        }
        private void Nhap(string s)
        {
            if (txtKetQua.Text.Trim() == "0")
                txtKetQua.Text = s;
            else
                txtKetQua.Text = txtKetQua.Text + s;
        }
        private void FormMayTinhBoTui_Load(object sender, EventArgs e)
        {

        }

        private void btPhay_Click(object sender, EventArgs e)
        {
            if (txtKetQua.Text.Trim() == "")
                txtKetQua.Text = "0.";
            else if (txtKetQua.Text.IndexOf(".") < 0)
                txtKetQua.Text = txtKetQua.Text + ".";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Nhap("1");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Nhap("2");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Nhap("3");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Nhap("4");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            Nhap("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            Nhap("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            Nhap("7");
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            Nhap("8");
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            Nhap("9");
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (txtKetQua.Text.Trim() != "0")
                txtKetQua.Text = txtKetQua.Text + "0";

        }
        private void NhapToanTu(string tt)
        {
            TT = tt;
            TH1 = double.Parse(txtKetQua.Text);
            txtKetQua.Text = "0";
        }
        private void btChia_Click(object sender, EventArgs e)
        {
            NhapToanTu("/");
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            NhapToanTu("+");
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            NhapToanTu("-");
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            NhapToanTu("*");
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            double TH2 = double.Parse(txtKetQua.Text);
            switch (TT)
            {
                case "+":
                    txtKetQua.Text = TH1 + TH2 + "";
                    break;
                case "-":
                    txtKetQua.Text = TH1 - TH2 + "";
                    break;
                case "*":
                    txtKetQua.Text = TH1 * TH2 + "";
                    break;
                case "/":
                    if (TH2 == 0)
                        MessageBox.Show("Lỗi chia 0");
                    else
                        txtKetQua.Text = TH1 / TH2 + "";
                    break;

            }
        }

        private void btReSest_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = string.Empty;
            TT = "";
        }
    }
}
