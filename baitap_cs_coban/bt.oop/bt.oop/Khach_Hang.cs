using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt.oop
{
    struct Date
    {
        public int year, month, day;
    }
    internal class Khach_Hang
    {
        private string hoTen, chungMinh, hoKhau;
        private Date ngaySinh;
        public Khach_Hang(string hoTen = "DANG THANH HAI", string chungMinh = "012424244", string hoKhau = "THAI BINH", int day = 17, int month = 15, int year = 2002)
        {
            this.hoTen = hoTen;
            this.chungMinh = chungMinh;
            this.hoKhau = hoKhau;
            this.ngaySinh.day = day;
            this.ngaySinh.month = month;
            this.ngaySinh.year = year;
        }
        ~Khach_Hang() { }
        public void OutPut()
        {
            Console.WriteLine("\n - HO TEN : {0}\n - CHUNG MINH : {1}\n - HO KHAU : {2}\n - NGAY SINH : {3,2}/{4,2}/{5,4}"
                , hoTen, chungMinh, hoKhau, ngaySinh.day, ngaySinh.month, ngaySinh.year);
        }
        static void Main()
        {
            Khach_Hang a = new Khach_Hang();
            a.OutPut();
        }
    }
}
