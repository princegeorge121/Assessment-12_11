using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_12_11
{
    internal class Mobile
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public int Price { get; set; }
        public string? Company { get; set; }

        public void SetData(string name, string model, int price, string company)
        {
            Name = name;
            Model = model;
            Price = price;
            Company = company;


        }
        public void SetData(string name, string model, int price)
        {
            Name = name;
            Model = model;
            Price = price;
            Company = null;
        }
        public void GetData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Company : " + Company);

        }

    }
}
