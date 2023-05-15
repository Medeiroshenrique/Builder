namespace Builder.Builder
{
    public abstract class LaptopBuilder
    {
        protected Laptop laptop;

        public void CreateLaptop()
        {
            laptop = new Laptop();
        }

        public Laptop GetLaptop()
        {
            return laptop;
        }

        public abstract void PrepareTheHardware();
        public abstract void AddTheOperatingSystem();
    }
}