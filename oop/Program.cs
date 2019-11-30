using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(2, 4);
            Console.WriteLine("a = " + a.ToString());
            Fraction b = new Fraction(-4, -8);
            Console.WriteLine("b = " + b.ToString());
            Fraction c = a * b;
            Console.WriteLine("a * b = "+ c.ToString());
            if (a == b)
                Console.WriteLine("a = b");
            Fraction d = new Fraction(43, 18);
            Console.WriteLine("d = " + d.ToString());
            Fraction e = new Fraction(78, -112);
            Console.WriteLine("e = " + e.ToString());
            Fraction f = new Fraction(12.568);
            Console.WriteLine("f = " + f.ToString());
            Fraction g = new Fraction(-61);
            Console.WriteLine("g = " + g.ToString());
            if (d < f)
                Console.WriteLine("d < f");
            Console.WriteLine("d * e / f + g = " + (d*e/f+g).ToString());
        }
    }
}
