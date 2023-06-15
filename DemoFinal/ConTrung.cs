using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal
{
    internal class ConTrung
    {
        protected int id;
        protected string loai;
        protected int soChan;

        public ConTrung()
        {
        }

        public ConTrung(int id, string loai, int soChan)
        {
            this.id = id;
            this.loai = loai;
            this.soChan = soChan;
        }

        public int getId() { return this.id; }
        public string getLoai() { return this.loai; }   
        public int getsoChan() { return this.soChan; }

        public virtual void ShowThongTin()
        {
            Console.WriteLine("ID: "+ this.id);
            Console.WriteLine("Loai: " + this.loai);
            Console.WriteLine("So Chan: " + this.soChan);
        }

        public virtual void nhap()
        {
            Console.WriteLine();

            Console.Write("id :");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Loai :");
            this.loai = Console.ReadLine();
            Console.WriteLine();

            Console.Write("So chan:");
            this.soChan = int.Parse(Console.ReadLine());
            Console.WriteLine();

        }

    }
}
