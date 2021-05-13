using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex4_CV
{
    class Program
    {
        static void Main(string[] args)
        { //4. Construa um algoritmo que determine quanto será gasto para encher o tanque de um carro (VG), 
          //sabendo -se que o preço da gasolina é de R$ 1,80 e o preço do álcool é de R$ 1,00. O usuário fornecerá os seguintes dados:
          //Tipo de carro (TC) (G – gasolina ou A – álcool) e Capacidade do tanque (CT), em litros.

            string tc;
            double ct;

            Console.WriteLine("Tipo de carro [G/A]: ");
             tc = Console.ReadLine();
            Console.WriteLine("Capacidade do tanque: ");
            ct = double.Parse(Console.ReadLine());

            if ( tc == "G")
            {
                Console.WriteLine("O preço é: {0}", ct * 1.80);
            }
            if ( tc == "A")
            {
                Console.WriteLine("O preço é: {0}", ct * 1);
            }
            Console.ReadKey();
          
                                 }
    }
}
