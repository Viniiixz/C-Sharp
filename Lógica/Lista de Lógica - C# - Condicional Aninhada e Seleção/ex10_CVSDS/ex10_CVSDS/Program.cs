using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.Faça um programa que leia dois valores: o primeiro servindo de indicador de operação e o segundo correspondendo ao raio de uma circunferência.
            // Caso o primeiro valor lido seja igual a 1, calcular e exibir a área do círculo.Se o valor lido for 2, calcular e exibir o perímetro da circunferência.
            //Caso o valor lido seja diferente destes dois valores, exibir uma mensagem de operador inválido.
            Console.Write("Digite o raio:");
            float raio = float.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a operação \n[1] area do circulo \n[2] perimetro da circunferencia");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    Console.WriteLine("O resulatdo da operação deu: "  + Math.PI * Math.Pow(raio, 2));
                    break;
                case 2:
                    Console.WriteLine("O resulatdo da operação deu: " + 2 * +Math.PI * raio);
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    break;
            }
            Console.ReadKey();

            }           
        }
      
    }
