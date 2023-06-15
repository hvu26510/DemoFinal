using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinal
{
    internal class ConTrungBietBay : ConTrung
    {
        private int soCanh;

        public ConTrungBietBay(int id, string loai, int soChan, int soCanh) 
            : base(id, loai, soChan)
        {
            this.soCanh = soCanh;
        }

        public override void ShowThongTin()
        {
            base.ShowThongTin();
            Console.WriteLine("So canh :" + this.soCanh);
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("So Canh:");
            this.soCanh = int.Parse(Console.ReadLine());
        }
    }
}
