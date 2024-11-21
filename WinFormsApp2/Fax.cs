using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Fax : OfficeEquip
    {
        private int phoneLines;

        public int PhoneLines
        {
            get => phoneLines;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 30, nameof(PhoneLines));
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 1, nameof(PhoneLines));
                phoneLines = value;
            }
        }

        public Fax() : this("Unknown", 1, 1, 1)
        { }

        public Fax(string model, int price, int scanSpeed, int phoneLines) : base(model, price, scanSpeed)
        {
            PhoneLines = phoneLines;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Number of Phone Lines: {PhoneLines}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Number of Phone Lines: {PhoneLines}";
        }
    }
}

