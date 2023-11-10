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
    public partial class FormPTBac2 : Form
    {
        public FormPTBac2()
        {
            InitializeComponent();
        }
        private void FormPTBac2_Load(object sender, EventArgs e)
        {
            textBoxA.Focus();
        }

        private void buttonGiai_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBoxA.Text);
            b = int.Parse(textBoxB.Text);
            c = int.Parse(textBoxC.Text);
            double delTa = 0.0, x1, x2, X;
            String hienThi = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        hienThi = "Phương Trình Vô Số Nghiệm !!";
                        lbNghiemMot.Text = hienThi;
                        lbNghiemHai.Text = hienThi;
                    }
                    else
                    {
                        hienThi = "Phương trình Vô Nghiệm !!";
                        lbNghiemMot.Text = hienThi;
                        lbNghiemHai.Text = hienThi;
                    }
                }
                else
                {
                    X = (double)-c / b;
                    hienThi = " 1 nghiệm duy nhất là  : " + X;
                    lbNghiemMot.Text = hienThi;
                    lbNghiemHai.Text = hienThi;
                }
            }
            else
            {
                delTa = b * b - 4 * (a * c);
                if (delTa > 0.0)
                {
                    x1 = (float)(-b + Math.Sqrt(delTa)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(delTa)) / (2 * a);
                    hienThi = $"X1 = {x1} & X2 = {x2}";
                    lbNghiemMot.Text = x1.ToString();
                    lbNghiemHai.Text = x2.ToString();
                }
                else if (delTa == 0)
                {
                    hienThi = " 2 Nghiệm kép là " + (float)-b / (2 * a);
                    lbNghiemMot.Text = hienThi;
                    lbNghiemHai.Text = hienThi;
                }
                else
                {
                    hienThi = "Phương Trình Vô Nghiệm !!!! ";
                    lbNghiemMot.Text = hienThi;
                    lbNghiemHai.Text = hienThi;
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxA.Select();
        }
    }
}
