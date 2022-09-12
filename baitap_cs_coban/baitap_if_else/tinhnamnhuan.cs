using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_if_esle
{
    internal class tinhnamnhuan
    {
        static void Main(string[] args)
        {
            ulong nam;
            Console.Write(" - Nhap vao nam ma ban muan nhap : ");nam = ulong.Parse(Console.ReadLine()); 
            if(nam %4==0 && nam %100 !=0 || nam %400 ==0)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($" -> NAM {nam} la NAM nhuan !!! ");
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($" -> NAM {nam} khong la NAM nhuan !!! ");
            }
        }
    }
}
