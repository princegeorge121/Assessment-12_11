using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_12_11
{
    internal class Food
    {
        public string Name { get; set; }
        private double _discount;
        private double _price;

        public int Price
        {
            get { return (int)_price; }
            set
            {
                if (value > 150)
                {
                    Console.WriteLine("10% Discount ");
                    _discount = value * 0.1;
                    _price = value - _discount;
                    Console.WriteLine("New Price is :  " + _price);
                    return;
                }
                _price = value;


            }
        }




    }
}
