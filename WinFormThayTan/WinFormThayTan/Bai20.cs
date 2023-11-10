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
    public partial class Bai20 : Form
    {
        public Bai20()
        {
            InitializeComponent();
        }
        private void NhapChu(string nhom)
        {
            if (nhom == "Nhóm 1")
            {
                listBoxNhom1.Items.Add(txtNhapSv.Text.Trim());
                txtNhapSv.Clear();
                lbTong1.Text = "Tổng Số : " + listBoxNhom1.Items.Count;
            }
            else if (nhom == "Nhóm 2")
            {
                listBoxNhom2.Items.Add(txtNhapSv.Text.Trim());
                txtNhapSv.Clear();
                lbTong2.Text = "Tổng Số : " + listBoxNhom2.Items.Count;
            }
        }
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            NhapChu(cbxChonNhom.Text);
        }

        private void Bai20_Load(object sender, EventArgs e)
        {
            cbxChonNhom.SelectedIndex = 0;
        }

        private void txtNhapSv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NhapChu(cbxChonNhom.Text);
            }
        }

        private void btnTraiSPhai_Click(object sender, EventArgs e)
        {
            if (listBoxNhom1.SelectedItem != null)
            {
                listBoxNhom2.Items.Add(listBoxNhom1.SelectedItem);
                listBoxNhom1.Items.Remove(listBoxNhom1.SelectedItem);
                lbTong1.Text = "Tổng Số : " + listBoxNhom1.Items.Count;
                lbTong2.Text = "Tổng Số : " + listBoxNhom2.Items.Count;
            }
        }

        private void btnPhaiSTrai_Click(object sender, EventArgs e)
        {
            if (listBoxNhom2.SelectedItem != null)
            {
                listBoxNhom1.Items.Add(listBoxNhom2.SelectedItem);
                listBoxNhom2.Items.Remove(listBoxNhom2.SelectedItem);
                lbTong1.Text = "Tổng Số : " + listBoxNhom1.Items.Count;
                lbTong2.Text = "Tổng Số : " + listBoxNhom2.Items.Count;
            }
        }

        private void btnTraiSPhaiS_Click(object sender, EventArgs e)
        {
            while (listBoxNhom1.SelectedItem != null)
            {
                listBoxNhom2.Items.Add(listBoxNhom1.SelectedItem);
                listBoxNhom1.Items.Remove(listBoxNhom1.SelectedItem);
                lbTong1.Text = "Tổng Số : " + listBoxNhom1.Items.Count;
                lbTong2.Text = "Tổng Số : " + listBoxNhom2.Items.Count;
            }
        }

        private void btnPhaiSTraiS_Click(object sender, EventArgs e)
        {
            while (listBoxNhom2.SelectedItem != null)
            {
                listBoxNhom1.Items.Add(listBoxNhom2.SelectedItem);
                listBoxNhom2.Items.Remove(listBoxNhom2.SelectedItem);
                lbTong1.Text = "Tổng Số : " + listBoxNhom1.Items.Count;
                lbTong2.Text = "Tổng Số : " + listBoxNhom2.Items.Count;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoas_Click(object sender, EventArgs e)
        {
            while(listBoxNhom1.SelectedItem != null)
            {
                listBoxNhom1.Items.Remove(listBoxNhom1.SelectedItem);
            }
            while (listBoxNhom2.SelectedItem != null)
            {
                listBoxNhom2.Items.Remove(listBoxNhom2.SelectedItem);
            }
        }
    }
}
