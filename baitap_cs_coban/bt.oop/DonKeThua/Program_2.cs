using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonKeThua
{
    internal class Program_2
    {
        class myDate
        {
            private int day;
            private int year;
            private int month;

            public myDate()
            {
                Year = 2002;
                Month = 5;
                Day = 7;
            }
            public myDate(int year, int month, int day)
            {
                this.Year = year;
                this.Month = month;
                this.Day = day;
            }

            public int Year { get => year; set => year = value; }
            protected int Month { get => month; set => month = value; }
            protected int Day { get => day; set => day = value; }
        }
        class perSon : myDate
        {
            protected string name, address, phone;
            public perSon()
            {
                name = "DANG THANH HAI";
                address = "THAI BINH";
                phone = "0387249999";
            }
            public perSon(string name, string address, string phone, int year, int month, int day) : base(year, month, day)
            {
                this.name = name;
                this.address = address;
                this.phone = phone;
            }
            public void InPut()
            {
                Console.Write("\n\t Nhap vao ten : "); name = Console.ReadLine();
                Console.Write("\n\t Nhap vao dia chi :"); address = Console.ReadLine();
                Console.Write("\n\t Nhap vao so dien thoai : "); phone = Console.ReadLine();
                Console.Write("\n\t Nhap vao ngay sinh :"); Day = int.Parse(Console.ReadLine());
                Console.Write("\n\t Nhap vao thang sinh :"); Month = int.Parse(Console.ReadLine());
                Console.Write("\n\t Nhap vao nam sinh :"); Year = int.Parse(Console.ReadLine());
            }
            public void OutPut()
            {
                Console.WriteLine("\n\t Name  = {0}\n\t Address = {1}\n\t Phone = {2}\n\t Ngay Sinh = {3,2}/{4,2}/{5,4}"
                    , name, address, phone, Day, Month, Year);
            }
        }
        static void Main()
        {
            perSon[] a = new perSon[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\n Nhap vao nguoi thu {i + 1} : ");
                a[i] = new perSon();
                a[i].InPut();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                a[i].OutPut();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (a[i].Year > a[j].Year)
                    {
                        perSon s = a[i];
                        a[i] = a[j];
                        a[j] = s;
                    }
                }
                a[i].OutPut();
            }
        }
    }
}
