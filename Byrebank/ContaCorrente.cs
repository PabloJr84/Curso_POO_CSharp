﻿namespace bytebank
   
{
    public class ContaCorrente
    {
        
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;



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