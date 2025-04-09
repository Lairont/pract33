using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Product : Marchandise
    {
        private DateTime productionDate;
        private int shelfLife;

        public Product(string name, double price, DateTime productionDate, int shelfLife) : base(name, price)
        {
            this.productionDate = productionDate;
            this.shelfLife = shelfLife;
        }

        public DateTime ProductionDate { get => productionDate; set => productionDate = value; }
        public int ShelfLife { get => shelfLife; set => shelfLife = value; }

        public override void Info()
        {
            Console.WriteLine($"Название {Name}\nЦена {Price}\nДата производства {productionDate}\n" +
                $"Срок годности {ShelfLife} ");
        }

        public override bool DeadlineExpirationDate()
        {
            return DateTime.Now > ProductionDate.AddDays(ShelfLife);
        }
    }
}
