using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX10_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("10. Acumule cada letra digitada pelo usuário e exiba a palavra completa no final. Deve estabelecer uma quantidade de letras.\n================================================================================\n");
            //-----------------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;

            string frase = "", letra;
            int contador = 0;
            Console.Write("Limite de 100 caracteres.\nEnvie // para finalizar a frase a qualquer momento.\nMáximo de letras = 1.\n\n\nDigite suas letras para serem acumuladas em uma frase: ");
            for (;;)  //loop externa na seção inicializador
            {
                if (contador == 100)
                {
                    break;
                }
                else
                {
                letra:
                    try
                    {
                        letra = Console.ReadLine();
                    }
                    catch
                    {
                        Console.Write("Letra não encontrada. Tente novamente:  ");
                        goto letra;
                    }
                    var count = letra.Count();
                    if (letra == "//")
                    {
                        break;
                    }
                    else if (count > 1)
                    {
                        Console.Write("Letra não encontrada. Tente novamente:  ", letra);
                        goto letra;
                    }
                    else
                    {
                        frase = frase + letra;
                        contador++;
                    }
                }
            }
            Console.Write("Sua frase é: {0}.", frase);
            Console.ReadKey();         
        }
    }
}
