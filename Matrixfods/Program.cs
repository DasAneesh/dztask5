using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Matrixfods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");
            MyMatrix matr1 = new MyMatrix(2,2);
            MyMatrix matr2 = new MyMatrix(2,2);
            //MyMatrix matr3 = new MyMatrix(5,5);


            Console.WriteLine(matr1.ToString());
            Console.WriteLine(matr2.ToString());
            //Console.WriteLine(matr3.ToString());

            matr1.RandomGenerate();
            matr2.RandomGenerate();
            //matr3.RandomGenerate();

            Console.WriteLine(matr1.ToString());
            Console.WriteLine(matr2.ToString());
            //Console.WriteLine(matr3.ToString());

            matr1.MatrixMultiplication(matr1,matr2);
            Console.WriteLine(matr1.ToString());
            //Console.WriteLine("min element:");
            //Console.WriteLine(matr1.Minelementsearch());

            //Console.WriteLine("max element:");
            //Console.WriteLine(matr1.Maxelementsearch());

            //matr1.MatrixAdd(matr1, matr2);
            //Console.WriteLine(matr1.ToString());

            //matr1.MatrixMinus(matr1, matr2); 
            //matr1.MatrixMinus(matr1, matr2);
            //Console.WriteLine(matr1.ToString());

            //matr1.Inevertion();
            //Console.WriteLine(matr1.ToString());
            //Console.WriteLine("\n");
            matr1.Multiplication(3);
            Console.WriteLine(matr1.ToString());

            Console.ReadKey();
        }
    }
}
