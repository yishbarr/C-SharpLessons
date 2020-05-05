using System;

namespace _5._5._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1
            Cookie a = new Cookie();
            Cookie b = new Cookie();
            Cookie c = new Cookie();
            //2.2
            a.HasGluten = true;
            a.NumOfEggs = 3;
            a.Sugar = 4.6;
            a.Flower = 5.8;
            //2.3
            b.Flower = 6.9;
            b.HasGluten = false;
            b.NumOfEggs = 8;
            b.Sugar = 8.4;
            //2.5
            printCookie(a);
            printCookie(b);
            //2.6
            a.Sugar = 6.7;
            //2.7
            printCookie(a);
            printCookie(b);
            //2.8
            b = a;
            //2.9
            b.NumOfEggs = 9;
            //2.10 a is in sync with b because objects are reference types
            printCookie(a);
            printCookie(b);
        }
        //2.4
        static void printCookie(Cookie x)
        {
            Console.WriteLine();
            Console.WriteLine("Flower - "+x.Flower);
            Console.WriteLine("Sugar - "+x.Sugar);
            Console.WriteLine("Number of Eggs - "+x.NumOfEggs);
            Console.WriteLine("Has gluten - "+x.HasGluten);
        }
    }
}
