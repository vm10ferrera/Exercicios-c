using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Cachorro : Mamifero
    {
        public void enterrarOsso()
        {
        }
        public void abanarRabo()
        {
        }
        public String reagir(String atitude = "brincar")
        {
            if (atitude == "brincar" || atitude == "acariciar")
            {
                Console.WriteLine("Abana o rabo");
            }
            else
                Console.WriteLine("Rosna");
            }

        public int reagir(int hora = 14, int min = 53)
        {
            if (hora<12)
            {
                Console.WriteLine("Abanar o rabo e late");
            }
            else if(hora>=18)
                Console.WriteLine("Não liga para o dono");
            
            else
                Console.WriteLine("Abana o rabo");
        }
        public Boolean reagir(Boolean dono = true)
        {
            if (dono == true)
            {
                Console.WriteLine("Abana o rabo e brinca");
            }
            else
                Console.WriteLine("Avança e Rosna");
        }

    }
}
