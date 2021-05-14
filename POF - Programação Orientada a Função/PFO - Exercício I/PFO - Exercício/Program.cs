using System;
using System.IO;

namespace PFO___Exercício
{
    class Program
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

        public static void lerArquivo()
        {
            string nomeArquivo;

            Console.Write("Digite o arquivo que deseja ler: ");
            nomeArquivo = Console.ReadLine();

            string arquivoComCaminho = @"D:\Projetos GitHub\C-Sharp\POF - Programação Orientada a Função\PFO - Exercício I\" + nomeArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    var a = 0;
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(+a + ". " + linha);
                        a++;
                    }
                }

                Console.WriteLine("____________________________________________");
            }
            else{
                Console.WriteLine("Não existe um arquivo para ler no caminho mencionado.");
            }
        }

        public static void calcMedia()
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

            Console.Write("Media: " + media);
        }

        static void Main(string[] args)
        {

            while (true)
            {
                string mensagem = "\n\nOlá usuário, bem vindo ao programa, utilizando programação funcional." + "\nDigite uma das opções abaixo:\n" +
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
                        lerArquivo();
                        break;
                    case 2:
                        Tabuada(2);
                        break;
                    case 3:
                        calcMedia();
                        break;
                    default:
                        Console.WriteLine("Digite apenas os números mencionado acima.");
                        break;
                }               
            }
        }
    }
}
