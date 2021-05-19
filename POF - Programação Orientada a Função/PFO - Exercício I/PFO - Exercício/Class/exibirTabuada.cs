using System;
using System.Collections.Generic;
using System.Text;

namespace PFO___Exercício
{
    class exibirTabuada
    {
        public static void Tabuada(int numero)
        {
            Console.Write("Digite o numero da sua tabuada: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }

    }
}
