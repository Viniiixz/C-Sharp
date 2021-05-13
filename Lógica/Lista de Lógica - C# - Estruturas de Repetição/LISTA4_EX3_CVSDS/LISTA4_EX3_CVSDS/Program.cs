using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX3_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Cria a série de Fibonacci de acordo com a quantidade de termos escolhida pelo usuário. Cada novo termo da série é obtido ao se somar os 2 termos anteriores. Ex: 1, 1, 2, 3, 5, 8,...\n=====================================================================================================================\n");
            //---------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int num_seq, i;
            int prox_num = 1;
            int num_atual = 1;
            int num_ant = 1;
            Console.Write("Digite o número de termos Fibonacci:  ");
            num_seq = int.Parse(Console.ReadLine());
            //--------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (i = 1; i <= num_seq; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("0");
                }
                else if (i == 2 || i == 3)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    prox_num = num_ant + num_atual;
                    num_ant = num_atual;
                    num_atual = prox_num;
                    Console.WriteLine("{0}", prox_num);
                }
            }
            Console.ReadKey();
        }
    }
}
