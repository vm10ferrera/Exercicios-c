using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Ave : Animal
    {
        String corPena;

        public void fazerNinho()
        {
            Console.Write("A ave fez um ninho");
        }
        public String getCorPena()
        {
            return corPena;
        }
        public void setcorPena(String corPena)
        {
            this.corPena = corPena;
        }

        public override void seLocomover()
        {
            Console.Write("O animal voou para se locomover");
        }
        public override string ToString()
        {
            return "A cor da pena é: " + corPena + '.';
        }
    }
}

