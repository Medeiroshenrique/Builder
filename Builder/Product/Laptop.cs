using System;
using System.Reflection;

namespace Builder.Builder
{
    public class Laptop
    {
        public string Name { get; set; }
        public string Processor { get; set; }
        public string Gpu { get; set; }
        public string OperationalSystem { get; set; }
        public string DataStorage { get; set; }

        public void LaptopAttributes()
        {
            Console.WriteLine($"Laptop: {Name}");
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"Graphics Processing Unit: {Gpu}");
            Console.WriteLine($"Operational System: {OperationalSystem}");
            Console.WriteLine($"Data Storage: {DataStorage}");
            
        }
    }
}