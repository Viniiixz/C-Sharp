using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PFO___Exercício
{
    class lerArquivo
    {
        public static void Arquivo()
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
            else
            {
                Console.WriteLine("Não existe um arquivo para ler no caminho mencionado.");
            }
        }
    }
}
