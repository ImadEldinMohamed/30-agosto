using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_agosto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contocorrente contocorrente = new Contocorrente();
            contocorrente.Nome = "pino";
            contocorrente.Cognome = "gino";
            contocorrente.Saldo = 500;
            Console.WriteLine(contocorrente.Saldo);
          

            Contocorrente contocorrente1 = new Contocorrente();
            Console.WriteLine("nome intestatario");
            string nome=Console.ReadLine();
            Console.WriteLine("cognome intestatario");
            string cognome = Console.ReadLine();
            Console.WriteLine("conto");
          
            contocorrente1.Nome = "pippo";
            contocorrente1.Cognome = "baudo";
            contocorrente1.Aperturaconto(5000);
            contocorrente1.prelievo(522);
            contocorrente1.versamento(9555);
            Console.WriteLine(contocorrente1.Stato());

            



            //esercizio 2 array



            string n;
            string[] array = new string[8];
            for(int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("nome");
                n = Console.ReadLine();
                array[i] = n;
            }
          
        }
    }
}
