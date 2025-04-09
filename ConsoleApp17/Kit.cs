using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Kit : Marchandise
    {
        private List<string> listproducts;

        public Kit(string name, double price, List<string> listproducts) : base(name, price)
        {
            this.listproducts = listproducts;
        }

        public List<string> Listproducts { get => listproducts; set => listproducts = value; }

        public override void Info()
        {
            Console.WriteLine($"Название {Name}\nЦена {Price}");
            Console.WriteLine("Продукты:");
            foreach (var productName in listproducts)
            {
                Console.WriteLine($"- {productName}");
            }
        }

        public override bool DeadlineExpirationDate()
        {
            return false;
        }
    }
}
