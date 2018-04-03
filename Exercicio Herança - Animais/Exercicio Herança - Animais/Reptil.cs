using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Reptil : Animal
    {
        String corEscama;

        public string getcorEscama()
        {
            return corEscama;
        }
        public void setcorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }
        public override void seLocomover()
        {
            Console.Write("O animal andou para se locomover");
        }
        public override string ToString()
        {
            return "O Reptil pesa: " + corEscama + ". Tem " + idade + "anos de idade. E possui " + membros + "membros";
        }
    }
}

