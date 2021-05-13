using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex3_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construa um algoritmo que, tendo como dados de entrada a altura (H) e o sexo (S) de uma pessoa calcule e apresente seu peso ideal utilizando as seguintes fórmulas  
            //Para homens: Peso ideal (P) = (72, 7 * H) – 58 
            //Para mulheres: Peso ideal (P) = (62, 1 * H) – 44,7
            //Variavel
            double H;
            string S;

            Console.WriteLine("Digite sua altura:");
            H = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sexo[H/M]: ");
            S = Console.ReadLine();
            //Calculo
            if (S == "H")
            {
                
                Console.WriteLine("seu peso ideal é: {0}", (72.7 * H) - 58);
                Console.ReadKey();
            }

            if (S == "M")
            {
                Console.WriteLine("seu peso ideal é: {0}", (62.1 * H) - 44.7);
                Console.ReadKey();
            }

        }
    }
}
