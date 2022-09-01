using Byrebank;
using bytebank;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Andre Silva";
conta1.conta = "10123";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

Console.WriteLine();


ContaCorrente conta2 = new ContaCorrente();
conta2.titular = " Amanda Silva";
conta2.conta = "111999";
conta2.numero_agencia = 58;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;


Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("conta" + conta1.conta);
Console.WriteLine("Numero Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agencia" + conta1.nome_agencia);
Console.WriteLine("Salado   : " + conta1.saldo);

Console.WriteLine();

Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("conta" + conta2.conta);
Console.WriteLine("Numero Agencia: " + conta2.numero_agencia);
Console.WriteLine("Nome da Agencia" + conta2.nome_agencia);
Console.WriteLine("Salado   : " + conta1.saldo);

Cliente cliente = new Cliente();
cliente.nome = "Andre Silva";
cliente.cpf = "071866990";
cliente.profissao = "Programador";

Console.WriteLine("CPF: " + cliente.cpf);


Console.ReadLine();