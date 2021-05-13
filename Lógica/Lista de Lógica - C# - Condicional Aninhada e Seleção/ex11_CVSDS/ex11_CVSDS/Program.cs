using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        { //11. Elabore um programa que receba a altura e peso de uma pessoa e calcule seu índice de massa corporal (IMC). 
          //Pesquise na Internet a expressão para calcular esse índice.
          // Apresente uma mensagem personalizada para cada valor calculado conforme as faixas atuais para o IMC.
            float A, P, imc;
            Console.Write("Digite o seu peso:");
            P = float.Parse(Console.ReadLine());
            Console.Write("Digite o seu altura:");
            A = float.Parse(Console.ReadLine());
            imc = (P / (A * A));
            if (imc < 17)
            {
                Console.WriteLine("Muito abaixo do normal");
            }
            else if (imc >= 17 && imc < 18.5)
            {
               Console.WriteLine("Abaixo do peso");
            }
             else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine(" Acima do peso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc >= 35 && imc < 40)
            {              
                Console.WriteLine("Obesidade Grau II");
            }          
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }
            Console.ReadKey();




        }
    }
}
