using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_2oop
{
    internal class Sinh_Vien
    {
        private string soBaoDanh, hoTen;
        private float diemToan, diemLy, diemHoa;
        public Sinh_Vien()
        {
            soBaoDanh = "ma1";
            hoTen = "dang thanh hai";
            diemToan = 9f;
            diemLy = 9f;
            diemHoa = 9f;
        }
        public Sinh_Vien(string soBaoDanh, string hoTen, float diemToan, float diemLy, float diemHoa)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoTen = hoTen;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
        }
        public void InPut()
        {
            Console.Write("\n\t - Nhập vào số bao danh : "); soBaoDanh = Console.ReadLine();
            Console.Write("\n\t - Nhập vào họ và tên : "); hoTen = Console.ReadLine();
            Console.Write("\n\t - Nhập vào điểm toán : "); diemToan = int.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhập vào điểm lý : "); diemLy = int.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhập vào điểm hóa : "); diemHoa = int.Parse(Console.ReadLine());
        }
        public float tongDiem()
        {
            return diemToan + diemLy + diemHoa;
        }
        public void OutPut()
        {
            Console.WriteLine("\t| {0,15} | {1,25} | {2,10} đ | {3,10} đ | {4,10} đ | {5,10} đ |" +
                "\n\t+---------------------------------------------------------------------------------------------------------+"
                , soBaoDanh, hoTen, diemToan, diemLy, diemHoa, tongDiem());
        }
        static void Nhap(Sinh_Vien[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - Nhập vào sinh viên thứ +[{i + 1}]+ !!! ");
                a[i] = new Sinh_Vien();
                a[i].InPut();
            }
        }
        static void HAM()
        {
            Console.WriteLine("\n\t+---------------------------------------------------------------------------------------------------------+" +
                "\n\t| {0,15} | {1,25} | {2,10}   | {3,10}   | {4,10}   | {5,10}   |" +
                "\n\t+---------------------------------------------------------------------------------------------------------+"
                , "SỐ TT", "HỌ TÊN", "TOÁN", "LÝ", "HÓA", "TỔNG");
        }
        static void Xuat(Sinh_Vien[] a, int n)
        {
            HAM();
            for (int i = 0; i < n; i++)
            {
                a[i].OutPut();
            }
        }
        static void TimKiem(Sinh_Vien[] sv, int n, bool kiemTra)
        {
            Console.WriteLine("\n\t\t\t\t DANH SÁCH SINH VIÊN ĐẠT TIÊU CHUẨN "); HAM();
            for (int i = 0; i < n; i++)
            {
                if (sv[i].tongDiem() >= 20)
                {
                    sv[i].OutPut();
                    kiemTra = true;
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t-----> KHÔNG CÓ SINH VIÊN NÀO ĐẠT CẢ !!!!");
            }
        }
        static void MAX(Sinh_Vien[] sv, int n)
        {
            Sinh_Vien max = sv[0];
            for (int i = 0; i < n; i++)
            {
                if (max.tongDiem() <= sv[i].tongDiem())
                {
                    max = sv[i];
                }
            }
            Console.WriteLine("\n\t\t\t\t SINH VIÊN ĐỖ THỦ KHOA LÀ !!");
            HAM();
            max.OutPut();
        }
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.OutputEncoding = Encoding.Unicode;
            bool kiemTra = false;
            Console.Write(" - Nhập vào số lượng thí sinh dự thi : "); int n = int.Parse(Console.ReadLine());
            Sinh_Vien[] sv = new Sinh_Vien[n];
            Nhap(sv, n);
            Console.Write("\n\t\t\t\t DANH SÁCH SINH VIÊN VỪA NHẬP LÀ ");
            Xuat(sv, n);
            TimKiem(sv, n, kiemTra);
            MAX(sv, n);
            Console.ReadLine();
        }
    }
}
