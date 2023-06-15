using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.AddDemoData();

            do
            {

                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1: Nhap danh sach");
                Console.WriteLine("2: Xuat danh sach");
                Console.WriteLine("3: Tim theo so chan");
                Console.WriteLine("4: Xoa theo ID");
                Console.WriteLine("5: Sap xep danh sach theo ten loai");
                Console.WriteLine("6: Ke thua");
                Console.WriteLine("7: Update by ID");



                Console.WriteLine("0: Thoat");

                string str = Console.ReadLine();
                if (str.Trim() == "0")
                {
                    break;
                }

                switch (str)
                {
                    case "1":
                        {
                            Service.nhapDanhSach();
                            break;
                        }
                    case "2":
                        {
                            Service.xuatDanhSach();
                            break;
                        }
                    case "3":
                        {
                            Service.FindBySoChan();
                            break;
                        }
                    case "4":
                        {
                            Service.DeleteByID();
                            break;
                        }
                    case "5":
                        {
                            Service.Sortting();
                            break;
                        }
                    case "6":
                        {
                            KeThua();
                            break;
                        }
                    case "7":
                        {
                            Service.UpDateByID();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Chuc nang khong ton tai");
                            break;
                        }
                }
            } while (true);


            Console.ReadLine();
        }

        static void KeThua()
        {
            ConTrungBietBay stbb = new ConTrungBietBay(1, "chau chau", 4, 6);
            stbb.ShowThongTin();
        }

    }
}
