using System;
using Builder.ConcreteBuilder;
using Builder.Director;

namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Director
            var lAssemler = new LAssembler(new SamsungLaptop());
            lAssemler.AssembleLaptop();
            var laptop1 = lAssemler.GetLaptop();
            laptop1.LaptopAttributes();

            Console.WriteLine();
            
            lAssemler = new LAssembler(new AppleLaptop());
            lAssemler.AssembleLaptop();
            var laptop2 = lAssemler.GetLaptop();
            laptop2.LaptopAttributes();

            Console.ReadKey();
        }
    }
}