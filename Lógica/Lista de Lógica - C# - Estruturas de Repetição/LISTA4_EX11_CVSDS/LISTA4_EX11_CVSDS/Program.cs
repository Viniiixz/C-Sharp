using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX11_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Receba 2 números e permita escolher: Exibir o intervalo de todos os números entre eles, apenas os pares ou apenas os ímpares.\n========================================================================================================================\n");
            //------------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;           
            double primeiro_num_usuario, segundo_num_usuario, inicio;
            char escolha_usuario;
        inicio:            
            try
            {

                Console.Write("Entre com o primeiro número de sua escolha: ");
                primeiro_num_usuario = double.Parse(Console.ReadLine());
                Console.Write("Entre com o segundo número de sua escolha: ");
                segundo_num_usuario = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("Escolha uma opção:\nEntre os números escolhidos:\n[1] Exibir o intervalo entre ambos\n[2] Exibir apenas os números pares\n[3] Exibir apenas os ímpares\n\nSua escolha: ");
                escolha_usuario = char.Parse(Console.ReadLine());
                
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada de número inválida, tente novamente:  ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.ReadKey();
                Console.Clear();
                goto inicio;
            }
        exibicao:
            if (escolha_usuario == '1')
            {
                if (primeiro_num_usuario < segundo_num_usuario)
                {
                    for (inicio = primeiro_num_usuario; inicio <= segundo_num_usuario; inicio++)
                    {
                        Console.Write("{0}; ", inicio);
                    }
                }
                else
                {
                    for (inicio = primeiro_num_usuario; inicio >= segundo_num_usuario; inicio--)
                    {
                        Console.Write("{0}; ", inicio);
                    }
                }
            }
            else if (escolha_usuario == '2')
            {
                if (primeiro_num_usuario < segundo_num_usuario)
                {
                    for (inicio = primeiro_num_usuario; inicio <= segundo_num_usuario; inicio++)
                    {
                        if (inicio % 2 == 0)
                        {
                            Console.Write("{0}; ", inicio);
                        }
                        else;
                    }
                }
                else
                {
                    for (inicio = primeiro_num_usuario; inicio >= segundo_num_usuario; inicio--)
                    {
                        if (inicio % 2 == 0)
                        {
                            Console.Write("{0}; ", inicio);
                        }
                        else;
                    }
                }
            }
            else if (escolha_usuario == '3')
            {
                if (primeiro_num_usuario < segundo_num_usuario)
                {
                    for (inicio = primeiro_num_usuario; inicio <= segundo_num_usuario; inicio++)
                    {
                        if (inicio % 2 == 0) ;
                        else
                        {
                            Console.Write("{0}; ", inicio);
                        }

                    }
                }
                else
                {
                    for (inicio = primeiro_num_usuario; inicio >= segundo_num_usuario; inicio--)
                    {
                        if (inicio % 2 == 0) ;
                        else
                        {
                            Console.Write("{0}; ", inicio);
                        }

                    }
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não entrou com um número de escolha válido. Retornando-o para o início.");
                Console.ReadKey();
                goto inicio;
            }
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\nTentar novamente? [S/N]");
                escolha_usuario = char.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Pressione qualquer tecla para voltar a sua escolha.");
                Console.ReadKey();
                Console.Clear();
                goto exibicao;

            }
            if (escolha_usuario == 's' || escolha_usuario == 'S')
            {
                goto inicio;
            }
            else if (escolha_usuario == 'n' || escolha_usuario == 'N')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Voltando para o começo.");
                Console.ReadKey();
                Console.Clear();
                goto exibicao;
            }
            Console.ReadKey();
        }
    }
}
