namespace bytebank
   
{
    public class ContaCorrente
    {
        public string titular_nome;
        public string titular_cpf;
        public string titular_Profissao;

        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;
        public string titular;



        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;

            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }


    }
}