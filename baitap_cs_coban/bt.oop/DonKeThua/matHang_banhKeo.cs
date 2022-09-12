using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonKeThua
{
    internal class matHang_banhKeo
    {
        class matHang
        {
            private string maHang;
            protected string tenHang;
            protected double donGia;

            public string MaHang { get => maHang; set => maHang = value; }

            public matHang()
            {
                MaHang = "MO1";
                tenHang = "BANH KEO";
                donGia = 25000;
            }
            public matHang(string maHang, string tenHang, double donGia)
            {
                this.MaHang = maHang;
                this.tenHang = tenHang;
                this.donGia = donGia;
            }
            ~matHang() { }
            public void InPut()
            {
                Console.Write("\n\t - Nhập Vào Mã Hàng Hóa : "); MaHang = Console.ReadLine();
                Console.Write("\n\t - Nhập Vào Tên Hàng Hóa : "); tenHang = Console.ReadLine();
                Console.Write("\n\t - Nhập Vào Đơn Giá Hàng Hóa : "); donGia = double.Parse(Console.ReadLine());
            }
        }
        class banhKeo : matHang
        {
            protected string noiSanXuat;
            public banhKeo()
            {
                MaHang = "MO1";
                tenHang = "BANH KEO";
                donGia = 25000;
                noiSanXuat = "THAI BINH";
            }
            public banhKeo(string maHang, string tenHang, double donGia, string noiSanXuat) : base(maHang, tenHang, donGia)
            {
                this.noiSanXuat = noiSanXuat;
            }
            public new void InPut()
            {
                base.InPut();
                Console.Write("\n\t - Nhập vào nơi sản xuất : "); noiSanXuat = Console.ReadLine();
            }
            public double tinhChietKhau()
            {
                return donGia * 0.01;
            }
            public void OutPut()
            {
                Console.WriteLine("\t|{0,15}  |{1,25}  |{2,15}đ |{3,10}đ |{4,20}  |" +
                    "\n\t+===================================================================================================+"
                    , MaHang.Trim().ToUpper(), tenHang.Trim().ToUpper(), donGia, tinhChietKhau(), noiSanXuat.Trim().ToUpper());
            }
        }
        static void Nhap(banhKeo[] a, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n  [+] Nhập vào Bánh Kẹo Thứ [{i + 1}] : ");
                a[i] = new banhKeo();
                a[i].InPut();
            }
        }
        static void tieuDe()
        {
            Console.WriteLine("\t+===================================================================================================+" +
                "\n\t|{0,15}  |{1,25}  |{2,16} |{3,11} |{4,20}  |" +
                   "\n\t+===================================================================================================+"
                   , "Mã Hàng", "Tên Hàng", "Đơn Giá", "Chiết Khấu", "Nơi Sản Xuất");
        }
        static void Xuat(banhKeo[] a, uint n)
        {
            tieuDe();
            for (int i = 0; i < n; i++)
            {
                a[i].OutPut();
            }
        }
        static void kiemTra(banhKeo[] a, uint n)
        {
            tieuDe();
            for (int i = 0; i < n; i++)
            {
                if (a[i].MaHang.ToUpper().Trim() != "MAO1")
                {
                    a[i].OutPut();
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write(" - [*]_Nhập Vào Số Lượng Hàng Hóa : "); uint n = uint.Parse(Console.ReadLine());
            banhKeo[] a = new banhKeo[n];
            Nhap(a, n);
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t[+] Danh Sách Số Lượng Hàng Hóa Vừa Nhập Về Là [+]");
            Xuat(a, n);
            Console.WriteLine("\n\t\t\t\t[+] Danh Sách Hàng Hóa Vừa Nhập Về Không Có Mã MA01 [+]");
            kiemTra(a, n);
            Console.ReadLine();
        }
    }
}
