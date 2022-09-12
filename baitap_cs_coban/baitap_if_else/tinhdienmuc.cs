using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_cs_coban
{
    internal class tinhdienmuc
    {
       static void Main()
        {
            double soDien;
            Console.Write(" - Nhap vao so dien tieu thu :");soDien = double.Parse(Console.ReadLine());
            if(soDien <= 100)
            {
                Console.WriteLine($" -> So dien gia dinh ban su dung o dinh muc !! \n -> So tien ma gia dinh can gui la :{500*soDien} k");
            }else
            {
                Console.WriteLine($" -> So dien gia dinh ban su dung vuot dinh muc !! \n -> So tien ma gia dinh can gui la :{800 * soDien} k");
            }
        }
    }
}
