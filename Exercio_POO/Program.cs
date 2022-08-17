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
            Cadastro1.idade = 23;
            Cadastro1.altura = 1.87;
            Cadastro1.peso = 106;

            Console.WriteLine("Nome " + Cadastro1.nome);
            Console.WriteLine("Idade " + Cadastro1.idade);
            Console.WriteLine("Altura " + Cadastro1.altura);
            Console.WriteLine("Peso " + Cadastro1.peso);

            Console.ReadLine();
        }
    }
}
