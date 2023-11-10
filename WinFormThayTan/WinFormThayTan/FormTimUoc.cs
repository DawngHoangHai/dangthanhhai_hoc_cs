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
    public partial class FormTimUoc : Form
    {
        public FormTimUoc()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int n;
            string ketqua ="";
            n = int.Parse(txtNhap.Text);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    ketqua = ketqua +"  "+i;
                }
            }
            lbhienThi.Text = ketqua;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
