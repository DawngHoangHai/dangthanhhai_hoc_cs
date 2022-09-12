using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{
    internal class Program_5
    {
        class Internet
        {
            protected string hoTen, queQuan;
            protected int namSinh, thueBaoThang;
            protected string thueBao;
            public string ThueBao
            { get => thueBao; set => thueBao = value; }
            public virtual void InPut()
            {
                Console.Write("\n\t - Nhập vào họ tên khách hàng : "); hoTen = Console.ReadLine().Trim().ToUpper();
                Console.Write("\n\t - Nhập vào quê quán khách hàng : "); queQuan = Console.ReadLine().Trim().ToUpper();
                Console.Write("\n\t - Nhập vào năm sinh khách hàng : "); namSinh = int.Parse(Console.ReadLine());
            }
            public virtual double TienThueBao()
            {
                return 0;
            }
            public virtual void OutPut()
            {
                Console.Write("\t|{0,25} |{1,25} |{2,15} |", hoTen, queQuan, namSinh);
            }
        }
        class Dial_Up : Internet
        {
            protected float soPhut;
            public override void InPut()
            {
                base.InPut();
                ThueBao = "DIAL UP";
                Console.Write("\n\t - Nhập vào số phút sử dụng : "); soPhut = float.Parse(Console.ReadLine().Trim());
                thueBaoThang = 30000;
            }
            public override double TienThueBao()
            {
                return (soPhut * 30) + thueBaoThang;
            }
            public override void OutPut()
            {
                base.OutPut();
                Console.WriteLine("{0,25} |{1,15} '  |{2,15}$ |{3,15}$ |" +
                    "\n\t+=========================================================================================================================================================+"
                    , ThueBao, soPhut, thueBaoThang, TienThueBao());
            }
        }
        class ADSL : Internet
        {
            protected float dungLuong;
            public override void InPut()
            {
                base.InPut();
                ThueBao = "ADSL";
                Console.Write("\n\t - Nhập vào dung lượng sử dụng : "); dungLuong = float.Parse(Console.ReadLine().Trim());
                thueBaoThang = 50000;
            }
            public override double TienThueBao()
            {
                return (dungLuong * 50) + thueBaoThang;
            }
            public override void OutPut()
            {
                base.OutPut();
                Console.WriteLine("{0,25} |{1,15} MB |{2,15}$ |{3,15}$ |" +
                    "\n\t+=========================================================================================================================================================+"
                    , ThueBao, dungLuong, thueBaoThang, TienThueBao());
            }
        }
        class T1 : Internet
        {
            public override void InPut()
            {
                base.InPut();
                ThueBao = "T1";
                thueBaoThang = 2000000;
            }
            public override double TienThueBao()
            {
                return thueBaoThang;
            }
            public override void OutPut()
            {
                base.OutPut();
                Console.WriteLine("{0,25} |{1,15}    |{2,15}$ |{3,15}$ |" +
                    "\n\t+=========================================================================================================================================================+"
                    , ThueBao, "không có", thueBaoThang, TienThueBao());
            }
        }
        static void TieuDe()
        {
            Console.WriteLine("\t+=========================================================================================================================================================+" +
                "\n\t|{0,25} |{1,25} |{2,15} |{3,25} |{4,15}    |{5,15}  |{6,15}  |" +
                "\n\t+=========================================================================================================================================================+"
                , "HỌ TÊN", "QUÊ QUÁN", "NĂM SINH", "THUÊ BAO", "PHÚT or MB", "TIỀN THÁNG", "TỔNG");
        }
        class QuanLyMang
        {
            Internet[] a = new Internet[10];
            int n;
            public void input()
            {
                int luaChon;
                for (int i = 0; ;)
                {
                    Console.WriteLine("\n\t [+] 1.THUÊ BAO DIAL UP , 2.THUÊ BAO ADSL , 3.THUÊ BAO T1 , 4.DỪNG NHẬP !!");
                    Console.Write("\t - Mời Nhập Vào Lựa Chọn Của Bạn : ");
                    do
                    {
                        luaChon = int.Parse(Console.ReadLine());
                        if (luaChon > 4 || luaChon < 1)
                        {
                            Console.Write("\t - Mời Nhập Lại Lựa Chọn Của Bạn : ");
                        }
                    } while (luaChon > 4 || luaChon < 1);
                    if (luaChon == 1)
                    {
                        Console.WriteLine($"\n - Nhập Vào Thuê Bao Dial Up [{i + 1}] : ");
                        a[i] = new Dial_Up();
                    }
                    if (luaChon == 2)
                    {
                        Console.WriteLine($"\n - Nhập Vào Thuê Bao ADSL [{i + 1}] : ");
                        a[i] = new ADSL();
                    }
                    if (luaChon == 3)
                    {
                        Console.WriteLine($"\n - Nhập Vào Thuê Bao T1 [{i + 1}] : ");
                        a[i] = new T1();
                    }
                    if (luaChon == 4)
                    {
                        Console.WriteLine($"\n\t ------------- Dừng Nhập ------------------");
                        break;
                    }
                    a[i].InPut();
                    i++;
                    n = i;
                }
            }
            public void output()
            {
                TieuDe();
                for (int i = 0; i < n; i++)
                {
                    a[i].OutPut();
                }
            }
            public void TongTungLoai()
            {
                double Sum1, Sum2, Sum3;
                Sum1 = Sum2 = Sum3 = 0;
                for (int i = 0; i < n; i++)
                {
                    if (a[i].ThueBao == "DIAL UP")
                    {
                        Sum1 += a[i].TienThueBao();
                    }
                    if (a[i].ThueBao == "ADSL")
                    {
                        Sum2 += a[i].TienThueBao();
                    }
                    if (a[i].ThueBao == "T1")
                    {
                        Sum3 += a[i].TienThueBao();
                    }
                }
                Console.WriteLine("\n\t\t\t\t--->> Tổng Tiền Của Thuê Bao DIAL UP Trong Tháng Là = " + Sum1);
                Console.WriteLine("\n\t\t\t\t--->> Tổng Tiền Của Thuê Bao ADSL Trong Tháng Là = " + Sum2);
                Console.WriteLine("\n\t\t\t\t--->> Tổng Tiền Của Thuê Bao T1 Trong Tháng Là = " + Sum3);
            }
            public void TongCacLoai()
            {
                double SUM = default;
                for (int i = 0; i < n; i++)
                {
                    SUM += a[i].TienThueBao();
                }
                Console.WriteLine("\n\t\t\t\t--->> Tổng Tiền Của Tất Cả Thuê Bao Trong Tháng Là = " + SUM);
            }
            public void TimMaxADSL()
            {
                Internet max = a[0];
                for (int i = 0; i < n; i++)
                {
                    if (a[i].ThueBao == "ADSL")
                    {
                        if (max.TienThueBao() < a[i].TienThueBao())
                        {
                            max = a[i];
                        }
                    }
                }
                Console.WriteLine("\n\t\t\t\t\t\t(+)  GÓI THUÊ BAO ADSL ĐƯỢC DÙNG TRONG THÁNG CAO NHẤT (+)");
                TieuDe();
                max.OutPut();
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            QuanLyMang a = new QuanLyMang();
            a.input();
            Console.WriteLine("\n\t\t\t\t\t\t(+) DANH SÁCH CÁC GÓI THUÊ BAO ĐƯỢC DÙNG TRONG THÁNG (+)");
            a.output();
            a.TongTungLoai();
            a.TimMaxADSL();
            Console.ReadLine();
        }
    }
}
