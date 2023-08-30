using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_agosto
{
    internal class Contocorrente
    {

        public string Nome{ get; set; }

        public string Cognome { get; set; }

        public int Saldo { get; set; }

        public bool Contoopen=false;



        public Contocorrente() { }
        public Contocorrente(string nome,string cognome ) {
             this.Nome=nome;
                this.Cognome = cognome;
                
                
                
                }

        public void Aperturaconto(double totale)
        {
            Saldo = 0;
            if (totale >= 1000)
            {
                Contoopen = true;
                versamento(totale);
            }
            else Console.WriteLine("Versa di piu");

        }

        public double versamento(double totale)
        {
            return Saldo = (int)(Saldo + totale);
        }


        public double prelievo(double totale)
        {
            return Saldo = (int)(Saldo - totale);
        }

        public string Stato()
        {
            return $"conto di {Nome} {Cognome} e hai {Saldo}";

    }
}
}

