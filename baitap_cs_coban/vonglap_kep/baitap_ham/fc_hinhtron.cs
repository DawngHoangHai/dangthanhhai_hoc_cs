using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_ham
{
    internal class fc_hinhtron
    {

        public const double PI = 3.1415926535897931;
        static void chuVi(float r)
        {
            float CV = (float)(2 * PI * r);
            Console.WriteLine(" -> Chu vi hình chữ nhật là : " + Math.Round(CV, 2));
        }
        static void dienTich(float r)
        {
            float S = (float)(PI * r * r);
            Console.WriteLine(" -> Diện tích hình chữ nhật là : " + Math.Round(S, 2));
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            float r = 3;
            chuVi(r);
            dienTich(r);
            Console.ReadLine();
        }
    }
}
