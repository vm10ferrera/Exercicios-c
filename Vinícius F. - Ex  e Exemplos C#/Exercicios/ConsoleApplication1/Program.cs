using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            string nome, cidade;
            int idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite sua cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n==============Suas informações=================");
            Console.WriteLine("{0} tem {1} anos e mora em {2} ", nome, idade, cidade);
            Console.ReadKey();

            //Exercicio 02
            Console.Write("\n================================\n");
            int n, n2;
            Console.Write("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());
            n2 = n * 2;

            Console.Write("O dobro do número {0} é: {1}", n, n2);

            Console.ReadKey();

            //Exercicio 03
            Console.Write("\n================================\n");
            int nu;
            double n1, nq;
            Console.Write("Digite um número: ");
            nu = int.Parse(Console.ReadLine());
            n1 = nu;

            nq = Math.Pow(n1, 2);
            Console.WriteLine("Número {0} ao quadrado é: {1} ", n1, nq);

            Console.ReadKey();

            //Exercicio 04
            Console.Write("\n================================\n");
            double a, b, c, rt;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            rt = (Math.Pow(a, 2)) * 5 - c / (b - a % 4);
            Console.Write("Resultado é: {0}", rt);


            Console.ReadKey();

            //Exercicio 05
            Console.Write("\n================================\n");
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade < 18)
            {
                Console.Write("Você é menor de idade");
            }
            else
                Console.Write("Você é maior de idade");

            Console.ReadKey();

            //Exercicio 06
            Console.Write("\n================================\n");
            double r, d;
            Console.Write("Digite a sua quantidade em R$: ");
            r = double.Parse(Console.ReadLine());
            d = r * 3.20;
            Console.WriteLine("A quantidade de R$ {0} será {1} em dólares", r, d);
            Console.ReadKey();
        }
    }
}
