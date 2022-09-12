using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt.oop
{
    internal class DA_THUC
    {
        private int bac3, bac2, bac1, bac0;
        public DA_THUC()
        {
            this.bac3 = 5;
            this.bac2 = 5;
            this.bac1 = 3;
            this.bac0 = 2;
        }
        public DA_THUC(int bac3, int bac2, int bac1, int bac0)
        {
            this.bac3 = bac3;
            this.bac2 = bac2;
            this.bac1 = bac1;
            this.bac0 = bac0;
        }
        ~DA_THUC() { }
        public void InPut()
        {
            Console.Write("\n - Nhap vao bac 3 = "); bac3 = int.Parse(Console.ReadLine());
            Console.Write("\n - Nhap vao bac 2 = "); bac2 = int.Parse(Console.ReadLine());
            Console.Write("\n - Nhap vao bac 1 = "); bac1 = int.Parse(Console.ReadLine());
            Console.Write("\n - Nhap vao bac 0 = "); bac0 = int.Parse(Console.ReadLine());
        }
        public void OutPut()
        {
            Console.WriteLine($"\n -> {bac3}x3 + {bac2}x2 + {bac1}x + {bac0} = 0");
        }
        static void Main()
        {
            DA_THUC[] a = new DA_THUC[2];
            for (int i = 0; i < 2; i++)
            {
                a[i] = new DA_THUC();// khởi tạo riêng 1 đối tường của mảng đó 
                Console.WriteLine($" - Nhap vao da thuc thu [{i + 1}] ");
                a[i].InPut();
            }
            for (int i = 0; i < 2; i++)
            {
                a[i].OutPut();
            }
            Console.WriteLine($"\n - TONG 2 DA THUC LA : \n -> {a[0].bac3 + a[1].bac3}x3 + {a[0].bac2 + a[1].bac2}x2" +
                    $" + {a[0].bac1 + a[1].bac1}x + {a[0].bac0 + a[1].bac0} = 0 ");
        }
    }
}
