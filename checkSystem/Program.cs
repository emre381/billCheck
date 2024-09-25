using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkSystem
{
     class Program
    {
        static void Main(string[] args)
        {
            int secim;
            double toplam = 0;

            do
            {
                Console.WriteLine("1.Order is Adana 15$");
                Console.WriteLine("2.Order is Beyti 18.45$");
                Console.WriteLine("3.Order is Döner 12.75$");
                Console.WriteLine("4.Order is Coke 1$");
                Console.WriteLine("5.Order is Soup 5$");
                Console.WriteLine("Leave with press 6");
                Console.WriteLine("Plsease pic an order");
                secim = int.Parse(Console.ReadLine());

                switch (secim) 
                {
                    case 1:
                        toplam += 15;
                        Console.WriteLine("last check = " + toplam);
                        break;

                    case 2:
                        toplam += 18.45;
                        Console.WriteLine("last check = " + toplam);
                        break;

                    case 3:
                        toplam += 12.75;
                        Console.WriteLine("last check = " + toplam);
                        break;

                    case 4:
                        toplam += 1;
                        Console.WriteLine("last check = " + toplam);
                        break;

                    case 5:
                        toplam += 5;
                        Console.WriteLine("last check = " + toplam);
                        break;

                    case 6:
                        Console.WriteLine("Order is done");

                        break;
                    default:
                        Console.WriteLine("please enter an order number");
                        break;

                }
                


            }
            while (secim!=6);
            Console.WriteLine("bill is = " + toplam);
            Console.ReadLine();

        }
    }
}
