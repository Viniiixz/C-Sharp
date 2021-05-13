using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX8_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Exiba todos os números primos existentes dentro de um intervalo escolhido pelo usuário. \n=============================================================================\n");
            //-------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;

            double nm_usuario, contador = 0;
            Console.Write("Entre com o intervalo para verificar os primos existentes: ");
            nm_usuario = double.Parse(Console.ReadLine());
            
            //------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Seus números primos são: ");
            if (nm_usuario == 1)
            {
                Console.Write("1.");
            }
            else if (nm_usuario == 2)
            {
                Console.Write("1, 3.");
            }
            else if (nm_usuario == 3)
            {
                Console.Write("1, 3, 5.");
            }
            else if (nm_usuario == 4)
            {
                Console.Write("1, 3, 5, 7.");
            }
            else if (nm_usuario > 4)
            {
                Console.Write("1, 3, 5, 7");
                for (double n = 10; ; n++)
                {
                    if (n % 2 == 0)
                    {
                        continue;
                    }
                    else if (n % 3 == 0)
                    {
                        continue;
                    }
                    else if (n % 5 == 0)
                    {
                        continue;
                    }
                    else if (n % 7 == 0)
                    {
                        continue;
                    }
                    else if (n % 7 != 0 && n % 5 != 0 && n % 3 != 0 && n % 2 != 0)
                    {
                        Console.Write(", {0}", n);
                    }
                    contador++;
                    if (contador == nm_usuario)
                    {
                        break;
                    }
                }
                Console.Write(".");
            }
            Console.ReadKey();
        }
    }
}
