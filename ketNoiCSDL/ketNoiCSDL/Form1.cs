using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ketNoiCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string quyenPhan;
        public Form1(string quyenPhan)
        {
            InitializeComponent();
            this.quyenPhan = quyenPhan;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (quyenPhan.ToLower().Trim() != "admin")
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnUpDate.Enabled = false;
                txtHoTen.Enabled = false;
                txtLuongTN.Enabled = false;
                txtMucLuong.Enabled = false;  
                txtNamSinh.Enabled = false;
                txtTienTK.Enabled = false;  
            }
            try
            {
                dataGRDanhSach.DataSource = Connections.HienThiBang("select * from NhanVien");
                dataGRDanhSach.Columns[0].HeaderText = "Ten Nhan Vien"; // thay dooi tieu deef cuar bangr
                dataGRDanhSach.Columns[1].HeaderText = "Nam Sinh";
                dataGRDanhSach.Columns[0].DefaultCellStyle.Alignment =
                   DataGridViewContentAlignment.MiddleCenter; // chuyển dữ liêu sang bên phải,trái,giữa cột 
                dataGRDanhSach.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;// làm cho các trường dữ liệu được hiện hết 
                dataGRDanhSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // tất cả dữ liệu căn giữa
                dataGRDanhSach.Focus();
                // còn nhiều thuộc tính tìm trong properties
            }
            catch
            {
                MessageBox.Show("KHONG HIEN THI DUOC !!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String hoTen;
            int namSinh = 0;
            float mucLuong = 0, tienTTK = 0, luongTN = 0;
            hoTen = txtHoTen.Text.Trim();
            try
            {
                mucLuong = float.Parse(txtMucLuong.Text.Trim());
                namSinh = int.Parse(txtNamSinh.Text.Trim());
                tienTTK = float.Parse(txtTienTK.Text.Trim());
                luongTN = float.Parse(txtLuongTN.Text.Trim());
                String sql = $"insert into NhanVien values (N'{hoTen}',{namSinh},{mucLuong},{tienTTK},{luongTN})";
                Connections.Insert_UpDate_Del(sql);
                dataGRDanhSach.DataSource = Connections.HienThiBang("select * from NhanVien");
                dataGRDanhSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // tất cả dữ liệu căn giữa
            }
            catch
            {
                MessageBox.Show("Mời Nhập vào số  !!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLuongTN.Text = string.Empty;
                txtNamSinh.Text = string.Empty;
                txtTienTK.Text = string.Empty;
                txtMucLuong.Text = string.Empty;
            }
            
        }

        private void dataGRDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng đã chọn một dòng hợp lệ
            {
                DataGridViewRow selectedRow = dataGRDanhSach.Rows[e.RowIndex];
                txtHoTen.Text = selectedRow.Cells[0].Value.ToString();
                txtHoTen.Enabled = false;
                txtNamSinh.Text = selectedRow.Cells[1].Value.ToString();
                txtMucLuong.Text = selectedRow.Cells[2].Value.ToString();
                txtTienTK.Text = selectedRow.Cells[3].Value.ToString();
                txtLuongTN.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() != "")
            {
                DialogResult resut = MessageBox.Show("Ban co muon xoa khong !! ", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resut == DialogResult.OK)
                {
                    try
                    {
                        String sql = "delete from NhanVien where hoTen = N'" + txtHoTen.Text + "'";
                        Connections.Insert_UpDate_Del(sql);
                        dataGRDanhSach.DataSource = Connections.HienThiBang("select * from NhanVien");
                        dataGRDanhSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // tất cả dữ liệu căn giữa
                    }
                    catch
                    {
                        MessageBox.Show("KHONG XOA DUOC !!! ", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("MOI CLICK VAO DONG MUAN XOA!!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() != "" || txtNamSinh.Text.Trim() != "" || txtLuongTN.Text.Trim() != "" ||
                txtMucLuong.Text.Trim() != "" || txtTienTK.Text.Trim() != "")
            {
                DialogResult resut = MessageBox.Show("Ban co muon sua khong !! ", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resut == DialogResult.OK)
                {
                    try
                    {
                        String hoTen;
                        int namSinh = 0;
                        float mucLuong = 0, tienTTK = 0, luongTN = 0;
                        hoTen = txtHoTen.Text.Trim();
                        try
                        {
                            mucLuong = float.Parse(txtMucLuong.Text.Trim());
                            namSinh = int.Parse(txtNamSinh.Text.Trim());
                            tienTTK = float.Parse(txtTienTK.Text.Trim());
                            luongTN = float.Parse(txtLuongTN.Text.Trim());
                            String sql = $"update dbo.NhanVien set namSinh = {namSinh} , mucLuong = {mucLuong} , tienTrongTk = {tienTTK} , luongTN = {luongTN} where hoTen = N'{hoTen}'";
                            Connections.Insert_UpDate_Del(sql);
                            dataGRDanhSach.DataSource = Connections.HienThiBang("select * from NhanVien");
                            dataGRDanhSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // tất cả dữ liệu căn giữa
                        }
                        catch
                        {
                            MessageBox.Show("Mời Nhập vào số  !!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtLuongTN.Text = string.Empty;
                            txtNamSinh.Text = string.Empty;
                            txtTienTK.Text = string.Empty;
                            txtMucLuong.Text = string.Empty;
                        }
                        dataGRDanhSach.DataSource = Connections.HienThiBang("select * from NhanVien");
                        dataGRDanhSach.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // tất cả dữ liệu căn giữa
                    }
                    catch
                    {
                        MessageBox.Show("KHONG SUA DUOC !!! ", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("MOI CLICK VAO DONG MUAN SUa!!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

