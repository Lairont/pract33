using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Marchandise> merchandiseList = new List<Marchandise>
        {
            new Product("Молоко", 100, new DateTime(2024, 2, 14), 7),
            new Party("Яблоки", 200, 10, new DateTime(2024, 2, 9), 30),
            new Kit("Подарочный набор", 500, new List<string> { "Шоколад", "Печенье" })
        };
            foreach (var inf in merchandiseList)
            {
                inf.Info();
                Console.WriteLine(); 
            }
            Console.WriteLine("Просроченные товары:");
            bool hasExpired = false;
            foreach (var Overdue in merchandiseList)
            {
                if (Overdue.DeadlineExpirationDate())
                {
                    Console.WriteLine(Overdue.Name);
                    hasExpired = true;
                }
            }
            if (!hasExpired)
            {
                Console.WriteLine("Просроченных товаров нет.");
            }
            Console.ReadLine();

        }
    }
}
