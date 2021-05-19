using System;
using System.Collections.Generic;
using System.Text;

namespace PFO___Exercício
{
    class calcMedia
    {
        public static void Aluno()
        {
            int nt1 = 0, nt2 = 0, nt3 = 0, nt4 = 0, nt5 = 0;
            int soma = 0, media;

            string[] materias = { "Matemática", "Português", "Ciências", "História", "Artes" };
            int[] notas = { nt1, nt2, nt3, nt4, nt5 };

            Console.WriteLine("Mencione as notas nas matérias abaixo:");
            Console.WriteLine(" ");

            for (int i = 0; i < materias.Length && i < notas.Length; i++)
            {
                Console.Write(materias[i] + ": ");
                notas[i] = int.Parse(Console.ReadLine());

                soma += notas[i];
            }

            media = soma / 5;

            Console.Write("___________________________________");

            Console.Write("Media: " + media);
        }
    }
}
