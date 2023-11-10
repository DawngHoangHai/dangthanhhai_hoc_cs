using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ketNoiCSDL
{
    public partial class UseName : Form
    {
        public UseName()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connections.ketNoiConnection();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Username where usename = '" + txtUser.Text.Trim()+ "' and password =  '"+txtPass.Text.Trim()+"'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form1 f = new Form1(dt.Rows[0][2].ToString());
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("MOI CLICK VAO DONG MUAN XOA!!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
