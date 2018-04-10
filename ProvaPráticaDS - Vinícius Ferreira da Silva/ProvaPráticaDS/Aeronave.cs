using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Aeronave : Veículo
    {
        private String corFuselagem;

        public String getcorFuselagem()
        {
            return corFuselagem;
        }
        public void setcorFuselagem(String corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }

        public void arremeter()
        {
            Console.WriteLine("A aeronave foi arremetida");
        }
        public override string ToString()
        {
            return "Aeronave: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu();
        }
    }
}
