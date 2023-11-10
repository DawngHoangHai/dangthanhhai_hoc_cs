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
    public partial class TinhLuyThua : Form
    {
        public TinhLuyThua()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            double a, tich = 1;
            a = double.Parse(txtN.Text);
            for (int i = 1; i <= a; i++)
            {
                tich *= i;
            }
            txtKQ.Text = tich.ToString();
        }

        private void btnNChia_Click(object sender, EventArgs e)
        {
            double a, tich = 1;
            a = double.Parse(txtN.Text);
            for (int i = 1; i <= a; i++)
            {
                tich *= i;
            }
            txtKQ.Text = 1.0 * tich / (a + 1) + "";

        }
    }
}
