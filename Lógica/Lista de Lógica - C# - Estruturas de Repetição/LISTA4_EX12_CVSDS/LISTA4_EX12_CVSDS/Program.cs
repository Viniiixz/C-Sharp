using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX12_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Calcular a soma dos N primeiros múltiplos de um inteiro K, onde N são números inteiros e positivos.\n==============================================================\n");
            //---------------------------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;

            double num_usuario, qt_multiplos_exibir, contador = 0, n, soma = 0;
            Console.Write("Entre o número para ser mostrado os multiplos: ");
            num_usuario = double.Parse(Console.ReadLine());
            Console.Write("Entre com a quantidade de múltiplos que você deseja que seja mostrado: ");
            qt_multiplos_exibir = double.Parse(Console.ReadLine());       
            Console.WriteLine("Você escolheu o número: {0}.\nA quantidade de múltiplos a exibir é: {1}.", num_usuario, qt_multiplos_exibir);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Seus múltiplos são: {0}", num_usuario);

            for (n = num_usuario; ;)
            {
                contador++;
                soma = soma + n;
                n = n + num_usuario;
                Console.Write(", {0}", n);
                if (contador == qt_multiplos_exibir)
                {
                    break;
                }
            }

            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nSua soma é: {0}.", soma);
            Console.ReadKey();
           
        }
    }
}
