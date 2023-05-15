using Builder.Builder;
namespace Builder.ConcreteBuilder
{
    public class AppleLaptop:LaptopBuilder
    {
        public override void PrepareTheHardware()
        {
            laptop.Processor = "M2";
            laptop.Gpu = "M2";
            laptop.DataStorage = "SSD 512 Gb";
        }

        public override void AddTheOperatingSystem()
        {
            laptop.Name = "MacBook Pro 13";
            laptop.OperationalSystem = "MacOS Ventura";
        }
    }
}