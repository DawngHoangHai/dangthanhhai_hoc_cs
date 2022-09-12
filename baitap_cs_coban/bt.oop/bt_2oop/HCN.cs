using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_2oop
{
    internal class HCN
    {
        private int dai, rong;
        public HCN(int dai = 10, int rong = 5)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public void InPut()
        {
            Console.Write("\n - Nhap vao chieu dai : "); dai = int.Parse(Console.ReadLine());
            Console.Write("\n - Nhap vao chieu rong : "); rong = int.Parse(Console.ReadLine());
        }
        public float ChuVi()
        {
            return (float)(dai + rong) * 2;
        }
        public float DienTich()
        {
            return dai * rong;
        }
        public void OutPut()
        {
            Console.WriteLine("\n -> Chieu dai : {0} , Chieu Rong : {1}\n -> Chu Vi : {2}\n -> Dien Tich : {3}"
                , dai, rong, ChuVi(), DienTich());
        }
        static void TimMax(HCN[] a, int n)
        {
            HCN max = a[0];
            HCN min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max.ChuVi() < a[i].ChuVi())
                {
                    max = a[i];
                }
                if (min.DienTich() > a[i].DienTich())
                {
                    min = a[i];
                }
            }
            Console.WriteLine("\n--------------------------------------------------------------\n Chu Vi lon Nhat la : "); max.OutPut();
            Console.WriteLine("\n Dien Tich Nho Nhat La : "); min.OutPut();
        }

        static void Main(string[] args)
        {
            Console.Write(" - Nhap vao so luong hinh chu nhat : "); int n = int.Parse(Console.ReadLine());
            HCN[] a = new HCN[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"- Nhap vao hinh chu nhat thu [{i + 1}] : ");
                a[i] = new HCN();
                a[i].InPut();
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine(" Cac Hinh Chu Nhat Vua Nhap Vao La !! ");
            for (int i = 0; i < n; i++)
            {
                a[i].OutPut();
            }
            TimMax(a, n);

        }
    }
}
