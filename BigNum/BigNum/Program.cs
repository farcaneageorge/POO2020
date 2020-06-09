using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNum
{
    class Program
    {
        public static BigNumber Fibonacci(int x)
        {
            BigNumber b1 = new BigNumber("0");
            BigNumber b2 = new BigNumber("1");

            if (x == 0)
                return b1;
            if (x == 1)
                return b2;
            else
                return Fibonacci(x - 1).Add(Fibonacci(x - 2));


        }

        public static BigNumber GetFactorial(int n)
        {


            BigNumber b1 = new BigNumber("1");

            BigNumber b2 = new BigNumber("1");
            for (int i = 0; i < n; i++)
            {
                b2 = b2.Multiply(b1);
                b1 = b1.Add(new BigNumber("1"));
            }
            return b2;
        }
        static void Main(string[] args)
        {
            BigNumber b2 = new BigNumber("345");
            BigNumber b3 = new BigNumber("1256");

            Console.WriteLine("Big number 1:");
            b2.display();
            Console.WriteLine("Big number 2:");
            b3.display();
            Console.WriteLine();
            //Console.WriteLine($"{b2}+{b3}={b2.Add(b3)}");
            Console.WriteLine("Sum:");
            b2.Add(b3).display();
            Console.WriteLine();
            Console.WriteLine("Multiply:");
            b2.Multiply(b3).display();
            Console.WriteLine();

            Fibonacci(100).display();

            Console.WriteLine();
            GetFactorial(1000).display();

        }
    }
}