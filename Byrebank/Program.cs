using bytebank;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Pablo Assis";
conta1.conta = "4026-10";
conta1.numero_agencia = 23 ;
conta1.nome_agencia = "Bradesco";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = " Samuel Assis";
conta2.conta = "4026-20";
conta2.numero_agencia = 70;
conta2.nome_agencia = "Santander";
conta2.saldo = 1200;


Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("conta" + conta1.conta);
Console.WriteLine("Numero Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agencia" + conta1.nome_agencia);
Console.WriteLine("Salado   : " + conta1.saldo);

Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("conta" + conta2.conta);
Console.WriteLine("Numero Agencia: " + conta2.numero_agencia);
Console.WriteLine("Nome da Agencia" +  conta2.nome_agencia);
Console.WriteLine("Salado   : " + conta2.saldo);

Console.ReadLine();