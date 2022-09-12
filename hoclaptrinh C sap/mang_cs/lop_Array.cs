using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang_cs
{
    internal class lop_Array
    {
        static void Main()
        {
            // sắp xếp từ nhỏ đến lớn : Array.Sort<tên mảng>
            int[] numbers = { 4, 6, 2, 8, 9, 10, 1 };
            Array.Sort(numbers);

            // đảo các phần tử trong mảng : Array.Reverse<tên mảng>
            Array.Reverse(numbers);
            foreach (var i in numbers)
            {
                Console.Write(" {0,5} ", i);
            }
            // xóa bộ nhớ trong mảng : Array.Clear(<tên mang>, <vị trí bắt đầu xóa>, <số lượng xóa>)
            Array.Clear(numbers, 0, 1);
            Console.WriteLine();
            foreach (var i in numbers)
            {
                Console.Write(" {0,5} ", i);
            }
        }
    }
}
