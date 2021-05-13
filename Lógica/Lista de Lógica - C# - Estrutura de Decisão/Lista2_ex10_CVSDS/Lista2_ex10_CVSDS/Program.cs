using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex10_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {//10. Construa um algoritmo que leia dois números (A e B). Caso A seja igual a B, apresentar a soma dos dois.
         //Caso um seja maior que o outro, apresentar a diferença entre os dois números 
         //(sempre lembrando que a diferença entre dois números é SEMPRE positiva).
            double A, B;

            Console.Write("Digite o número A:");
            A = double.Parse(Console.ReadLine());
            Console.Write("Digite o número B:");
            B = double.Parse(Console.ReadLine());

            if ( A == B )
            {
                Console.WriteLine("Soma de A e B: {0}", A + B);
            }
            if (A < B)
            {
                Console.WriteLine("Soma de A e B:{0}", B - A);             
            }
            if (A > B)
            {
                Console.WriteLine("Soma de A e B:{0}", A - B);
            }
            Console.ReadKey();


        }
    }
}
