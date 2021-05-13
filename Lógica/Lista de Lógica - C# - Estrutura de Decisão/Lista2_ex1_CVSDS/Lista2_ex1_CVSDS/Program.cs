using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex1_CVSDS
{
    class Program
    {
        static void Main(string[] args)

        {  
            //  Construa um algoritmo que leia o valor de uma conta de luz (CL)e, caso o valor seja maior que R$ 50, 00 apresente a mensagem:
            //     “Você está gastando muito”. Caso contrário não exiba mensagem nenhuma.

            //Variaveis
            float CL;

            //Algoritimo
            Console.WriteLine("Digite o valor da conta de luz:");
            CL = float.Parse(Console.ReadLine());

            if (CL > 50)
            {
                Console.WriteLine("Você está gastando muito!");
            }
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadKey();     //ler um(qualquer) tecla
        }
    }
}








 
