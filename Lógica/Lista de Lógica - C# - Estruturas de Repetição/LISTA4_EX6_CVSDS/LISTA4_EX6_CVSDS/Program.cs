using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX6_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcula o fatorial de um número conforme o indicado pelo usuário.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Receba um número e o exiba na forma fatorada. Ex: 18 = 2*3*3.\n=================================================================\n");
            //--------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;
            float n, n1;
            Console.Write("Digite um número a ser fatoriado:  ");
            n = float.Parse(Console.ReadLine());
            //-------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("O fatorial de {0} = ", n);
            for (n1 = n; n1 >= 1; n1--)
            {
                Console.Write("{0}-", n1);
            }
            Console.ReadKey();
        }
    }
}
