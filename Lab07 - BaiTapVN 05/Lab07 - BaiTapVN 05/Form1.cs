using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab07___BaiTapVN_05
{
    public partial class Form1 : Form
    {
        private ArrayList lst = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns[4].Width = 200;
            listView1.Columns[5].Width = 200;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVienCK sv = new SinhVienCK(
                txtMaSV.Text,
                txtHoTen.Text,
                 int.Parse(txtNS.Text),
                 double.Parse(txtDiemVKT.Text),
                 double.Parse(txtDiemCNC.Text));
            lst.Add(sv);
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtNS.Text = "";
            txtDiemVKT.Text = "";
            txtDiemCNC.Text = "";
            txtMaSV.Focus();
                
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            foreach (SinhVienCK sv in lst)
            {
                string s = sv.ToString();
                string[] field = s.Split('\t');

                ListViewItem r = new ListViewItem(field[0]);
                r.SubItems.Add(field[1]);
                r.SubItems.Add(field[2]);
                r.SubItems.Add(field[3]);
                r.SubItems.Add(field[4]);

                double tbc = (double.Parse(field[3]) + double.Parse(field[4])) / 2;
                r.SubItems.Add(tbc.ToString());

                listView1.Items.Add(r);
            }
        }
    }
}
