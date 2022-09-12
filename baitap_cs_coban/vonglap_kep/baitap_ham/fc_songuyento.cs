using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_ham
{
    internal class fc_songuyento
    {
        static int check_so_nguyento(int n)
        {
            if (n < 3)
                return 0;// khong la so nguye to 
            else
            {
                int dem = 0;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 0)
                    return 1;//la so nguyen to 
                else
                    return 0;// k la so nguye to 
            }
        }
        static void kiemTra(int n)
        {
            Console.Write(" Nhap vao so bat ki :"); n = int.Parse(Console.ReadLine());
            if (check_so_nguyento(n) == 1)
            {
                Console.WriteLine($" -> {n} la so nguyen to !!");
            }
            else
            {
                Console.WriteLine($" -> {n} khong la so nguyen to !!");
            }
        }
        static void inSoNT(int a)
        {
            Console.Write("\n\n Nhap vao so tu 1 den bat ki :"); a = int.Parse(Console.ReadLine());
            Console.Write($" -> So nguyen to tu 1 den {a} la :");
            for (int i = 2; i < a; i++)
            {
                if (check_so_nguyento(i) == 1)
                {
                    Console.Write("\t" + i);
                }
            }
        }
        static void Main()
        {
            int n = default;
            kiemTra(n);
            inSoNT(n);
            Console.ReadLine();
        }
    }
}
