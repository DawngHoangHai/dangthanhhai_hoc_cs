using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class switch_case
    {
        static void Main()
        {
            int thu;
            Console.Write(" - MOI NHAP VAO THU : ");thu = int.Parse(Console.ReadLine());
            switch (thu)
            {
                case 2:
                    {
                        Console.WriteLine(" MONDAY !!!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("TUSEDAY !!!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("WENSSESDAY !!!");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("THURSDAY !!!");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("FRIDAY !!!");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("SATERDAY !!!");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("SUNDAY !!!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("NO NO NO  !!!");
                        break;
                    }
            }
        }
    }
}
