using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX1_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        { //1. Exibe a tabuada de 2 a 10 de acordo com a opção escolhida pelo usuário. Cada operação em uma nova linha.
            Console.ForegroundColor = ConsoleColor.Cyan; //cor das letras         
            Console.Write("Exibe a tabuada de 2 a 10 de acordo com a opção escolhida pelo usuário. Cada operação em uma nova linha.\n=======================================================================================================================\n");
            //--------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int tab, i;

            Console.Write("Digite a tabuada desejada: ");
            tab = int.Parse(Console.ReadLine());
            //-------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (tab >= 10 || tab <= 2)
            {
                Console.WriteLine("ERRO! Por favor digite da tabuada 2 ao 10. ");
                Console.ReadKey();
            }
          
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}", tab, i, tab * i);
            }         
            Console.ReadKey();
        }
    }
}
