using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    internal class Program_1
    {
        class DocGia
        {
            protected string maDocGia, tenDocGia;
            protected int soThangHieuLuc;
            public virtual void Nhap()
            {
                Console.Write("\n\t - Nhập vào mã độc giả : "); maDocGia = Console.ReadLine().Trim();
                Console.Write("\n\t - Nhập vào tên độc giả : "); tenDocGia = Console.ReadLine().Trim();
                Console.Write("\n\t - Nhập vào số tháng có hiệu lực : "); soThangHieuLuc = int.Parse(Console.ReadLine());
            }
            public virtual void Xuat()
            {
                Console.WriteLine("\n - Mã Độc Giả : {0}\n - Tên Độc Giả : {1}\n - Số Tháng Có Hiệu Lực : {2}", maDocGia, tenDocGia, soThangHieuLuc);
            }
            public virtual double TinhTienThe()
            {
                return 0;
            }
            public virtual int TimKiem()
            {
                return 0;
            }
        }
        class DoGiaTreEm : DocGia
        {
            protected int namSinh;
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("\n\t - Nhập vào năm sinh : "); namSinh = int.Parse(Console.ReadLine().Trim());
            }
            public override double TinhTienThe()
            {
                return soThangHieuLuc * 20000;
            }
            public override int TimKiem()
            {
                if (soThangHieuLuc <= 10)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine(" - Năm Sinh : {0}\n - Tiền Thẻ {1} vnđ", namSinh, TinhTienThe());
            }
        }
        class DoGiaNguoiLon : DocGia
        {
            protected string ngheNghiep;
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("\n\t - Nhập vào nghề nghiệp : "); ngheNghiep = (Console.ReadLine().Trim());
            }
            public override double TinhTienThe()
            {
                return soThangHieuLuc * 30000;
            }
            public override int TimKiem()
            {
                if (ngheNghiep.Trim().ToUpper() == "GIANG VIEN")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine(" - Nghề NGhiệp : {0}\n - Tiền Thẻ {1} vnđ", ngheNghiep, TinhTienThe());
            }
        }
        static void OutPut(DocGia[] a, int n)
        {
            Console.WriteLine("\n DANH SÁCH 2 ĐỘC GIẢ VỪA LƯU LÀ !!!!");
            for (int j = 0; j < n; j++)
            {
                a[j].Xuat();
            }
        }
        static void Check(DocGia[] a, int n)
        {
            Console.WriteLine("\n ĐỘC GIẢ TRẺ EM CÓ SỐ THÁNG HIỆU LỰC < 10 VÀ NGƯỜI LỚN LÀ GIẢNG VIÊN ");
            for (int j = 0; j < n; j++)
            {
                if (a[j].TimKiem() == 1)
                {
                    a[j].Xuat();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DocGia[] a = new DocGia[10];
            int i = 0, luaChon, n = 0, SUM = 0;
            while (true)
            {
                Console.WriteLine("\n\t 1. ĐỘC GIẢ TRẺ EM \n\t 2. ĐỘC GIẢ NGƯỜI LỚN \n\t 3. DỪNG NHẬP ");
                Console.Write("\n\t - Nhập vào lựa chọn của bạn : ");
                do
                {
                    luaChon = int.Parse(Console.ReadLine());
                    if (luaChon > 3 || luaChon < 1)
                    {
                        Console.Write("\n\t - Nhập lại lựa chọn của bạn : ");
                    }
                } while (luaChon > 3 || luaChon < 1);
                if (luaChon == 1)
                {
                    a[i] = new DoGiaTreEm();
                    Console.WriteLine($"\n - Nhập vào Độc Giả Trẻ Em thứ [{i + 1}] : ");
                }
                if (luaChon == 2)
                {
                    a[i] = new DoGiaNguoiLon();
                    Console.WriteLine($"\n - Nhập vào Độc Giả Người Lớn thứ [{i + 1}] : ");
                }
                if (luaChon == 3)
                {
                    Console.WriteLine("\n\t Bạn Dừng Nhập Dữ Liệu !!!!"); break;
                }
                a[i].Nhap();
                SUM += (int)a[i].TinhTienThe();
                i++;
                n = i;
            }
            OutPut(a, n);
            Console.WriteLine("\n\t -------> TỔNG TIỀN THẺ CỦA TẤT CẢ ĐỘC GIẢ LÀ : " + SUM + " vnđ");
            Check(a, n);
        }
    }
}
