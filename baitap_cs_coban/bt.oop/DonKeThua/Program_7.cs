using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonKeThua
{
    internal class Program_7
    {
        class HangHoa
        {
            protected string tenHang;
            protected double donGia;
            protected string maHang;

            public string MaHang { get => maHang; set => maHang = value; }
            public string TenHang { get => tenHang; set => tenHang = value; }

            public HangHoa()
            {
                MaHang = "MAO01";
                TenHang = "MAY TINH";
                donGia = 15000;
            }
            public HangHoa(string maHang, string tenHang, double donGia)
            {
                this.MaHang = maHang;
                this.TenHang = tenHang;
                this.donGia = donGia;
            }
            ~HangHoa() { }
            public void InPut()
            {
                Console.Write("\n\t - Nhập vào mã máy tính : "); MaHang = Console.ReadLine();
                Console.Write("\n\t - Nhập vào tên máy tính xách tay : "); TenHang = Console.ReadLine();
                Console.Write("\n\t - Nhập vào đơn giá máy tính xách tay : "); donGia = double.Parse(Console.ReadLine());
            }
            public void OutPut()
            {
                Console.Write("\t|{0,15} |{1,25} |{2,15} $ |", MaHang.ToUpper().Trim(), TenHang.ToUpper().Trim(), donGia);
            }
        }
        class MayTinh : HangHoa
        {
            protected float tocDo;
            protected int soLuong;

            public float TocDo { get => tocDo; set => tocDo = value; }

            public MayTinh()
            {
                TocDo = 20.5f;
                soLuong = 100;
            }
            public MayTinh(string maHang, string tenHang, double donGia, float tocDo, int soLuong) : base(maHang, tenHang, donGia)
            {
                this.TocDo = tocDo;
                this.soLuong = soLuong;
            }
            ~MayTinh() { }
            public new void InPut()
            {
                base.InPut();
                Console.Write("\n\t - Nhập vào tốc độ máy tính: "); TocDo = float.Parse(Console.ReadLine());
                Console.Write("\n\t - Nhập vào số lượng máy tính: "); soLuong = int.Parse(Console.ReadLine());
            }
            public double thanhTien()
            {
                return soLuong * donGia;
            }
            public new void OutPut()
            {
                base.OutPut();
                Console.Write("{0,15}/s |{1,15} |{2,15} $ |", TocDo, soLuong, thanhTien());
            }
        }
        class MayTinhXachtay : MayTinh
        {
            protected float trongLuong;
            public MayTinhXachtay()
            {
                trongLuong = 2.5f;
            }
            public MayTinhXachtay(string maHang, string tenHang, double donGia, float tocDo, int soLuong, float trongLuong)
            : base(maHang, tenHang, donGia, tocDo, soLuong)
            {
                this.trongLuong = trongLuong;
            }
            ~MayTinhXachtay() { }
            public new void InPut()
            {
                base.InPut();
                Console.Write("\n\t - Nhập vào trọng lượng máy tính : "); trongLuong = float.Parse(Console.ReadLine());
            }
            public double phiBaoTri()
            {
                return Math.Round((donGia * 0.05f), 3);
            }
            public new void OutPut()
            {
                base.OutPut();
                Console.WriteLine("{0,15} kg |{1,15} $ |" +
                    "\n\t+============================================================================================================================================================+"
                    , trongLuong, phiBaoTri());
            }
        }
        static void Nhap(MayTinhXachtay[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n  [+] Nhập Vào Máy Tính Thứ [{i + 1}] : ");
                a[i] = new MayTinhXachtay();
                a[i].InPut();
            }
        }
        static void TieuDe()
        {
            Console.WriteLine("\t+============================================================================================================================================================+" +
                "\n\t|{0,15} |{1,25} |{2,15}   |{3,15}   |{4,15} |{5,15}   |{6,15}    |{7,15}   |" +
                "\n\t+============================================================================================================================================================+"
                , "MÃ LAPTOP", "TÊN LAPTOP", "ĐƠN GIÁ", "TỐC ĐỘ", "SỐ LƯỢNG", "THÀNH TIỀN", "TRỌNG LƯỢNG", "PHÍ BẢO TRÌ");
        }
        static void Xuat(MayTinhXachtay[] a, int n)
        {
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                a[i].OutPut();
            }
        }
        static void TimTheoMa(MayTinhXachtay[] a, int n, bool kiemTra = false)
        {
        tiepTuc:
            Console.Write("\n\t - Nhập vào mã máy tính Cần tìm kiếm : "); string maTimKiem = Console.ReadLine();
            Console.WriteLine("\n\t\t\t\t\t\t[=] MÁY TÍNH XÁCH TAY ĐƯỢC TÌM THEO MÃ MÁY TÍNH LÀ [=]");
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                if (a[i].MaHang.ToUpper().Trim() == maTimKiem.ToUpper().Trim())
                {
                    kiemTra = true;
                    a[i].OutPut();
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t\t\t ----->   MÃ MÁY TÍNH HIỆN TẠI KHÔNG CÓ TRONG DANH SÁCH !!!!");
                goto tiepTuc;
            }
        }
        static void TimTheoTen(MayTinhXachtay[] a, int n, bool kiemTra = false)
        {
        tiepTuc:
            Console.Write("\n\t - Nhập vào tên máy tính Cần tìm kiếm : "); string tenTimKiem = Console.ReadLine();
            Console.WriteLine("\n\t\t\t\t\t\t[=] MÁY TÍNH XÁCH TAY ĐƯỢC TÌM THEO TÊN MÁY TÍNH LÀ [=]");
            TieuDe();
            for (int i = 0; i < n; i++)
            {
                if (a[i].TenHang.ToUpper().Trim() == tenTimKiem.ToUpper().Trim())
                {
                    kiemTra = true;
                    a[i].OutPut();
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t\t\t ----->   TÊN MÁY TÍNH HIỆN TẠI KHÔNG CÓ TRONG DANH SÁCH !!!!");
                goto tiepTuc;
            }
        }
        static void TinhTongBaoTri(MayTinhXachtay[] a, int n)
        {
            Console.WriteLine("\n\t\t\t\t\t\t[=] TÍNH TỔNG TIỀN BẢO TRÌ CỦA MÁY TÍNH TRONG DANH SÁCH [=]");
            double SUM = 0;
            for (int i = 0; i < n; i++)
            {
                SUM += a[i].phiBaoTri();
            }
            Console.WriteLine("\n\t\t\t\t\t ----->   TỔNG TIỀN BẢO TRÌ CỦA TẤT CẢ MÁY TÍNH TRONG DANH SÁCH LÀ : " + SUM + " $");
        }
        static void TimMax(MayTinhXachtay[] a, int n)
        {
            MayTinhXachtay max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max.TocDo > a[i].TocDo)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("\n\t\t\t\t\t\t[=] MÁY TÍNH ĐẠT TỐC ĐỘ NHỎ NHẤT TRONG DANH SÁCH LÀ  [=]");
            TieuDe();
            max.OutPut();
        }
        static void sapXepTang(MayTinhXachtay[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].MaHang.Length > a[j].MaHang.Length)
                    {
                        MayTinhXachtay tmg = a[i];
                        a[i] = a[j];
                        a[j] = tmg;
                    }
                }
            }
            Console.WriteLine("\n\t\t\t\t\t\t[=] DANH SÁCH SẮP XẾP TĂNG DẦN THEO MÃ MÁY TÍNH LAPTOP LÀ  [=]");
            Xuat(a, n);
        }
        static void XoaTheoMa(MayTinhXachtay[] a, int n, bool kiemTra = false)
        {
        tiepTuc:
            Console.Write("\n\t - Nhập vào Mã máy tính cần xóa : "); string maXoa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (a[i].MaHang.Trim().ToUpper() == maXoa.Trim().ToUpper())
                {
                    n--;
                    kiemTra = true;
                    a[i] = a[i + 1];
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t\t\t ----->   MÃ MÁY TÍNH MỚI NHẬP  KHÔNG CÓ TRONG DANH SÁCH !!!!");
                goto tiepTuc;
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\t\t[=] DANH SÁCH SAU KHI XÓA MÁY TÍNH THEO MÃ NHẬP VÀO LÀ [=]");
                Xuat(a, n);
            }
        }
        static void Chen(MayTinhXachtay[] a, int n, bool kiemTra = false)
        {
            MayTinhXachtay mt = new MayTinhXachtay();
            Console.WriteLine("\n[+] Nhập vào máy tính cần chèn theo mã : "); mt.InPut();
            for (int i = 0; i < n; i++)
            {
                if (a[i].MaHang.Trim().ToUpper() == mt.MaHang.Trim().ToUpper())
                {
                    kiemTra = true;
                    Console.WriteLine("\n\t\t\t\t\t ----->   MÃ MÁY TÍNH MỚI NHẬP CÓ TRONG DANH SÁCH RỒI Ạ !!!!");
                    break;
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t\t  -----> CHƯA CÓ MÃ MÁY TÍNH NÀY TRONG DANH SÁCH !! MỜI CHÈN !!");
                n++;
                Console.Write("\n\t - Nhập vào vị trí cần chèn : "); int k = int.Parse(Console.ReadLine());
                for (int i = n; i >= k; i--)
                    a[i] = a[i - 1];
                /* chen gia tri vao vi tri da cho */
                a[k - 1] = mt;
                Console.WriteLine("\n\t\t\t\t\t\t[=] DANH SÁCH CÁC LOẠI MÁY TÍNH SAU KHI CHÈN THÊM LÀ [=]");
                Xuat(a, n);
            }
        }
        static void SuaTocDoTheoMa(MayTinhXachtay[] a, int n, bool kiemTra = false)
        {
        onon:
            Console.Write("\n\t[+] Nhập vào mã máy tính để xem : "); string maSua = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (maSua.Trim().ToUpper() == a[i].MaHang.Trim().ToUpper())
                {
                    kiemTra = true;
                    Console.Write($"\n\t - Sửa Lại Thông Tin Tốc Độ Của máy tính thứ [{i + 1}] : ");
                    a[i].TocDo = float.Parse(Console.ReadLine()); break;
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("\n\t\t\t\t  -----> CHƯA CÓ MÃ MÁY TÍNH NÀY TRONG DANH SÁCH !! NHẬP LẠI  !!");
                goto onon;
            }
        }
        static void MENU(MayTinhXachtay[] a, int n)
        {
            int luachon;
            while (true)
            {
                Console.WriteLine("\n\t- 1 Hiển thị danh sách " +
                                        "\n\t- 2 Tìm thông tin máy tính xách tay theo mã máy nhập vào từ bàn phím." +
                                        "\n\t- 3 Liệt kê máy tính xách tay theo tên." +
                                        "\n\t- 4 Tính tổng phí bảo trì của các máy tính." +
                                        "\n\t- 5 Tìm máy tính xách tay có tốc độ nhỏ nhất." +
                                        "\n\t- 9 Sửa thông tin một máy tính xách tay." +
                                        "\n\t- 6 Xóa một máy tính xách tay theo mã cho trước." +
                                        "\n\t- 8 Chèn thêm một máy tính xách tay tại vị trí k. (k nhập từ bàn phím)" +
                                        "\n\t- 7 Sắp xếp danh sách theo chiều tăng dần của mã máy." +
                                        "\n\t- 0 Thoát ");
                Console.Write("\n\t-->> Nhập Vào Lựa Chọn Của Bạn : ");
                do
                {
                    luachon = int.Parse(Console.ReadLine());
                    if (luachon > 9 || luachon < 0)
                    {
                        Console.WriteLine("\n\t-->> Nhập Lại Lựa Chọn Của Bạn : ");
                    }
                } while ((luachon > 9 || luachon < 0));
                if (luachon == 1)
                {
                    Console.WriteLine("\n\t\t\t\t\t\t[=] DANH SÁCH CÁC LOẠI MÁY TÍNH XÁCH TAY MỚI NHẬP VỀ LÀ [=]");
                    Xuat(a, n);
                }
                if (luachon == 2)
                {
                    TimTheoMa(a, n);
                }
                if (luachon == 3)
                {
                    TimTheoTen(a, n);
                }
                if (luachon == 4)
                {
                    TinhTongBaoTri(a, n);
                }
                if (luachon == 5)
                {
                    TimMax(a, n);
                }
                if (luachon == 6)
                {
                    XoaTheoMa(a, n);
                }
                if (luachon == 7)
                {
                    sapXepTang(a, n);
                }
                if (luachon == 8)
                {
                    Chen(a, n);
                }
                if (luachon == 9)
                {
                    SuaTocDoTheoMa(a, n);
                    Console.WriteLine("\n\t\t\t\t\t\t[=] DANH SÁCH CÁC LOẠI MÁY TÍNH XÁCH TAY SAU KHI SỬA TỐC ĐỘ LÀ [=]");
                    Xuat(a, n);
                }
                if (luachon == 0)
                {
                    Console.WriteLine("\n\t\t--------------------------- THOÁT -----------------------------");
                    break;
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("->> Nhập Vào Số Lượng Máy Tính Xách Tay : "); int n = int.Parse(Console.ReadLine());
            MayTinhXachtay[] a = new MayTinhXachtay[10];
            Nhap(a, n);
            Console.Clear();
            MENU(a, n);
            Console.ReadLine();
        }
    }
}
