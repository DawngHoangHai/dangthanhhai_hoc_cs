using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    internal class ThongTinNhaDat
    {
        struct Date
        {
            public int ngay, thang, nam;
        }
        class NhaDat
        {
            protected string maGiaoDich;
            protected Date ngayGiaoDich;
            protected float donGia, dienTich;
            public virtual void InPut()
            {
                Console.Write("\n\t - Nhập vào mã giao dịch : "); maGiaoDich = Console.ReadLine().Trim().ToUpper();
                Console.Write("\n\t - Nhập vào ngày giao dịch : "); ngayGiaoDich.ngay = int.Parse(Console.ReadLine().Trim());
                Console.Write("\n\t - Nhập vào tháng giao dịch : "); ngayGiaoDich.thang = int.Parse(Console.ReadLine().Trim());
                Console.Write("\n\t - Nhập vào năm giao dịch : "); ngayGiaoDich.nam = int.Parse(Console.ReadLine().Trim());
            }
            public virtual double ThanhTien()
            {
                return 0;
            }
            public virtual void OutPut()
            {
                Console.Write("\t|{0,15} |  {1,2}/{2,2}/{3,4} |", maGiaoDich, ngayGiaoDich.ngay, ngayGiaoDich.thang, ngayGiaoDich.nam);
            }
        }
        class GiaoDichDat : NhaDat
        {
            protected string loaiDat;
            public override void InPut()
            {
                int luaChon;
                base.InPut();
                Console.WriteLine("\n\t[+] 1.Loại Đất A , 2.Loại Đất B [+]");
                Console.Write("\n\t - Nhập vào lựa chon : ");
                do
                {
                    luaChon = int.Parse(Console.ReadLine());
                    if (luaChon < 1 || luaChon > 2)
                    {
                        Console.Write("\n\t - Nhập lại lựa chon : ");
                    }
                } while (luaChon < 1 || luaChon > 2);
                if (luaChon == 1)
                {
                    loaiDat = "A";
                }
                else
                {
                    loaiDat = "B";
                }
                Console.Write("\n\t - Nhập vào diện tích : "); dienTich = float.Parse(Console.ReadLine());
                Console.Write("\n\t - Nhập vào đơn giá : "); donGia = float.Parse(Console.ReadLine());
            }
            public override double ThanhTien()
            {
                if (loaiDat == "A")
                {
                    return dienTich * donGia * 1.5;
                }
                else
                {
                    return dienTich * donGia;
                }
            }
            public override void OutPut()
            {
                base.OutPut();
                Console.WriteLine("{0,15} |{1,10} ha |{2,15} đ |{3,15} đ |" +
                    "\n\t+====================================================================================================+"
                    , loaiDat, dienTich, donGia, ThanhTien());
            }
        }
        class GiaoDichNha : NhaDat
        {
            protected string loaiNha;
            public override void InPut()
            {
                int luaChon;
                base.InPut();
                Console.WriteLine("\n\t[+] 1.Nhà Cao Cấp  , 2.Nhà Bình Thường [+]");
                Console.Write("\n\t - Nhập vào lựa chon : ");
                do
                {
                    luaChon = int.Parse(Console.ReadLine());
                    if (luaChon < 1 || luaChon > 2)
                    {
                        Console.Write("\n\t - Nhập lại lựa chon : ");
                    }
                } while (luaChon < 1 || luaChon > 2);
                if (luaChon == 1)
                {
                    loaiNha = "CAO CAP";
                }
                else
                {
                    loaiNha = "BINH THUONG";
                }
                Console.Write("\n\t - Nhập vào diện tích : "); dienTich = float.Parse(Console.ReadLine());
                Console.Write("\n\t - Nhập vào đơn giá : "); donGia = float.Parse(Console.ReadLine());
            }
            public override double ThanhTien()
            {
                if (loaiNha == "CAO CAP")
                {
                    return dienTich * donGia;
                }
                else
                {
                    return dienTich * donGia * 0.9;
                }
            }
            public override void OutPut()
            {
                base.OutPut();
                Console.WriteLine("{0,15} |{1,10} m2 |{2,15} đ |{3,15} đ |" +
                    "\n\t+====================================================================================================+"
                    , loaiNha, dienTich, donGia, ThanhTien());
            }
            static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                NhaDat a = new GiaoDichNha();
                a.InPut();
                a.OutPut();
                Console.ReadLine();
            }
        }
    }
}
