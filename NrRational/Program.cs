using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrRational
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(8, 5);
            Rational r2 = new Rational(3, 4);
            Rational sum = r1.Sum(r2);
            Console.WriteLine(sum);
            Rational substract = r1.Substract(r2);
            Console.WriteLine(substract);
            Rational multiply = r1.Multiply(r2);
            Console.WriteLine(multiply);
            Rational divide = r1.Divide(r2);
            Console.WriteLine(divide);
            Rational pow = r1.Pow(3);
            Console.WriteLine(pow);
            Console.ReadKey();
        }
    }
}