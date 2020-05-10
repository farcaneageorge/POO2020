using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Matrix m1 = new Matrix(n, m);
            Matrix m2 = new Matrix(n, m);
            m1.RandomMatrix(n, m);
            Console.WriteLine();
            Console.WriteLine(m1);
            Console.WriteLine();
            m2.RandomMatrix(n, m);
            Console.WriteLine(m2);
            Console.WriteLine();

            Matrix sum = m1.AddMatrix(m2);
            Console.WriteLine("SUMA CELOR 2 MATRICI");
            Console.WriteLine(sum);

            Matrix dif = m1.SubstractMatrix(m2);
            Console.WriteLine("DIFERENTA CELOR 2 MATRICI");
            Console.WriteLine(dif);

            Console.WriteLine();
            Console.WriteLine("PRODUSUL CELOR 2 MATRICI");
            Matrix produs = m1.Multiply(m2);
            Console.WriteLine(produs);

            Console.WriteLine();
            Console.WriteLine("RIDICAREA LA PUTERE");
            Matrix putere = m1.Pow(2);
            Console.WriteLine(putere);

            Console.WriteLine();
            Console.WriteLine("TRANSPUSA");
            Matrix transpusa = m1.TransposedMatrix();
            Console.WriteLine(transpusa);

            Console.WriteLine();
            Console.WriteLine("DETERMINANT");
            double determinant = m1.GetDeterminant(m1, n);
            Console.WriteLine(determinant);


            Console.WriteLine();
            Console.WriteLine("INVERSA");
            Matrix inversa = m1.GetInverseMatrix(determinant);
            Console.WriteLine(inversa);

            Console.ReadKey();
        }
    }
}