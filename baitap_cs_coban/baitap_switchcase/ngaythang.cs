using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            Console.Write(" - Nhap vao thang : ");thang = int.Parse(Console.ReadLine());
            Console.Write(" - Nhap vao nam : "); nam = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        Console.WriteLine($" -> Thang {thang} cua Nam {nam} co 31 ngay ! \n");
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        Console.WriteLine($" -> Thang {thang} cua Nam {nam} co 30 ngay ! \n");
                        break;
                    }
                case 2:
                    {
                        if(nam %4 == 0 && nam % 100 !=0 || nam % 400 == 0 )
                        {
                            Console.WriteLine($" -> Thang {thang} cua Nam {nam} co 29 ngay ! \n");
                        }
                        else
                        {
                            Console.WriteLine($" -> Thang {thang} cua Nam {nam} co 28 ngay ! \n");
                        }
                        break;
                    }
            }
        }
    }
}
