using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX5_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Calcula a soma dos n primeiros termos de uma PG ao se informar o 1º e 2º termo. \n================================================================================\n");
            //----------------------------------------------------------------------------------//
            inicio:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            float term1, term2, term3;

            Console.Write("Digite o primeiro termo:  ");
            term1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo termo:  ");
            term2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de termos a ser calculado:  ");
            term3 = float.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            float x;

            x = term2 / term1; //razão da p.g
            Console.WriteLine(term1);
            double term4 = term1;

            //--------------------------------------------------------------------------------//         
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int n = 2; n <= term3; n++)
            {
                Console.WriteLine(term2);
                term4 = term4 + term2;
                term2 = term2 * x;

            }
            Console.Write(term4);
            //-------------------------------------------------------------------------------//mensagem de erro xp
            if (term1 >= term2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Digite novamente. 1º termo menor que o 2º termo. ");
                goto inicio;
            }
            Console.ReadKey();


        }
    }
}
