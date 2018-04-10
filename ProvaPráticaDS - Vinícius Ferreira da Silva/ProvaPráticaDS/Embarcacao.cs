using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Embarcacao : Veículo
    {
        private String corCasco;

        public String getcorCasco()
        {
            return corCasco;
        }
        public void setcorCasco(String corCasco)
        {
            this.corCasco = corCasco;
        }

        public void ancorar()
        {
            Console.WriteLine("A enbarcação está ancorada");
        }
        public override string ToString()
        {
            return "Embarcação: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu();
        }
    }
}
