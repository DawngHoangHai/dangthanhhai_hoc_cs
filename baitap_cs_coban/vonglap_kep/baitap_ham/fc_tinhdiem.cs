using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_ham
{
    internal class fc_tinhdiem
    {
        public static string hoTen;
        public static float diemToan, diemHoa, diemLy;
        static void inPut()
        {
            Console.Write(" - NHập vào họ tên : "); hoTen = (Console.ReadLine());
            Console.Write(" - NHập vào điểm toán : "); diemToan = float.Parse(Console.ReadLine());
            Console.Write(" - NHập vào điểm hóa : "); diemHoa = float.Parse(Console.ReadLine());
            Console.Write(" - NHập vào điểm lý : "); diemLy = float.Parse(Console.ReadLine());
        }
        static void outPut()
        {
            float diemTB = (diemToan + diemLy + diemHoa) / 3;
            Console.WriteLine("\t\t DANH SÁCH SINH VIÊN VỪA NHẬP VÀO LÀ \n");
            Console.WriteLine("\t+--------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("\t| {0,25}  | {1,15}  | {2,15}  | {3,15}  |  {4,15} |",
                "Họ Tên", "Điểm Toán", "Điểm lý", "Điểm Hóa", "Điểm Trung Bình");
            Console.WriteLine("\t+--------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("\t| {0,25}  | {1,15}  | {2,15}  | {3,15}  |  {4,15} |",
                hoTen.ToUpper(), diemToan, diemLy, diemHoa, diemTB);
            Console.WriteLine("\t+--------------------------------------------------------------------------------------------------------+");
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            inPut();
            outPut();
        }
    }
}
