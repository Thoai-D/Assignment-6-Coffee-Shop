using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Coffee_Shop
{
    class Drinks
    {
        private string name;
        private int price;
        private int amountsold;

        public Drinks(string drinktobuy, int price)
        {
            name = drinktobuy;
            this.price = price;
        }

        public string Getname()
        {
            return name;
        }

        public int Getprice()
        {
            return price;
        }
    }
}
