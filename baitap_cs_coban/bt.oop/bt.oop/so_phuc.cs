using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt.oop
{
    internal class so_phuc // tạo ra lớp tiện ích 
    {
        private int phanthuc, phanao;
        so_phuc(int a = 0, int b = 0)
        {
            phanthuc = a;
            phanao = b;
        }
        ~so_phuc()
        {
            //Console.WriteLine(" huy huy huy");
        }
        public void inPut()
        {
            Console.Write("\n - Nhap vao phan thuc : "); phanthuc = int.Parse(Console.ReadLine());
            Console.Write("\n - Nhap vao phan ao : "); phanao = int.Parse(Console.ReadLine());
        }
        public void ouPut()
        {
            Console.WriteLine($" -> {phanthuc} + {phanao} * j");
        }
        static void Main()
        {
            so_phuc[] sp = new so_phuc[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n - Nhap Vao So Phuc Thu [{0}] : ", i + 1);
                sp[i] = new so_phuc();
                sp[i].inPut();
            }
            Console.WriteLine("\n Cac So Phuc Vua Nhap Vao La : ");
            foreach (var i in sp)
            {
                i.ouPut();
            }
            Console.WriteLine("\n - Tong 3 Da Thuc La : ");
            Console.WriteLine("\n {0} + {1} * j",
                sp[0].phanthuc + sp[1].phanthuc + sp[2].phanthuc, sp[0].phanao + sp[1].phanao, sp[2].phanao);
        }
    }
}
