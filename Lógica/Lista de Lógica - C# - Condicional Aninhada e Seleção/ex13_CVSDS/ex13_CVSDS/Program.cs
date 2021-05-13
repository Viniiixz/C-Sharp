using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {       //Ler o nome, as três notas e o número de faltas de um aluno e escrever qual a sua situação final:
                //aprovado; Reprovado por Falta ou Reprovado por Média.
                // a média para a provação é 7,0 
                // limite de faltas é 25 % do total de aulas 
                //Foram ministradas 80 aulas no semestre 
                //a reprovação por falta sobrepõe a reprovação por Média.

            string nome;
            double n1, n2, n3, nf, na;

            Console.Write("Digite o nome do aluno:");
            nome = Console.ReadLine();
            Console.Write("Digite a nota da prova:");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do trabalho:");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do caderno:");
            n3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o número de faltas do aluno:");
            nf = double.Parse(Console.ReadLine());
            na = (n1 + n2 + n3) / 3;
            if(nf < 20)
            {
                Console.WriteLine("Aluno aprovado");
                Console.WriteLine("A nota final do aluno é: {0}", na);
                Console.WriteLine("O aluno teve {0} faltas", nf);
            }
            else
            {
                Console.WriteLine("O aluno foi reproavdo por falta");
                Console.WriteLine("A nota final do aluno é: {0}", na);
                Console.WriteLine(" O aluno teve {0} faltas", nf);
            }
            if (na < 7)
            {
                Console.WriteLine("Aluno reprovado por média");
                Console.WriteLine("A nota final do aluno é:{0}", na);
                Console.WriteLine("O aluno teve {0} faltas", nf);
            }
            Console.ReadKey();
        }
    }
}
