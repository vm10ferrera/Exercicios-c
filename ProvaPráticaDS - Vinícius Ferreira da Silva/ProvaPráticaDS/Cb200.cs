using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Cb200 : Motocicleta
    {
        public override void locomover()
        {
            Console.WriteLine("A moto se locomoveu com tração na roda traseira.");
        }
        public override void abastecer()
        {
            Console.WriteLine("A moto foi abastecida com Álcool.");
        }
        public override string ToString()
        {
            return "Cb200: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getcorMotocicleta();
        }
    }
}
