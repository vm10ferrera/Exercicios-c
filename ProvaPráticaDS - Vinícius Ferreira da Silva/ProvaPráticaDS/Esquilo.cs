using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Esquilo : Aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("A aeronave esquilo se locomoveu através de sua hélice.");
        }
        public override void abastecer()
        {
            Console.WriteLine("A aeronave esquilo foi abastecida com Diesel.");
        }
        public override string ToString()
        {
            return "Esquilo: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getcorFuselagem();
        }
    }
    }

