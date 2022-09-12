using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_output
{
    internal class nhap_xuat
    {
        static void Main(string[] args)
        {
            string hoTen;
            int age;
            float diemToan,diemLy,diemHoa;
            Console.Write(" Nhap vao ho ten :");hoTen = Console.ReadLine();
            Console.Write(" Nhap vao tuoi :"); age = System.Int32.Parse(Console.ReadLine());
            Console.Write(" Nhap diem toan cua ban :");diemToan = System.Single.Parse(Console.ReadLine());
            Console.Write(" Nhap diem ly cua ban :"); diemLy = System.Single.Parse(Console.ReadLine());
            Console.Write(" Nhap diem hoa cua ban :"); diemHoa = System.Single.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($" Ho VA Ten : {hoTen} ");
            Console.WriteLine($" KI TU HO Ten co : {hoTen.Length} ");
            Console.WriteLine($" Tuoi ban la: {age} Tuoi" );
            Console.WriteLine(" Diem Trung Binh :" + ((diemToan + diemLy + diemHoa) / 3) + " Diem ");
            Console.WriteLine(" Diem Trung Binh : {0}", ((diemToan + diemLy + diemHoa) / 3) + " Diem ");
            Console.WriteLine($" Diem Trung Binh  = ({diemToan} + {diemLy} + {diemHoa})/3 = {((diemToan + diemLy + diemHoa) / 3)}");
            Console.ReadKey();
            // có thể xuat bằng nhiều cách :cách 3 là tối ưu nhất .

        }
    }
}
