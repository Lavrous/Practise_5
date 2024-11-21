namespace WinFormsApp2
{
    public class OfficeEquip
    {
        public string Model { get; set; } = "Unknown";
        private int price;

        public int Price
        {
            get => price;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 1, nameof(Price));
                price = value;
            }
        }

        private int scanSpeed;

        public int ScanSpeed
        {
            get => scanSpeed;
            set
            {
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 100, nameof(ScanSpeed));
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 1, nameof(ScanSpeed));
                scanSpeed = value;
            }
        }

        public OfficeEquip() : this("Unknown", 1, 1)
        { }

        public OfficeEquip(string model, int price, int scanSpeed)
        {
            Model = model;
            Price = price;
            ScanSpeed = scanSpeed;
        }

        public virtual void Print()
        {
            Console.WriteLine($"\nModel: {Model}, Price: {Price} Rubles, Scan Speed: {ScanSpeed} Pages per minute");
        }

        public override string ToString()
        {
            return $"Model: {Model}, Price: {Price}, Scan Speed: {ScanSpeed}";
        }
    }
}
