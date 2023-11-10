using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07___BaiTapVN_05
{
    class SinhVien
    {
        protected string maSV;
        protected string hoTen;
        protected int NS;
        // hàm tạo có tham
        public SinhVien(string maSV, string hoTen,  int NS)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.NS = NS;
        }
        // Phương thức hiển thị
        public override string ToString()
        {
            return maSV+"\t"+
                hoTen+"\t"+
                NS;
        }

    }
    class SinhVienCK: SinhVien
    {
        private double DiemVKT;
        private double DiemCNC;
        public SinhVienCK(string maSV, string hoTen, int NS, double DiemVKT, double DiemCNC):base(maSV, hoTen, NS)
        {
            this.DiemVKT = DiemVKT;
            this.DiemCNC = DiemCNC;
        }
        // phương thức hiển thị
        public override string ToString()
        {
            return base.ToString()+"\t"+
                DiemVKT+"\t"+
                DiemCNC;
        }
    }

}
