using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Mamifero : Animal
    {
        String corPelo;
        String raca;

        public string getCorPelo()
        {
            return corPelo;
        }
        public void setcorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }
        public string getRaca()
        {
            return raca;
        }
        public void setraca(string raca)
        {
            this.raca = raca;
        }

        public override void seLocomover()
        {
            Console.Write("O animal andou para se locomover");
        }
        public override string ToString()
        {
            return "O Mamifero pesa: " + peso + ". Tem " + idade + "anos de idade. E possui " + membros + "membros";
        }
    }
}

