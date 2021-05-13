using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex5_CV
{
    class Program
    {
        static void Main(string[] args)
        {//5. Construa um algoritmo que leia um número inteiro
         //(positivo ou negativo) e 
         //apresente o seu módulo (número sem sinal).

            double n, m;
            Console.WriteLine("Digite o número: ");
            n = double.Parse(Console.ReadLine());

            if (n < 0)
            {
                n = -(n);
                Console.WriteLine("Seu módulo é: |{0}|", n);          //todo numero em modulo tem barra = |{0}| 
                            Console.ReadKey();
            }
            else
            {
                m = n;
                Console.WriteLine("Seu módulo é: |{0}|", n);
                       Console.ReadKey();
            }

           
        }
    }
}




