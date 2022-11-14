using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_12_11
{
    internal class Clothes
    {
        private string _category;
        public int Price { get; set; }

        private int _sale;


        public string Category
        {
            get { return _category; }
            set
            {
                if (value == "Old")
                {
                    _category = value;
                    _sale = Price - (int)(Price * 0.2);
                    Console.WriteLine("There is Discount for Old Stocks!!! Sales Price Is : " + _sale);

                }
                _category = value;
            }
        }

    }
}
