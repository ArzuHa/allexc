using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC
{
    class Program
    {
        static void Main(string[] args)
        {
            //tapsiriq 1.

            //mesele 1

            //int a = 4444;
            //int yekun;
            //yekun = (a +70000)*10+8;
            //Console.WriteLine(yekun);

            //Console.ReadKey();

            //mesele 2

            //int a = 333;
            //int yekun;
            //yekun = (a * 1000) + a;

            //Console.WriteLine(yekun);
            //Console.ReadKey();

            //mesele 3

            //int a = 55555;
            //double b18 = a * 0.18;
            //double b3 = a * 0.03;

            //Console.WriteLine($"{a} ededinin 18%-i {b18} 3%-i {b3} beraberdir");
            //Console.ReadKey();

            //mesele 4

            //int a = 555;
            //a = (a * 10) + 7;
            //double b7 = a * 0.07;
            //Console.WriteLine($"{a} ededinin 7%-i : {b7}");

            //Console.ReadKey();

            //mesele 5

            //int a = 5555;
            //a = (a +40000)*100+44;
            //double b44 = a * 0.44;
            //Console.WriteLine($"{a} ededinin 44%-i : {b44}");
            //Console.ReadKey();

            //mesele 6

            //int a = 5555;
            //double b20 = a * 0.2;
            //double b10 = b20 * 0.10;
            //double yekun = b10 * b10;
            //Console.WriteLine(yekun);
            //Console.ReadKey();

            //mesele 7

            //int eded1 = 55555;
            //int eded2 = 77777;
            //int toplam = eded1 + eded2;

            //toplam = (toplam + 5000000) * 10 + 5;

            //double x = toplam * 0.05;
            //Console.WriteLine(x);

            //Console.ReadKey();


            //mesele 8

            //int eded1 = 5555;
            //int eded2 = 7777777;
            //double eded11 = eded1 * 0.04;
            //double eded22 = eded2 * 0.09;
            //double yekun = (eded11 + eded22) * 0.10;

            //Console.WriteLine(yekun);
            //Console.ReadKey();

            //mesele 9

            //int a = 111111;
            //int b = 222222;
            //int c = 333333;

            //double a1 = a * 0.1;
            //double a2 = b * 0.1;
            //double a3 = c * 0.1;

            //double yekun = (a1 + a2 + a3) * 0.1;
            //Console.WriteLine(yekun);
            //Console.ReadKey();

            //mesele 10

            //int a = 1111;
            //int b = 2222;
            //int c = 3333;

            //double a2 = a * 0.1;
            //double b2 = b * 0.2;
            //double c2 = c * 0.3;

            //double result = (c2 - b2 - a2) + (c * 0.7);
            //Console.WriteLine(result);

            //Console.ReadKey();

            //mesele 11


            //int a = 22222;
            //int b = 33333;
            //int c = 44444;
            //int d = 55555;

            //double result = ((a + c) * (b + d)) - (c * 0.3);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //mesele 12


            int a = 111111;
            int b = 222222;
            int c = 333333;
            int d = 444444;
            double aa = a * 0.1;
            double bb = b * 0.1;
            double cc = c * 0.1;
            double dd = d * 0.1;

            double result = aa + bb + cc + dd;

            double a1 = a * 0.15;
            double b1 = b * 0.15;
            double c1 = c * 0.15;
            double d1 = d * 0.15;

            double result2 = a1 + b1 + c1 + d1;

            double yekun = result * result2;
            double x10 = yekun * 0.1;
            double x11 = yekun * 0.11;
            Console.WriteLine($"10%-i : {x10} , 11%-i : {x11}");
            Console.ReadKey();
        }

    }

}
