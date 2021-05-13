using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        { //Elabore um Programa para um caixa eletrônico. 
          //Deverá perguntar ao usuário a valor do saque e depois informar quantas notas de cada valor serão fornecidas.
          //As notas disponíveis serão as de 1, 5, 10, 50 e 100 reais.
          //O valor mínimo de saque é de 10 reais e o máximo de 600 reais.
          //O programa não verifica a quantidade de notas existentes na máquina.
          // Exemplo 1: Para sacar a quantia de 256 reais, o programa fornece duas notas de 100, uma nota de 50, uma nota de 5 e uma nota de 1;
          // Exemplo 2: Para sacar a quantia de 399 reais, o programa fornece três notas de 100, uma nota de 50, quatro notas de 10, uma nota de 5 e quatro notas de 1.

            int valor, resto, n100, n50, n10, n5, n1;


            Console.Write("Digite o valor do saque: ");
            valor = int.Parse(Console.ReadLine());
           

            if (valor >= 10 && valor <= 600)
            {

                n100 = valor / 100; //contagem das notas de 100R$
                resto = valor - (n100 * 100); //valor menos as notas de 100.
                n50 = resto / 50;//contagem das notas de 50R$
                resto = resto - (n50 * 50);
                n10 = resto / 10;//contagem das notas de 10R$
                resto = resto - (n10 * 10);
                n5 = resto / 5;//contagem das notas de 5R$
                resto = resto - (n5 * 5);
                n1 = resto / 1;//contagem das notas de 1R$
                resto = resto - (n1 * 1);

                Console.WriteLine("Quantidade de notas:");
                Console.WriteLine("Notas de 100R$:  " + n100);
                Console.WriteLine("Notas de 50R$:  " + n50);
                Console.WriteLine("Notas de 10R$:  " + n10);
                Console.WriteLine("Notas de 5R$:  " + n5);
                Console.WriteLine("Notas de 1R$:  " + n1);
                
            }
            else
            {
                Console.WriteLine("Notas existentes na máquina, saque de 10 á 600 reais. Por favor!");
            }
            Console.ReadKey();
        }
    }
}
