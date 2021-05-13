using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma empresa irá dar uma gratificação de Natal a seus funcionários. Esta gratificação é calculada com base no número de horas extras trabalhadas e no número de horas de faltas.
            //A expressão que calcula o prêmio é: Extras – (2 / 3) * Faltas e a distribuição do prêmio é feita conforme a tabela ao lado.
            //Elabore um programa que leia as informações necessárias de um funcionário, conforme descrito, calcule e apresente o prêmio a ser concedido.
            
            float hrex, faltas, pr;
            Console.Write("Digite o número de horas trabalhadas: ");
            hrex = float.Parse(Console.ReadLine());
            Console.Write("Digite o número de horas de faltas: ");
            faltas = float.Parse(Console.ReadLine());
            pr = (2 / 3) * faltas;
            if (hrex > 40)
            {
                Console.WriteLine("Seu prêmio é: R$50,00");
            }
            if (hrex > 30 && hrex <= 40)
            {
                Console.WriteLine("Seu prêmio é: R$40,00");
            }
            if (hrex > 20 && hrex <= 30)
            {
                Console.WriteLine("Seu prêmio é: R$30,00");
            }
            if (hrex > 10 && hrex <= 20)
            {
                Console.WriteLine("Seu prêmio é: R$20,00");
            }
            if (hrex <= 10)
            {
                Console.WriteLine("Seu prêmio é: R$10,00");
            }
            Console.ReadKey();
        }
    }
}
    

