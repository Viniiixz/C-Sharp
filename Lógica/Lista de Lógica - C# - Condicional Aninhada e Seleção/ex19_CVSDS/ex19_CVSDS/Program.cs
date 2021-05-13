using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex19_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 35,00, 
            //ele receberá um desconto de 10 %. Escreva um programa para ler a quantidade (em Kg) de morangos e a 
            //quantidade(em Kg) de maças adquiridas e escreva o valor a ser pago pelo cliente

            double kgmc, kgmo;

            Console.Write("Digite quantos kg de morangos você deseja comprar:");
            kgmc = double.Parse(Console.ReadLine());
            Console.Write("Digite quantos kg de maças você deseja comprar:");
            kgmo = double.Parse(Console.ReadLine());
            
          
            if (kgmc >= 8 || kgmc >= 35 )
            {
                Console.WriteLine("Valor de maças a ser pago R$:{0}", kgmc - 0.10);
            }
            if (kgmo >= 8 || kgmo >= 35)
            {
                Console.WriteLine("Valor de morango a ser pago R$:{0}", kgmo - 0.10);
            }
            Console.ReadKey();



        }
    }
}
