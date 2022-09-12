using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_cs_coban
{
    internal class tinhthue
    {
        static void Main()
        {
            float soPhut,phiThuebao = 30000 ,S  = 0;
            Console.WriteLine("\n\t 600 đong cho moi phut goi cua 50 phut đau tien\n");
            Console.WriteLine("\t 400 đong cho moi phut goi cua 150 phut tiep theo \n");
            Console.WriteLine("\t 200 đong cho bat ky phut goi nao sau 200 phut đau tien \n");
            Console.Write(" \t- Nhap vao so phut ban goi :");soPhut = float.Parse(Console.ReadLine());
            if(soPhut <= 50)
            {
                S = phiThuebao + (soPhut*600);
                Console.WriteLine($"\t -> So tien quy khach phai tra la :{S}k");
            }else if(soPhut >50 && soPhut <= 150)
            {
                S = phiThuebao + (soPhut * 400);
                Console.WriteLine($"\t -> So tien quy khach phai tra la :{S}k");
            }
            else
            {
                S = phiThuebao + (soPhut * 200);
                Console.WriteLine($"\t -> So tien quy khach phai tra la :{S}k");
            }
        }
    }
}
