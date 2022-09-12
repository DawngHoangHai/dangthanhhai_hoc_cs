using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_trong_cs
{
    internal class enum_cs
    {
        /* kiến thức cơ bản ref :
         * sẽ được sử dụng trực tiếp giá trị mà sau đó truyền vào mà không copy ra vùng nhớ khác
         * khi truyền hoặc sửa dữ liệu của hàm hay tham trị  ta cần thêm từ khóa ref để lấy luôn dữ liệu vùa dùng 
         * 
         * dùng ref khi là biến, không được truyền vào là hằng 
         * có thể có nhiều từ khóa ref trong lời khai báo hàm 
         * 
         * phải khởi tạo biến trước khi mà sử dụng ref 
         */
        static void tangDem(ref int dem, ref int tru)
        {
            dem++;
            tru--;
        }
        static void Main()
        {
            int dem = 5;
            int tru = 10;
            Console.WriteLine($" -> Dem truyen vao la : {dem} , {tru}");
            tangDem(ref dem, ref tru);
            Console.WriteLine($" - > Dem sau khi tang co ref la : {dem}, {tru}");
            TANGDEM(out dem, ref tru);
            Console.WriteLine($" - > Dem sau khi tang co ref la : {dem}, {tru}");
        }
        /* biến truyền vào có từ khóa out không cần phải khởi tạo 
         * coi như là nơi để giá trị trả về k cần biết giá trị ban đầu là bao nhiêu */
        static void TANGDEM(out int dem, ref int tru) // có thể truyền ref và out cùng một lúc 
        {
            dem = 0;// trong hàm mà sử dụng từ  khóa out phải khởi tạo hoặc gán
            dem++;
        }

    }
}
