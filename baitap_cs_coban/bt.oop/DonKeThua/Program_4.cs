using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonKeThua
{
    internal class Program_4
    {
        class AnPham
        {
            protected string Ten;
            protected double giaThanh;
            public void InPut()
            {
                Console.Write(" - Nhập Vào Tên : "); Ten = Console.ReadLine();
                Console.Write(" - Nhập Vào Giá Thành : "); giaThanh = double.Parse(Console.ReadLine());
            }
            public void OutPut()
            {
                Console.WriteLine("\n - Tên  = {0}\n - Giá Thành = {1}", Ten, giaThanh);
            }
        }
        class Sach : AnPham
        {
            private int soTrang;

            public int SoTrang { get => soTrang; set => soTrang = value; }

            public new void InPut()
            {
                base.InPut();
                Console.Write(" - Nhập vào số trang : "); SoTrang = int.Parse(Console.ReadLine());
            }
            public new void OutPut()
            {
                base.OutPut();
                Console.WriteLine("\n - Số Trang = {0}", SoTrang);
            }
        }
        class Dia_CD : AnPham
        {
            protected float soPhut;
            public new void InPut()
            {
                base.InPut();
                Console.Write(" - Nhập vào số phút : "); soPhut = float.Parse(Console.ReadLine());
            }
            public new void OutPut()
            {
                base.OutPut();
                Console.WriteLine("\n - Số Phút = " + soPhut);
            }
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n, choose;
            Console.Write(" - Mời Nhập vào lựa chọn của bạn : ");
            do
            {
                choose = int.Parse(Console.ReadLine());
                if (choose > 3 || choose < 1)
                {
                    Console.Write(" - Mời Nhập Lại lựa chọn của bạn : ");
                }
            } while (choose > 3 || choose < 1);
            if (choose == 1)
            {
                Console.WriteLine("--> Bạn Nhập Sản Phẩm Sách !!");
                Console.Write(" - Nhập vào số lượng sách : "); n = int.Parse(Console.ReadLine());
                Sach[] a = new Sach[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($" - Nhập vào Quấn sách thứ [{i + 1}] : \n");
                    a[i] = new Sach();
                    a[i].InPut();
                }
                Console.WriteLine("-------------------------------------------------------------------");
                for (int i = 0; i < n; i++)
                {
                    a[i].OutPut();
                }
            }
            if (choose == 2)
            {
                Console.WriteLine("--> Bạn Nhập Sản Phẩm Đĩa CD !!");
                Console.Write(" - Nhập vào số lượng Đĩa CD : "); n = int.Parse(Console.ReadLine());
                Dia_CD[] a = new Dia_CD[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"\n - Nhập vào Đĩa C D thứ [{i + 1}] : \n");
                    a[i] = new Dia_CD();
                    a[i].InPut();
                }
                Console.WriteLine("-------------------------------------------------------------------");
                for (int i = 0; i < n; i++)
                {
                    a[i].OutPut();
                }
            }
        }
    }
}
