using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Carro : Veículo 
    {
        private String corCarro;

        public String getcorCarro()
        {
            return corCarro;
        }
        public void setcorCarro(String corCarro)
        {
            this.corCarro = corCarro;
        }
        public override string ToString()
        {
            return "Carro: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu();
        }
    }
}
