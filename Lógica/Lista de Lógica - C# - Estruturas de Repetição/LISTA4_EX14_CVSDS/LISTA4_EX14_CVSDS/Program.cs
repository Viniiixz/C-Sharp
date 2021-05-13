using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX14_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("O programa gera um número aleatório de 1 a 100 e solicita ao usuário para tentar adivinhar. Apresentar mensagens diferenciadas para erro ou acerto. A cada erro informar ao usuário se o número sorteado é menor ou maior que o valor escolhido pelo usuário. Caso erre 3 vezes apresente o número que foi sorteado. \n=============================================================================================================\n");
            //--------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;

            int tentativas = 0;
            Random numero_aleatorio = new Random();
            int rgn = numero_aleatorio.Next(1, 100);
        inicio:   //ativar o "goto" para ele voltar ao início       
            Console.Write("Entre com um número de 1 a 100: ");
            int num_usuario = int.Parse(Console.ReadLine());

            if (num_usuario == rgn)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você acertou! Seu número era: {0}\nO número gerado foi: {1}", num_usuario, rgn);

            }
            else
            {
                tentativas++;
                if (tentativas == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Acabaram suas tentativas.\nO número gerado era: {0}.", rgn);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Você errou... Seu número foi: {0}\n", num_usuario);
                if (num_usuario < rgn)
                {
                    Console.Write("O número gerado é MAIOR que o número que você inseriu.");
                }
                else
                {
                    Console.Write("O número gerado é MENOR que o número que você inseriu.");
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nLhe restam {0}/3 tentativas. Pressione enter para continuar...", 3 - tentativas);
            
                Console.ReadKey();           
                goto inicio;
            }

            Console.ReadKey();
        }
    }
}
