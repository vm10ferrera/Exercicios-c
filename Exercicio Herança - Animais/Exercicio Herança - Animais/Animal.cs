using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    public class Animal
    {
        public float peso;
        public int idade;
        public int membros;

        public virtual void seLocomover()
        {
            Console.Write("O animal se locomoveu");
        }
        public void seAlimentar()
        {
            Console.Write("O animal se alimentou");
        }
        public void emitirSom()
        {
            Console.Write("O animal emitiu um som");
        }
        public float getPeso()
        {
            return peso;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getMembros()
        {
            return membros;
        }
        public void setMembros(int membros)
        {
            this.membros = membros;
        }
        public override string ToString()
        {
            return "O animal pesa: " + peso + ". Tem " + idade + "anos de idade. E possui " + membros + " membros.";
        }
            
    }
}
