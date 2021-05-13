using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA4_EX13_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Leia uma frase e imprima somente as vogais. \n============================================\n");
            //-------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("Digite uma frase: ");

            int qt_A, qt_E, qt_I, qt_O, qt_U;
            string frase = Console.ReadLine();

            qt_A = frase.Count(qt_a => (qt_a == 'a')); //capturando as vogais na frase
            qt_E = frase.Count(qt_e => (qt_e == 'e'));
            qt_I = frase.Count(qt_i => (qt_i == 'i'));
            qt_O = frase.Count(qt_o => (qt_o == 'o'));
            qt_U = frase.Count(qt_u => (qt_u == 'u'));
            //------------------------------------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("___________________\n");
            Console.WriteLine("Sua frase tem: ");    
            Console.WriteLine("{0} letras A;", qt_A); //exibindo as vogais na frase e apersentando a soma encontrada
            Console.WriteLine("{0} letras E;", qt_E); 
            Console.WriteLine("{0} letras I;", qt_I); 
            Console.WriteLine("{0} letras O;", qt_O);  
            Console.WriteLine("{0} letras U;", qt_U); 
            Console.Write("____________________\n\n");
            Console.Write("Suas vogais são: "); //apresentando a soma
            for (int i = 0; i < qt_A; i++)
            {
                Console.Write("a");
            }
            for (int i = 0; i < qt_E; i++)
            {
                Console.Write("e");
            }
            for (int i = 0; i < qt_I; i++)
            {
                Console.Write("i");
            }
            for (int i = 0; i < qt_O; i++)
            {
                Console.Write("o");
            }
            for (int i = 0; i < qt_U; i++)
            {
                Console.Write("u");
            }
            Console.ReadKey();
        }
    }
}
