using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_trong_cs
{
    internal class Program
    {
        // struct : là kiểu dữ liệu tham trị dùng đóng gói các trường dữ liệu khác nhau 
        // có thể lưu hàm ,kiểu dữ liệu ,struct khác 
        // struct : không được kế thừa .
        struct sinhVien
        {
            public int maSv;
            public string tenSv;
            public float diemToan, diemLy, diemHoa, diemTB;
        }
        // vì struct là kiểu dữ liệu tham trị khi truyền vào phương thức giá trị của nó không thay đổi
        // lên cần dùng từ out or ref để cập nhật lại giá trị thay đổi sau khi kết thúc 
        static void nhap(out sinhVien s)
        {
            Console.Write("\n\t - Nhap vao ma sinh vien : ");
            s.maSv = int.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhap vao ten sinh vien : ");
            s.tenSv = Console.ReadLine();
            Console.Write("\n\t - Nhap vao diem toan  sinh vien : ");
            s.diemToan = int.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhap vao diem ly sinh vien : ");
            s.diemLy = int.Parse(Console.ReadLine());
            Console.Write("\n\t - Nhap vao diem hoa sinh vien : ");
            s.diemHoa = int.Parse(Console.ReadLine());
            s.diemTB = (s.diemToan + s.diemLy + s.diemHoa) / 3;
        }
        static void xuat(sinhVien s)
        {
            Console.WriteLine("\n\t {0,10} {1,20} {2,10} {3,10} {4,10} {5,10} ",
                s.maSv, s.tenSv, s.diemToan, s.diemLy, s.diemHoa, s.diemTB);
        }

        static void Main(string[] args)
        {
            sinhVien s = new sinhVien();
            nhap(out s);
            xuat(s);
        }
    }
}
