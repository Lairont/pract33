using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    abstract class Marchandise
    {
        string name;
        double price;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public Marchandise(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract void Info();
        public abstract bool DeadlineExpirationDate();
    }
}
