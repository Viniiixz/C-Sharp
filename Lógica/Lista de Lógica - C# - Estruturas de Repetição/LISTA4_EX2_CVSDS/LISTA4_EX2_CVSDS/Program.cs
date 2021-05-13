using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX2_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Calcula o fatorial de um número conforme o indicado pelo usuário. \n==================================================================\n");
            //------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int numero;
            Console.Write("Entre com o número que será fatorado:");
            numero = int.Parse(Console.ReadLine());
            int fatoração;
            fatoração = numero;
            //------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = numero - 1; i > 1; i--)
            {
                fatoração *= i;
            }
            Console.Write("Valor total do fatoração: " + fatoração);           
            Console.ReadKey();
        }
    }
}
