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
    public partial class Bai19 : Form
    {
        public Bai19()
        {
            InitializeComponent();
        }

        private void Bai19_Load(object sender, EventArgs e)
        {
            listBoxArrays.Text = string.Empty;
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            txtHienThi.Select();
            if (listBoxArrays.Items.IndexOf(txtHienThi.Text) < 0)
            {
                listBoxArrays.Items.Add(txtHienThi.Text);
                txtHienThi.Text = string.Empty;
                txtHienThi.Focus();
            }
            else if (txtHienThi.Text.Trim() == "")
            {
                MessageBox.Show("Không Được Để trống Phần tử");
            }
            else
            {
                MessageBox.Show(txtHienThi.Text + "  Đã Tồn Tại");
                txtHienThi.Text = string.Empty;
                txtHienThi.Focus();
            }


        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTongCacSo_Click(object sender, EventArgs e)
        {
            long sum = 0;
            foreach (string item in listBoxArrays.Items)
            {
                sum = sum + int.Parse(item);
            }
            txtHienThi.Text = sum.ToString();
        }

        private void txtHienThi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHienThi.Select();
                if (listBoxArrays.Items.IndexOf(txtHienThi.Text) < 0)
                {
                    listBoxArrays.Items.Add(txtHienThi.Text);
                    txtHienThi.Text = string.Empty;
                    txtHienThi.Focus();
                }
                else if (txtHienThi.Text.Trim() == "")
                {
                    MessageBox.Show("Không Được Để trống Phần tử");
                }
                else
                {
                    MessageBox.Show(txtHienThi.Text + "  Đã Tồn Tại");
                    txtHienThi.Text = string.Empty;
                    txtHienThi.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (listBoxArrays.Items.Count > 0)
                listBoxArrays.Items.RemoveAt(0);
            if (listBoxArrays.Items.Count > 0)
                listBoxArrays.Items.RemoveAt(listBoxArrays.Items.Count - 1);
            if (listBoxArrays.Items.Count <= 0)
            {
                MessageBox.Show("Mời Nhập Vào Thêm Phần tử !!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listBoxArrays.SelectedItem != null)
                listBoxArrays.Items.Remove(listBoxArrays.SelectedItem);
            if (listBoxArrays.Items.Count <= 0)
            {
                MessageBox.Show("Mời Nhập Vào Thêm Phần tử !!!");
            }
        }

        private void btnTangThem2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                int sum = int.Parse(listBoxArrays.Items[i].ToString());
                sum += 2;
                listBoxArrays.Items[i] = sum;
            }

        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                int sum = int.Parse(listBoxArrays.Items[i].ToString());
                sum *= 2;
                listBoxArrays.Items[i] = sum;
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                int n = int.Parse(listBoxArrays.Items[i].ToString());
                if (n % 2 != 0)
                {
                    listBoxArrays.SelectedItems.Add(listBoxArrays.Items[i]);
                }
            }
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                int n = int.Parse(listBoxArrays.Items[i].ToString());
                if (n % 2 == 0)
                {
                    listBoxArrays.SelectedItems.Add(listBoxArrays.Items[i]);
                }
            }
        }

        private void btnSapXepTangDan_Click(object sender, EventArgs e)
        {
            int[] arr = new int[listBoxArrays.Items.Count];
            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                arr[i] = int.Parse(listBoxArrays.Items[i].ToString());
            }
            Array.Sort(arr);
            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                listBoxArrays.Items[i] = arr[i];
            }
        }

        private void btnSapXepGiamDan_Click(object sender, EventArgs e)
        {
            int[] arr = new int[listBoxArrays.Items.Count];
            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                arr[i] = int.Parse(listBoxArrays.Items[i].ToString());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < listBoxArrays.Items.Count; i++)
            {
                listBoxArrays.Items[i] = arr[i];
            }
        }
        static bool IsPrime(int num)
        {
            if (num < 3)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnTimSoNGuyenTo(object sender, EventArgs e)
        {
            int[] arr = new int[listBoxArrays.Items.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(listBoxArrays.Items[i].ToString());
                if (IsPrime(arr[i]) )
                {
                    listBoxArrays.SelectedItems.Add(listBoxArrays.Items[i]);
                }
            }

        }
    }
}
