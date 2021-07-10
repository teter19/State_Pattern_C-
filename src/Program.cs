using System;

namespace lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Rzeka rzeka = new Rzeka();
            Woda woda = new Woda();
            Studnia studnia = new Studnia();

            Console.WriteLine("Zaczynamy od:\n");

            /*woda.setState(rzeka);   //zaczynamy od rzeki
            Console.WriteLine(woda.Info());
            Console.WriteLine("--- Potem ---");
            woda.Paruj();
            Console.WriteLine( woda.Info());        //wypisuje stan rzeki
            Console.WriteLine("--- Potem ---");
            woda.Padaj();
            Console.WriteLine(woda.Info());        //wypisuje stan rzeki
            Console.WriteLine("--- Potem ---");*/

            woda.setState(studnia);             //zaczynamy od studni
            Console.WriteLine(woda.Info());
            Console.WriteLine("--- Potem ---");
            woda.Pij();
            Console.WriteLine(woda.Info());     //czlowiek
            Console.WriteLine("--- Potem ---");
            woda.Wydalaj();
            Console.WriteLine(woda.Info());     //oczyszczalnia
            Console.WriteLine("--- Potem ---");
            woda.Oczyszczaj();
            Console.WriteLine(woda.Info());     //rzeka
            Console.WriteLine("--- Potem ---");
            woda.Wplywaj();
            Console.WriteLine(woda.Info());     //ocean
            Console.WriteLine("--- Potem ---");
            /*//-------------------------------------------
            woda.Pij();
            Console.WriteLine("--- ------------------------------ ---");
            Console.WriteLine(woda.Info());     //ocean
            Console.WriteLine("--- ------------------------------ ---");*/
            woda.Paruj();
            Console.WriteLine(woda.Info());     //chmura
            Console.WriteLine("--- Potem ---");
            woda.Padaj();
            Console.WriteLine(woda.Info());     //randomowe, losowanie z 3 liczb, albo roslina, albo studnia, albo rzeka
            Console.WriteLine("--- Koniec---");
            /*int rnd = new Random().Next(0, 2);
            Console.WriteLine(rnd);*/
        }
    }
}
