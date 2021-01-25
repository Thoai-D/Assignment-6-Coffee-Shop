using System;

namespace Assignment_6_Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Drinks[] drinks = new Drinks[5];

            drinks[0] = new Drinks("Coffee", 50);
            drinks[1] = new Drinks("Tea", 45);
            drinks[2] = new Drinks("Juice", 30);
            drinks[3] = new Drinks("Coffee", 50);

            Console.WriteLine(drinks[0].Getname());

            for (int i = 1; i < drinks.Length; i++)
            {
                if (drinks[i] != null)
                {
                    Console.WriteLine(drinks[i].Getname() + " " + drinks[i].Getprice());
                }
                else
                {
                    Console.WriteLine("Nothing is here");
                }
            }
        }
    }