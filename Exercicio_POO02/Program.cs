using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercicio02;


namespace Exercicio_POO02
{
    internal class conta
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio POO 02");

            Conta conta2 = new Conta();
            conta2.titular = " Amanda Silva";
            conta2.conta = "111999";
            conta2.numero_agencia = 58;
            conta2.nome_agencia = "Agência Central";
            conta2.saldo = 100;


            Console.WriteLine("Saldo da Amanda pré-saque: R$ "+conta2.saldo);
            conta2.Sacar(-50);
            Console.WriteLine("Saldo da Amanda pós-saque: R$" + conta2.saldo);




            Console.ReadLine();


        }
    }
}
