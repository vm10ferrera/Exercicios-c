using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Fusca : Carro
    {
        public override void locomover()
        {
            Console.WriteLine("O Fusca se locomoveu com tração em 2 rodas.");
        }
        public override void abastecer()
        {
            Console.WriteLine("O Fusca foi abastecido com gasolina");
        }
        public override string ToString()
        {
            return "Fusca: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getcorCarro();
        }
    }
}
