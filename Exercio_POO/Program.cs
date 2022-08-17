using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercio_POO
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Cadastro de Pessoas");

            Pessoa Cadastro1 = new Pessoa();
            Cadastro1.nome = "Pablo Assis";
            Cadastro1.idade = 37;
            Cadastro1.altura = 1.87;
            Cadastro1.peso = 106;

            Console.WriteLine("Nome " + Cadastro1.nome);
            Console.WriteLine("Idade " + Cadastro1.idade);
            Console.WriteLine("Altura " + Cadastro1.altura);
            Console.WriteLine("Peso " + Cadastro1.peso);

            Console.WriteLine();

            Pessoa Cadastro2 = new Pessoa();
            Cadastro2.nome = "Ana Paula Braga";
            Cadastro2.idade = 31;
            Cadastro2.altura = 1.70;
            Cadastro2.peso = 70;

            Console.WriteLine("Nome"+ Cadastro2.nome);
            Console.WriteLine("Nome " + Cadastro2.nome);
            Console.WriteLine("Idade " + Cadastro2.idade);
            Console.WriteLine("Altura " + Cadastro2.altura);
            Console.WriteLine("Peso " + Cadastro2.peso);


            Console.ReadLine();
        }
    }
}
