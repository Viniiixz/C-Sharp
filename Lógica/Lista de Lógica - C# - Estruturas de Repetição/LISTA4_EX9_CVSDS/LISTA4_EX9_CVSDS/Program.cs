using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX9_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Calcule a potência de um número real ao se informar o seu expoente inteiro. Não usar a classe Math! \n=======================================================================================================================\n");
            //-----------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int nr = 0,ex = -1, result = 1;
            Console.Write("Digite um número real: ");
            nr = int.Parse(Console.ReadLine());
            while (ex < 0)
            {
                Console.Write("Digite o expoente inteiro: ");
                ex = int.Parse(Console.ReadLine());

                if (ex < 0) //mensagem de erro e repetindo a pgt cado insira um expoente negativo//
                {
                    Console.Write("Insira um expoente positivo.");
                }
                else
                {
                    for (int i = 0; i < ex; i++) 
                    {
                        result *= nr;
                    }
                    //------------------------------------------------------//
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Resultado: {0}", result);
                    Console.ReadKey();
                }
            }
        }
    }
}       
    
