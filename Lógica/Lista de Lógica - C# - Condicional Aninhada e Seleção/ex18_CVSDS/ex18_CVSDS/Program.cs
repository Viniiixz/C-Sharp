using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18_CVSDS
{
    class Program
    {
        static void Main(string[] args)
        {   //Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
            //• "Telefonou para a vítima?"
            //• "Esteve no local do crime?"
            //• "Mora perto da vítima?"
            //• "Devia para a vítima?"
            //• "Já trabalhou com a vítima?"
            //O programa deve no final emitir uma classificação sobre a participação da pessoa no crime.
            //Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita",
            //entre 3 e 4 como "Cúmplice" e 5 como "Assassino".Caso contrário, ele será classificado como "Inocente".

            string r1, r2, r3, r4, r5, s, n;
          

            Console.Write("Responda com [Sim] ou [Nao]");
            Console.Write("Telefonou para a vitima?");
            r1 = Console.ReadLine();
             

            if (r1 == "sim")
                    {
                      s = s + 1;
                    }
                     else if (r1 == "nao")
                    {
                      n = n + 1;
                    {
                    Console.Write("Esteve no local do crime?");
                    r2 = Console.ReadLine();

                    if (r2 == "sim")
                    {
                        s = s + 1;
                    }
                    else if (r2 == "nao")
                    {
                        n = n + 1;
                    }
                    Console.Write("Mora perto da vitima?");
                    r3 = Console.ReadLine();

                    if (r3 == "sim")
                    {
                        s = s + 1;
                    }

                    else if (r3 == "nao")
                    {
                        n = n + 1;
                    }
                    Console.Write("Devia para a vitima?");
                    r4 = Console.ReadLine();

                    if (r4 == "sim")
                    {
                        s = s + 1;
                    }
                    else if (r4 == "nao")
                    {
                        n = n + 1;
                    }
                    Console.Write("Ja trabalhou com a vitima?");
                    r5 = Console.ReadLine();

                    if (r5 == "sim")
                    {
                        s = s + 1;
                    }
                    else if (r5 == "nao")
                    {
                        n = n + 1;
                    }

                    Console.Write("sim", s);
                    Console.Write("nao", n);

                        if (s = 2)
                        {
                            Console.WriteLine("Suspeita");
                        }
                        else if (s = 3)
                        {
                            Console.WriteLine("Cumplice");
                        }
                        else if (s = 4)
                        {
                            Console.WriteLine("Cumplice");
                        }
                        else if (s = 5)
                        {
                            Console.WriteLine("Assasino");
                        }
                        else
                        {
                            Console.WriteLine("Inocente");
                        }
                    Console.ReadKey();
                }
            }
        }
    }
}
