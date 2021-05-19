using System;
using System.IO;

namespace PFO___Exercício
{
    class Program
    {        
        static void Main(string[] args)
        {
            while (true)
            {
                string mensagem = "\n\nOlá usuário, bem vindo ao programa, utilizando programação funcional." + 
                                  "\nDigite uma das opções abaixo:\n" +
                                  "\n0 = Sair do programa" +
                                  "\n1 = Para ler arquivos" +
                                  "\n2 = Para execultar a tabuada" +
                                  "\n3 = Para calcular a media de alunos" +
                                  "\n____________________________________________________";

                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 0:
                        break;
                    case 1:
                        lerArquivo.Arquivo();
                        break;
                    case 2:
                        exibirTabuada.Tabuada(2);
                        break;
                    case 3:
                        calcMedia.Aluno();
                        break;
                    default:
                        Console.WriteLine("Digite apenas os números mencionado acima.");
                        break;
                }               
            }
        }
    }
}
