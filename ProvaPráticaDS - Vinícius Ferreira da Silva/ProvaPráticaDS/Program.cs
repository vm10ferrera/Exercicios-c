using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaPraticaDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Veículo Veiculo1 = new Veículo();
            Carro Veiculo2 = new Carro();
            Fusca Veiculo3 = new Fusca();
            PicapeS10 Veiculo4 = new PicapeS10();
            Motocicleta Veiculo5 = new Motocicleta();
            Cb200 Veiculo6 = new Cb200();
            Embarcacao Veiculo7 = new Embarcacao();
            Caiaque Veiculo8 = new Caiaque();
            Aeronave Veiculo9 = new Aeronave();
            Esquilo Veiculo10 = new Esquilo();
            Legacy450 Veiculo11 = new Legacy450();


            Veiculo1.setMarca("BMW");
            Veiculo1.setAno(2000);
            Veiculo1.setPneu(4);

            Veiculo2.setMarca("Audi");
            Veiculo2.setAno(2003);
            Veiculo2.setPneu(4);
            Veiculo2.setcorCarro("Preto");

            Veiculo3.setMarca("Volkswagen");
            Veiculo3.setAno(2005);
            Veiculo3.setPneu(4);
            Veiculo3.setcorCarro("Branco");

            Veiculo4.setMarca("Chevrolet");
            Veiculo4.setAno(2017);
            Veiculo4.setPneu(4);
            Veiculo4.setcorCarro("Azul");

            Veiculo5.setMarca("Honda");
            Veiculo5.setAno(2012);
            Veiculo5.setPneu(2);
            Veiculo5.setcorMotocicleta("Preta");

            Veiculo6.setMarca("Kawasaki Ninja");
            Veiculo6.setAno(2012);
            Veiculo6.setPneu(2);
            Veiculo6.setcorMotocicleta("Verde");

            Veiculo7.setMarca("Amerigo Vespucci");
            Veiculo7.setAno(1950);
            Veiculo7.setPneu(0);
            Veiculo7.setcorCasco("Preto e Azul");

            Veiculo8.setMarca("Caiaque Lontras");
            Veiculo8.setAno(2006);
            Veiculo8.setPneu(0);
            Veiculo8.setcorCasco("Preta");

            Veiculo9.setMarca("Agusta");
            Veiculo9.setAno(2003);
            Veiculo9.setPneu(3);
            Veiculo9.setcorFuselagem("Branco");

            Veiculo10.setMarca("Helibrás");
            Veiculo10.setAno(2015);
            Veiculo10.setPneu(0);
            Veiculo10.setcorFuselagem("Preto");

            Veiculo11.setMarca("Embraer");
            Veiculo11.setAno(2015);
            Veiculo11.setPneu(6);
            Veiculo11.setcorFuselagem("Vermelho");

            Console.WriteLine(Veiculo1.ToString());
            Veiculo1.locomover();
            Veiculo1.abastecer();
            Console.WriteLine(Veiculo2.ToString());
            Console.WriteLine(Veiculo3.ToString());
            Veiculo3.locomover();
            Veiculo3.abastecer();
            Console.WriteLine(Veiculo4.ToString());
            Veiculo4.locomover();
            Veiculo4.abastecer();
            Console.WriteLine(Veiculo5.ToString());
            Console.WriteLine(Veiculo6.ToString());
            Veiculo6.locomover();
            Veiculo6.abastecer();
            Console.WriteLine(Veiculo7.ToString());
            Veiculo7.ancorar();
            Console.WriteLine(Veiculo8.ToString());
            Veiculo8.locomover();
            Veiculo8.abastecer();
            Veiculo8.ancorar();
            Console.WriteLine(Veiculo9.ToString());
            Veiculo9.arremeter();
            Console.WriteLine(Veiculo10.ToString());
            Veiculo10.locomover();
            Veiculo10.abastecer();
            Veiculo10.arremeter();
            Console.WriteLine(Veiculo11.ToString());
            Veiculo11.locomover();
            Veiculo11.abastecer();
            Veiculo11.arremeter();
            Veiculo11.decolar("sol");
            Veiculo11.decolar(19);
            Veiculo11.decolar(true);




            Console.ReadKey();
        }
    }
}
