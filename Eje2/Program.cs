using System;

namespace Eje2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ejercicio 2
            System.Console.WriteLine("+---------Ejercicio 2---------+");
            int N = 5;
            double A = 4.56;
            char C = 'a';
            System.Console.WriteLine("{0} + {1}", N, A + " = " + (N + A).ToString("0.00000"));
            System.Console.WriteLine("{0} - {1}", A, N + " = " + (A - N).ToString("0.00000"));
            System.Console.WriteLine("Valor numerico del caracter a = " + Convert.ToInt32(C));

        }
    }
}
