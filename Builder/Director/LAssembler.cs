using Builder.Builder;

namespace Builder.Director
{
    public class LAssembler
    {
        private readonly LaptopBuilder builder;

        public LAssembler(LaptopBuilder builder)
        {
            this.builder = builder;
        }

        public void AssembleLaptop()
        {
            builder.CreateLaptop();
            builder.PrepareTheHardware();
            builder.AddTheOperatingSystem();
        }

        public Laptop GetLaptop()
        {
            return builder.GetLaptop();
        }
    }
}