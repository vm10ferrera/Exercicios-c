using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Ave animal2 = new Ave();
            Reptil animal3 = new Reptil();
            Mamifero animal4 = new Mamifero();
            Cachorro animal5 = new Cachorro();
            Tucano animal6 = new Tucano();
            Tartaruga animal7 = new Tartaruga();
            Canguru animal8 = new Canguru();


            animal1.setPeso(50.5f);
            animal1.setIdade(3);
            animal1.setMembros(4);
            
            animal2.setcorPena("Branca com detalhes vermelhos");
            animal1.setPeso(15.5f);
            animal1.setIdade(2);
            animal1.setMembros(2);
            
            animal3.setcorEscama("Verde");
            animal1.setPeso(25.5f);
            animal1.setIdade(5);
            animal1.setMembros(4);

            animal4.setcorPelo("Preto");
            animal4.setraca("Urso");
            animal1.setPeso(180f);
            animal1.setIdade(6);
            animal1.setMembros(4);

            animal5.setPeso(50.5f);
            animal5.setIdade(3);
            animal5.setMembros(4);
            animal5.reagir(true);
            animal5.reagir(14, 53);
            animal5.reagir("brincar");
           
            animal6.setPeso(50.5f);
            animal6.setIdade(3);
            animal6.setMembros(4);

            animal7.setPeso(50.5f);
            animal7.setIdade(3);
            animal7.setMembros(4);

            animal8.setPeso(50.5f);
            animal8.setIdade(3);
            animal8.setMembros(4);

            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());
            Console.WriteLine(animal4.ToString());

            


            Console.ReadKey();
        }
    }
}
