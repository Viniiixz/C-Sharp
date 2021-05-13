using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX7_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Receba um número e informe se ele é primo. \n================================================================================\n");
            //-----------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;

            int tmp, i, num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            //-----------------------------------------------------------------------//

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (i = 2; i < num; i++)
            {
                tmp = num % i;
                if (tmp == 0)
                {
                    break;
                }
            }
            if (i == num)
            {
                Console.WriteLine("{0} é um número primo.", num);
            }
            else
            {
                Console.WriteLine("{0} não é um número primo.", num);
            }
            Console.ReadKey();
        }
    }
}
