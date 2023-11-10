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
    public partial class Bai21 : Form
    {
        public Bai21()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int n;
            if (int.TryParse(txtNhaps.Text, out n))
            {
                int[] randomNumbers = new int[n];
                int i = 0;

                while (i < n)
                {
                    int randomNumber = rdm.Next(1, 101); // Tạo số ngẫu nhiên từ 1 đến 100

                    if (!randomNumbers.Contains(randomNumber)) // Kiểm tra xem số đó đã có trong mảng hay chưa
                    {
                        randomNumbers[i] = randomNumber;
                        cbxSoCaLoai.Items.Add(randomNumbers[i]);
                        i++;
                    }

                }
                txtNhaps.Clear();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Vào Số Nguyên !! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //n = int.Parse(txtN.Text);

        }

        private void cbxSoCaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSo.Items.Clear();
            int n = int.Parse(cbxSoCaLoai.Text);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    listBoxSo.Items.Add(i);
                }
            }
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 0; i < listBoxSo.Items.Count; i++)
            {
                sum += (int)listBoxSo.Items[i];
            }
            MessageBox.Show($"Tổng Của Các Ước Là : {sum} ", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNhaps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Random rdm = new Random();
                int n;
                if (int.TryParse(txtNhaps.Text, out n))
                {
                    int[] randomNumbers = new int[n];
                    int i = 0;

                    while (i < n)
                    {
                        int randomNumber = rdm.Next(1, 101); // Tạo số ngẫu nhiên từ 1 đến 100

                        if (!randomNumbers.Contains(randomNumber)) // Kiểm tra xem số đó đã có trong mảng hay chưa
                        {
                            randomNumbers[i] = randomNumber;
                            cbxSoCaLoai.Items.Add(randomNumbers[i]);
                            i++;
                        }

                    }
                    txtNhaps.Clear();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Vào Số Nguyên !! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //n = int.Parse(txtN.Text);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSoUocChan_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 0; i < listBoxSo.Items.Count; i++)
            {
                if ((int)listBoxSo.Items[i] % 2 == 0)
                {
                    sum += (int)listBoxSo.Items[i];
                }
            }
            MessageBox.Show($"Tổng Của Các Ước Chẵn Là : {sum} ", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int SoNguyenTo(int n)
        {
            int dem = 0;
            if (n < 2)
            {
                return 0;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxSo.Items.Count; i++)
            {
                if (SoNguyenTo((int)listBoxSo.Items[i]) == 1)
                {
                    listBoxSo.SelectedItems.Add(listBoxSo.Items[i]);
                }
            }
        }
    }
}
