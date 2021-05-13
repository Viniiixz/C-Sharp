using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        { //12. Em uma Quitanda cada maçã avulsa custa R$ 0,50. Para uma quantidade maior ou igual a 12 cada maçã irá custar R$0,40. 
         // Elabore um programa que leia o número de maçãs compradas, calcule o valor a ser pago e escreva na tela o valor total da compra.

            double mc;

            Console.Write("Digite o número de maças compradas:");
            mc = double.Parse(Console.ReadLine());


            if (mc >= 12)
            {
                Console.Write("Valor a ser pago:{0}", mc*0.40 );
            }
            else if (mc <= 12)
            {
                Console.Write("Valor a ser pago:{0}", mc*0.50);
            }
            Console.ReadKey();


        }
    }
}
