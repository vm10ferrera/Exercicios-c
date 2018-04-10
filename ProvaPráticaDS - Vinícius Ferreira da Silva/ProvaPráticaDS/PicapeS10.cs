using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class PicapeS10 : Carro
    {
         public override void locomover()
        {
            Console.WriteLine("A Picape se locomoveu com tração em 4 rodas.");
        }
        public override void abastecer()
        {
            Console.WriteLine("A Picape foi abastecida com Diesel.");
        }
        public override string ToString()
        {
            return "PicapeS10: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getcorCarro();
        }
    }
}
