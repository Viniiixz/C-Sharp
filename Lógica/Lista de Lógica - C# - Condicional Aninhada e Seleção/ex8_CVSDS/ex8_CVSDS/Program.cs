using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {    //8. Fazer um algoritmo que leia uma quantidade de itens comprados (HAM, CHE, FRITAS, REFRI, MILK),
             //bem como seus custos ( C1, C2, C3, C4, C5 ) e calcule a conta final. 
             // As variáveis relativas aos itens comprados são inteiras e as variáveis relativas a custo são reais.

            int ham, che, fritas, refri, milk;
            float c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
            Console.Write("Digite a quantidade de hamburger: ");
            ham = int.Parse(Console.ReadLine());
            if (ham < 0)
            {

            }
            else
            {
                Console.Write("O custo do hamburger R$: ");
                c1 = float.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de queijo: ");
                che = int.Parse(Console.ReadLine());
                if (che < 0)
                {

                }
                else
                {
                    Console.Write("O custo do queijo é: ");
                    c2 = float.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade de fritas: ");
                    fritas = int.Parse(Console.ReadLine());
                    if (fritas < 0)
                    {

                    }
                    else
                    {
                        Console.Write("O curto das fritas é: ");
                        c3 = float.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade de refrigerante: ");
                        refri = int.Parse(Console.ReadLine());
                        if (refri < 0)
                        {

                        }
                        else
                        {
                            Console.Write("O custo dos refrigerantes é: ");
                            c4 = float.Parse(Console.ReadLine());
                            Console.Write("Digite a quantidade de milkshakes: ");
                            milk = int.Parse(Console.ReadLine());
                            if (milk < 0)
                            {

                            }
                            else
                            {
                                Console.Write("O custo dos milkshakes é: ");
                                c5 = float.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("O valor total é: {0}", (ham * c1) + (che * c2) + (fritas * c3) + (refri * c4) + (milk * c5));
                            }
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
