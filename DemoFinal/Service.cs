using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal
{
    static class Service
    {
        static List<ConTrung>  listConTrungs = new List<ConTrung>();

        public static void AddDemoData()
        {
            ConTrung conTrung1 = new ConTrung(1, "Bo Cap", 6);
            ConTrung conTrung2 = new ConTrung(2, "Chau Chau", 6);
            ConTrung conTrung3 = new ConTrung(3, "Nhen", 8);
            listConTrungs.Add(conTrung1);
            listConTrungs.Add(conTrung2);
            listConTrungs.Add(conTrung3);
        }

        public static void nhapDanhSach()
        {
            do
            {
                ConTrung ct = new ConTrung();
                ct.nhap();
                listConTrungs.Add(ct);

                Console.WriteLine("Tiep tuc? nhap 'y' de tiep tuc");
                if (Console.ReadLine() != "y")
                {
                    break;
                }

            }while (true);
        }

        public static void xuatDanhSach()
        {
            foreach(ConTrung ct in listConTrungs)
            {
                ct.ShowThongTin();
            }
        }

        public static void FindBySoChan()
        {
            Console.WriteLine("Nhap so chan muon tim:");
            int sochan = int.Parse(Console.ReadLine());

            foreach (ConTrung ct in listConTrungs)
            {
                if (ct.getsoChan() == sochan)
                {
                    ct.ShowThongTin();
                }
            }

            //List<ConTrung> ct = listConTrungs.Where(ct1 =>ct1.getsoChan()==sochan).ToList();


        }

        public static void UpDateByID()
        {
            Console.WriteLine("Nhap id muon cap nhat:");
            int id = int.Parse(Console.ReadLine());

            foreach (ConTrung ct in listConTrungs)
            {
                if (ct.getId() == id)
                {
                    int index = listConTrungs.IndexOf(ct);
                    ConTrung newCT = new ConTrung();
                    newCT.nhap();
                    listConTrungs[index] = newCT;
                    break;
                }
            }
            //List<ConTrung> ct = listConTrungs.Where(ct1 =>ct1.getsoChan()==sochan).ToList();

        }
        public static void DeleteByID()
        {
            Console.WriteLine("Nhap id muon xoa:");
            int id = int.Parse(Console.ReadLine());
            foreach(ConTrung conTrung in listConTrungs)
            {
                if (conTrung.getId() == id)
                {
                    listConTrungs.Remove(conTrung);
                    break;
                }
            }

        }

        public static void Sortting()
        {
            listConTrungs = listConTrungs.OrderBy(ct=>ct.getLoai()).ToList();
        }



    }
}
