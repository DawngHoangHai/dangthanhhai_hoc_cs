using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace Ma_Hill
{
    public partial class hill : Form
    {
        public hill()
        {
            InitializeComponent();
        }
       

        private void btnp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            if (dl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader f = new StreamReader(dl.FileName);
                while (f.EndOfStream == false)
                    txtp.Text = f.ReadToEnd();
                f.Close();
            }
               
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            if (dl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader f = new StreamReader(dl.FileName);
                while (f.EndOfStream == false)
                txtc.Text = f.ReadToEnd();
                f.Close();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtp.Text = "";
            txtc.Text = "";
            txtk.Text = "";
            txtik.Text = "";
        }

       

        private void btnk_Click(object sender, EventArgs e)
        {
            Hill.intit();
            string k = "";
            Random rd = new Random();
            for (int i = 0; i < Math.Pow(int.Parse(txtl.Text), 2); i++)
                k += rd.Next(1, Hill.dic1.Count) + ",";
            k = k.Remove(k.Length - 1, 1);
            txtk.Text = k;

        }

        private void btnsk_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.Write(txtk.Text);
                file.Close();
            }
        }

        private void btnik_Click(object sender, EventArgs e)
        {
            Hill.intit();
          
            int l;
            int.TryParse(txtl.Text, out l);
            int[,] k = mymatric._creat_M(txtk.Text, l);
            int[,] mk = mymatric.MP(k,Hill.dic1.Keys.Count);
            txtik.Text = mymatric.M_to_string(mk);
        }

       
        private void hill_Load(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtik.Text == "" || txtc.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin bản mã và ma trận IK!");
                return;
            }
            Stopwatch st = new Stopwatch();
            st.Start();
            int len = int.Parse(txtl.Text);
            List<string> splitString = ECB_Encryption.tachChuoi(txtc.Text,len);

            txtp.Text = ECB_Encryption.ecb(txtc.Text, len, splitString, txtik.Text);

            st.Stop();
             txtwoc.Text = st.ElapsedMilliseconds.ToString();
        }

      

    private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtk.Text == "" || txtp.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin bản rõ và độ dài ma trận K!");
                return;
            }

            int len = int.Parse(txtl.Text.Trim());

            if (len > txtp.Text.Length)
            {
                MessageBox.Show("L phải nhỏ hơn độ dài của bản rõ, mời bạn nhập lại");
                return;
            }
            Stopwatch st = new Stopwatch();
            st.Start();
            List<string> splitString = ECB_Encryption.tachChuoi(txtp.Text,len);

            txtc.Text = ECB_Encryption.ecb(txtp.Text, len, splitString, txtk.Text);
 
            st.Stop();
            txtwc.Text = st.ElapsedMilliseconds.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.Write(txtk.Text);
                file.Close();
            }
        }
    }
}
