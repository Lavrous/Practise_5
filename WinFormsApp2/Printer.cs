using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Printer : OfficeEquip
    {
        private int storage;

        public int Storage
        {
            get => storage;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 10000, nameof(Storage));
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 1001, nameof(Storage));
                storage = value;
            }
        }

        public Printer() : this("Unknown", 1, 1, 1000)
        { }

        public Printer(string model, int price, int scanSpeed, int storage) : base(model, price, scanSpeed)
        {
            Storage = storage;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Storage: {Storage} Pages");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Storage: {Storage} Pages";
        }
    }
}
