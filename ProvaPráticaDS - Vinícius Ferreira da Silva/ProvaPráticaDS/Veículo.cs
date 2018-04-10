﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Veículo
    {
        private String marca;
        private int ano;
        private int pneu;

        public String getMarca()
        {
            return marca;
        }
        public void setMarca(String marca)
        {
            this.marca = marca;
        }

        public int getAno()
        {
            return ano;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public int getPneu()
        {
            return pneu;
        }
        public void setPneu(int pneu)
        {
            this.pneu = pneu;
        }

        public virtual void locomover()
        {
            Console.WriteLine("O veículo se locomoveu");
        }
        public virtual void abastecer()
        {
            Console.WriteLine("O veículo foi abastecido");
        }
        public override string ToString()
        {
            return "Veículo: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu();
        }
    }
}
