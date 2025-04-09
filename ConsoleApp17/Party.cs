using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Party : Marchandise
    {
        private int count;
        private DateTime productionDate;
        private int shelfLife;

        public Party(string name, double price, int count, DateTime productionDate, int shelfLife) : base(name, price)
        {
            this.count = count;
            this.productionDate = productionDate;
            this.shelfLife = shelfLife;
        }

        public int Count { get => count; set => count = value; }
        public DateTime ProductionDate { get => productionDate; set => productionDate = value; }
        public int ShelfLife { get => shelfLife; set => shelfLife = value; }

        public override void Info()
        {
            Console.WriteLine($"Название {Name}\nЦена {Price}\nКоличество {Count}\nДата производства {productionDate}\n" +
                $"Срок годности {ShelfLife} ");
        }

        public override bool DeadlineExpirationDate()
        {
            return DateTime.Now > ProductionDate.AddDays(ShelfLife);
        }
    }
}
