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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btGiaiPT_Click(object sender, EventArgs e)
        {
            int a, b;
            a = (int)numberOne.Value;
            b = (int)numberTwo.Value;
            String hienThi = "";
            double ketQua;
            if (a == 0)
            {
                if (b == 0)
                {
                    hienThi = "Phương trình Vô Số Nghiệm";
                }
                else
                {
                    hienThi = "Phương trình Vô Nghiệm";
                }
            }
            else
            {
                ketQua = (double)-b / a;
                hienThi = "Nghiệm bằng = " + ketQua;
            }
            textBoxKetQua.Text = hienThi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numberOne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int a, b;
                a = (int)numberOne.Value;
                b = (int)numberTwo.Value;
                String hienThi = "";
                double ketQua;
                if (a == 0)
                {
                    if (b == 0)
                    {
                        hienThi = "Phương trình Vô Số Nghiệm";
                    }
                    else
                    {
                        hienThi = "Phương trình Vô Nghiệm";
                    }
                }
                else
                {
                    ketQua = (double)-b / a;
                    hienThi = "Nghiệm bằng = " + ketQua;
                }
                textBoxKetQua.Text = hienThi;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
