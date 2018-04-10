using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Legacy450 : Aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("A aeronave Legacy450 se locomoveu");
        }
        public override void abastecer()
        {
            Console.WriteLine("A aeronave Legacy450 foi abastecida");
        }
        public String decolar(String Clima = "sol")
        {
            if ("Clima" == "sol")
            {
                Console.WriteLine("Voo Normal");
                return Clima;
            }
            else if ("Clima" == "chuva e nublado")
            {
                Console.WriteLine("Voo por instrumento");
                return Clima;
            }
            else
                Console.WriteLine("Sem voo");
            return Clima;
        }
        public int decolar(int horario = 13)
        {
            if (horario >= 01 && horario <= 12)
            {
                Console.WriteLine("O voo partirá de manhã e estará em sua altitude mais alta");
                return horario;
            }
            else if (horario >= 13 && horario <= 18)
            {
                Console.WriteLine("O voo partirá de tarde e estará em sua altitude média");
                return horario;
            }
            else
                Console.WriteLine("O voo partirá de noite e estará em sua altitude baixa");
            return horario;
        }

            public Boolean decolar(Boolean passageiros)
        {
            if (passageiros == true)
            {
                Console.WriteLine("A aeronave servirá refeição");
            }
            else
                Console.WriteLine("A carga será amarrada");
            return passageiros;
        }
            public override string ToString()
            {
                return "Legacy450: \nMarca = " + getMarca() + "\nAno = " + getAno() + "\nPneu = " + getPneu() + "\nCor = " + getcorFuselagem();
            }

        }
    }


