using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operater_toantu_Csap
{
    internal class operater_gan
    {
        static void Main()
        {
            Console.Title = "!! CHUONG TRINH TOAN TU GAN !!";
            //default : 1 biến mà gán thì bằng 0 hoặc  rỗng :
            int a = default ; //tương đương int a = 0;
            string b = default ;// tương đương int a = " ";
            char c = default;
            object o = default ; // o = null;
            Console.WriteLine(" a = " + a + "\n b = "+b + " \n c = " + c);
            Console.WriteLine(" object la : " + o);
            bool kiemtra = true; // bool kiemtra = default == bool kiemtra = false
            Console.WriteLine(kiemtra);
            int x = 100;
            x += a; // x = x+a; trừ, nhân, chia, tương tự 
            
        }
    }
}
