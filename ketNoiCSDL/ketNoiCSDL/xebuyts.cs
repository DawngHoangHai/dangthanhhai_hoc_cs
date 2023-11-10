using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ketNoiCSDL
{
    public partial class xebuyts : Form
    {
        public xebuyts()
        {
            InitializeComponent();
        }

        private void xebuyts_Load(object sender, EventArgs e)
        {
            try
            {

                datagridsxeBuyts.DataSource = Connections.HienThiBang("select * from xeBuyts");
                datagridsxeBuyts.Columns[0].HeaderText = "Hãng Xe";
                datagridsxeBuyts.Columns[1].HeaderText = "Số Ghế";
                datagridsxeBuyts.Columns[2].HeaderText = "Giá Cả";
                datagridsxeBuyts.Columns[3].HeaderText = "Số Hiệu Tuyến";
            }
            catch
            {
                MessageBox.Show("KHONG HIEN THI DUOC !!! ", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNhanHieu.Text.Trim() == "" || txtGiaCa.Text.Trim() == "" ||
                txtSoGhe.Text.Trim() == "" || txtSoTuyen.Text.Trim() == "")
            {
                MessageBox.Show("MOI NHAP DUA LIEU DE THEM ", "THONG BÁO");
            }
            else
            {
                try
                {
                    string hang = txtNhanHieu.Text.Trim();
                    int soGhe = 0, soTuyen = 0;
                    float giaCa = 0f;
                    try
                    {
                        soGhe = int.Parse(txtSoGhe.Text.Trim());
                        soTuyen = int.Parse(txtSoTuyen.Text.Trim());
                        giaCa = float.Parse(txtGiaCa.Text.Trim());
                        string sql = $"insert dbo.xebuyts values (N'{hang}',{soGhe},{giaCa},{soTuyen})";
                        Connections.Insert_UpDate_Del(sql);
                        datagridsxeBuyts.DataSource = Connections.HienThiBang("select * from xeBuyts");
                        datagridsxeBuyts.Columns[0].HeaderText = "Hãng Xe";
                        datagridsxeBuyts.Columns[1].HeaderText = "Số Ghế";
                        datagridsxeBuyts.Columns[2].HeaderText = "Giá Cả";
                        datagridsxeBuyts.Columns[3].HeaderText = "Số Hiệu Tuyến";
                    }
                    catch
                    {
                        MessageBox.Show("MOI NHAP VAO SO ", "THONG BÁO");
                    }
                }
                catch
                {
                    MessageBox.Show("KHONG THEM DUA LIEUJ DUOWCJ VI CO MA CTRUNG NHAU ", "THONG BÁO");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtNhanHieu.Text.Trim() == "")
            {
                MessageBox.Show("MOI CLICK VAOF DU LIEU MUAN XOA", "THONG BÁO");
            }
            else
            {
                DialogResult result = MessageBox.Show("BAN MUON XOA KHONG ","THONG BAO",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        string hang = txtNhanHieu.Text.Trim();
                        string sql = $"delete dbo.xebuyts where nhanHieu = N'{hang}'";
                        Connections.Insert_UpDate_Del(sql);
                        datagridsxeBuyts.DataSource = Connections.HienThiBang("select * from xeBuyts");
                        datagridsxeBuyts.Columns[0].HeaderText = "Hãng Xe";
                        datagridsxeBuyts.Columns[1].HeaderText = "Số Ghế";
                        datagridsxeBuyts.Columns[2].HeaderText = "Giá Cả";
                        datagridsxeBuyts.Columns[3].HeaderText = "Số Hiệu Tuyến";
                    }
                    catch
                    {
                        MessageBox.Show("KHONG XOA DUOC !!", "THONG BÁO");
                    }
                }
            }
        }

        private void datagridsxeBuyts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //khoomng
        }

        private void datagridsxeBuyts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selected = datagridsxeBuyts.Rows[e.RowIndex];
            txtNhanHieu.Text = selected.Cells[0].Value.ToString();
            txtGiaCa.Text = selected.Cells[2].Value.ToString();
            txtSoGhe.Text = selected.Cells[1].Value.ToString();
            txtSoTuyen.Text = selected.Cells[3].Value.ToString();
            txtNhanHieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNhanHieu.Text.Trim() == "" || txtGiaCa.Text.Trim() == "" ||
                txtSoGhe.Text.Trim() == "" || txtSoTuyen.Text.Trim() == "")
            {
                MessageBox.Show("MOI NHAP DUA LIEU DE SUA ", "THONG BÁO");
            }
            else
            {
                DialogResult result = MessageBox.Show("BAN MUON XOA KHONG ", "THONG BAO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        string hang = txtNhanHieu.Text.Trim();
                        int soGhe = 0, soTuyen = 0;
                        float giaCa = 0f;
                        try
                        {
                            soGhe = int.Parse(txtSoGhe.Text.Trim());
                            soTuyen = int.Parse(txtSoTuyen.Text.Trim());
                            giaCa = float.Parse(txtGiaCa.Text.Trim());
                            string sql = $"update dbo.xebuyts set soGhe = {soGhe}, giaCa = {giaCa} , soHieuTuyenXe = {soTuyen} where  nhanHieu = N'{hang}'";
                            Connections.Insert_UpDate_Del(sql);
                            datagridsxeBuyts.DataSource = Connections.HienThiBang("select * from xeBuyts");
                            datagridsxeBuyts.Columns[0].HeaderText = "Hãng Xe";
                            datagridsxeBuyts.Columns[1].HeaderText = "Số Ghế";
                            datagridsxeBuyts.Columns[2].HeaderText = "Giá Cả";
                            datagridsxeBuyts.Columns[3].HeaderText = "Số Hiệu Tuyến";
                        }
                        catch
                        {
                            MessageBox.Show("MOI NHAP VAO SO ", "THONG BÁO");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("KHONG Sua DUA LIEUJ DUOWCJ ", "THONG BÁO");
                    }
                }
                
            }
        }
    }
}
