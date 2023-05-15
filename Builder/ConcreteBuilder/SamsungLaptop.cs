using Builder.Builder;

namespace Builder.ConcreteBuilder
{
    public class SamsungLaptop:LaptopBuilder
    {
        public override void PrepareTheHardware()
        {
            laptop.Processor = "Intel Core i3 7020U";
            laptop.Gpu = "Intel HD Graphics 620";
            laptop.DataStorage = "SSD 1000 Gb 2100 mb/s";
        }

        public override void AddTheOperatingSystem()
        {
            laptop.Name = "Samsung Essentials e30";
            laptop.OperationalSystem = "Ubuntu 22.04 LTS";
        }
    }
}