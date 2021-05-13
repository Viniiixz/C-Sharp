using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex6_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {//Construa um algoritmo que leia o preço de um produto (P) e apresente a mensagem:
         //“Em promoção”, caso o preço seja maior ou igual a R$ 50,00 e menor ou igual a R$ 100,00. 
         //Caso contrário, deve apresentar a mensagem: “Preço Normal”.

            //variavel
            float p;
            //algoritimo
            Console.WriteLine("Preco do produto:");
            p = float.Parse(Console.ReadLine());
            if (p >= 50)
            {             
                Console.WriteLine("Em promoção", p);
            }
            else if (p <= 100) 
            {
                Console.WriteLine("Em promoção", p);                
            }
            Console.WriteLine("Preço normal", p < 100);
            Console.ReadKey();

        }
    }
}
