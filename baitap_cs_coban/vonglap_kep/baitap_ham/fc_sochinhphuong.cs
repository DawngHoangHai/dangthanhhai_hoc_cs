using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_ham
{
    internal class fc_sochinhphuong
    {
        static int Check(int n)
        {
            int soCP = (int)Math.Sqrt(n);
            if (soCP * soCP == n)
            {
                return 1;
            }
            return 0;
        }
        static void kiemTraCP(int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (Check(n) == 1)
            {
                Console.WriteLine($" -> {n} là số chính phương !!! ");
            }
            else
            {
                Console.WriteLine($" -> {n} không là số chính phương !!! ");
            }
        }
        static void inSoCP(int n)
        {
            Console.Write($"\n -> Số chính phương từ 1 đến {n} là : ");
            for (int i = 1; i <= n; i++)
            {
                if (Check(i) == 1)
                {
                    Console.Write("\t " + i);
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("\n - Nhập vào số bất kì để kiểm tra :"); n = int.Parse(Console.ReadLine());
            kiemTraCP(n);
            Console.Write("\n\n - Nhập vào số 1 đến bất kì bạn :"); n = int.Parse(Console.ReadLine());
            inSoCP(n);
            Console.ReadLine();
        }

    }
}
