using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex13_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            double caixa, qtd, pr, vc, pctg, juros;

            Console.WriteLine("Quantidade de dinheiro no caixa:");
            caixa = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de produto a comprar:");
            qtd = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de cada unidade:");
            pr = double.Parse(Console.ReadLine());
            vc = qtd * pr;
            pctg = caixa * 80 / 100;
              
            if (vc > pctg)
            {
                juros = vc * 0.10;
                Console.WriteLine("A forma de pagamento é: Á prazo ");
                Console.WriteLine("O pagamento será feito em 3x de: {0}", vc + juros / 3);
            }
            else
            {
                Console.WriteLine("A forma de pagamento é: Á vista");
                Console.WriteLine("O total a vista será: {0}", vc - vc *0.05);
            }
            Console.ReadKey();

        }
    }
}
