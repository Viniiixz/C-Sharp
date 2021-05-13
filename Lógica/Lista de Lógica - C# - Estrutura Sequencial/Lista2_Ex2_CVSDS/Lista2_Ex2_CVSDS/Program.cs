using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Ex2_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construa um algoritmo que leia o valor de uma conta de luz (CL) e, caso o valor seja maior que R$ 50,00 apresente a mensagem: “Você está gastando muito”. Caso contrário exiba a mensagem: “Seu gasto foi normal”.

            //Variavel
            float CL;
            //Algoritimo
            Console.WriteLine("Digite o valor da conta:");
            CL = float.Parse(Console.ReadLine());

            if (CL > 50) 
            {
                Console.WriteLine("Você está gastando muito!");
            } 
            else if (CL < 0)
            {
                Console.WriteLine("Valor não pode ser negativo");
            }
            else
            {
                Console.WriteLine("Seu gasto foi normal");             
            }
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadKey();     
        }
    }
}
