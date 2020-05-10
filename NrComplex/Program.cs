using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Cplx a = new Cplx(4, 7);
            Cplx b = new Cplx(3, 5);

            Cplx suma = a.Sum(b);
            Console.WriteLine(suma);

            Cplx diferenta = a.Substract(b);
            Console.WriteLine(diferenta);
            a.TrigonometricForm();
            a.PowTrigonometricForm(5);
            Cplx putere = a.Pow(2);
            Console.WriteLine(putere);
            Console.ReadKey();

        }
    }
}