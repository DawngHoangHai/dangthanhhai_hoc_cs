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
    public partial class FormMauChu : Form
    {
        public FormMauChu()
        {
            InitializeComponent();
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRed.Checked)
            {
                lbHienThi.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbHienThi.Text = txtYourName.Text + " " + txtMessage.Text;
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlue.Checked)
            {
                lbHienThi.ForeColor = Color.Blue;
            }
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGreen.Checked)
            {
                lbHienThi.ForeColor = Color.Green;
            }
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBlack.Checked)
            {
                lbHienThi.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMauChu_Load(object sender, EventArgs e)
        {
            rdBlack.Checked = true;

        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBold.Checked)
                lbHienThi.Font =
                    new Font(lbHienThi.Font, lbHienThi.Font.Style | FontStyle.Bold);
            else
                lbHienThi.Font =
                    new Font(lbHienThi.Font, lbHienThi.Font.Style & ~FontStyle.Bold);
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbItalic.Checked)
                lbHienThi.Font =
                    new Font(lbHienThi.Font, lbHienThi.Font.Style | FontStyle.Italic);
            else
                lbHienThi.Font =
                    new Font(lbHienThi.Font, lbHienThi.Font.Style & ~FontStyle.Italic);
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnderline.Checked)
                lbHienThi.Font =
                    new Font(lbHienThi.Font, lbHienThi.Font.Style | FontStyle.Underline);
            else
                lbHienThi.Font =
                    new Font(lbHienThi.Font, lbHienThi.Font.Style & ~FontStyle.Underline);
        }
    }
}
