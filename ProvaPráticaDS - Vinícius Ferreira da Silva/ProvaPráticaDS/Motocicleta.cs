using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Motocicleta : Veículo
    {
        private String corMotocicleta;

        public String getcorMotocicleta()
        {
            return corMotocicleta;
        }
        public void setcorMotocicleta(String corMotocicleta)
        {
            this.corMotocicleta = corMotocicleta;
        }
        public override string ToString()
        {
            return "Motocicleta: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu();
        }
    }
}
