using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("FIAT", 180);
            //samochod.UstawPredkoscMax(199);
            samochod.PredkoscMax = -10; // 220;
            samochod.Print();

            //int predkosc = samochod.PobierzPredkoscMax();
            Console.WriteLine(samochod.PredkoscMax);

            // kolejna instancja obiektu
            Samochod samochod1 = new Samochod("AUDI");
            samochod1.Print();

            Console.ReadKey();
        }
    }
}
