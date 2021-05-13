using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um programa que: Leia 4 números e calcule o quadrado de cada um. 
            //Se o valor resultante do quadrado do terceiro for maior ou igual a 1000, exiba o valor. 
            //Caso contrário, mostre os valores lidos e seus respectivos quadrados.

            double num1, num2, num3, num4;
            Console.Write("Informe o primeiro numero:");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo numero:");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro numero:");
            num3 = double.Parse(Console.ReadLine());
            Console.Write("Informe o quarto numero:");
            num4 = double.Parse(Console.ReadLine());

            if (num1 >= 0)
            {
                Console.WriteLine("O valor do quadrado do primeiro é {0}",  num1 * num1);
            }
            if (num2 >= 0)
            {
                Console.WriteLine("O valor do quadrado do segundo é {0}",  num2 * num2);
            }
            if (num3 <= 1000)
            {
                Console.WriteLine("O valor do quadrado do terceiro é {0}", num3 * num3);
            }       
            if (num4 >= 0)
            {
                Console.Write("O valor do quadrado do quarto é: {0}", num4 * num4);
            }
     
            Console.ReadKey();
        }      
    }
}
