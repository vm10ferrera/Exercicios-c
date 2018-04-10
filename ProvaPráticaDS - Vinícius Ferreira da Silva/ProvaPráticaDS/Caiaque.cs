using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Caiaque : Embarcacao
    {
        public override void locomover()
        {
            Console.WriteLine("O caiaque se locomoveu a remo.");
        }
        public override void abastecer()
        {
            Console.WriteLine("O caiaque foi abastecido sendo dependido pela força do remador.");
        }
        public override string ToString()
        {
            return "Caiaque: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu();
        }
    }
}
