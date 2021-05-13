using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex16_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            double PE;
            string CP;

            Console.WriteLine("Digite o preço da etiqueta");
            PE = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a condição de pagamento:");
            CP = Console.ReadLine();

            if (CP == "1")
            {
                Console.WriteLine("À vista em dinheiro ou cheque, com 10% de desconto");
                Console.WriteLine("valor da compra: {0}", PE / 1.10);
            }
            if (CP == "2")
            {
                Console.WriteLine("À vista com cartão de crédito, com 5% de desconto");
                Console.WriteLine("valor da compra: {0}", PE / 1.05);

            }
            if (CP == "3")
            {
                Console.WriteLine("Em 2 vezes, preço normal de etiqueta sem juros");
                Console.WriteLine("valor da compra: {0}", PE / 2);
            }
            if (CP == "4")
            {
                Console.WriteLine("Em 3 vezes, preço de etiqueta com acréscimo de 10%");
                Console.WriteLine("valor da compra: {0}", (PE * 1.10) / 3);
            }
            Console.ReadKey();
        }
    }
}
