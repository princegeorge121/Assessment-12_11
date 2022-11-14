using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_12_11
{
    internal class Furniture
    {
        public string Type { get; set; }
        public string Wood { get; set; }
        public int Price { get; set; }

        public Furniture(string type, string wood, int price)
        {
            Type = type;
            Wood = wood;
            Price = price;

        }
        public Furniture(string type, int price)
        {
            Type = type;
            Price = price;

        }
        public Furniture()
        {
            Type = "Unknown";
            Wood = "Unknown";
            Price = 0;

        }
        public void GetData()
        {
            Console.WriteLine("Type : " + Type);
            Console.WriteLine("Wood : " + Wood);
            Console.WriteLine("Price: " + Price);


        }
    }
}
