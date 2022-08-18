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

            Conta conta1 = new Conta();
            conta1.titular = " Marcelo";
            conta1.conta = "20123";
            conta1.numero_agencia = 35;
            conta1.nome_agencia = "Agência Central";
            conta1.saldo = 1070;

            Conta conta2 = new Conta();
            conta2.titular = " Amanda Silva";
            conta2.conta = "111999";
            conta2.numero_agencia = 58;
            conta2.nome_agencia = "Agência Central";
            conta2.saldo = 100;


            Console.WriteLine("Saldo da Amanda pré-saque: R$ "+conta2.saldo);

            bool saque = conta2.Sacar(50);

            Console.WriteLine(" Saque realizado ? " + saque );

            Console.WriteLine("Saldo da Amanda pós-saque:R$" + conta2.saldo);
            conta2.Depositar(60);
            Console.WriteLine(" Saldo da Amanda pós-depósito:R$ " + conta2.saldo);

            Console.WriteLine(" Saldo da Amanda pré-tranferêcia:R$ " + conta2.saldo);
            Console.WriteLine("Saldo do Marcelo pré-tranferência:R$ " + conta1.saldo);
            conta1.Transferir(60, conta2 );
            Console.WriteLine(" Saldo da Amanda pós-tranferêcia:R$ " + conta2.saldo);
            Console.WriteLine("Saldo do Marcelo pós-tranferência:R$ " + conta1.saldo);

            Console.ReadLine();


        }
    }
}
