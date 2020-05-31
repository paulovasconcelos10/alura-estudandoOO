using System;
using System.Collections.Generic;
using System.Text;

namespace EstudandoOO
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int conta;
        public int agencia;
        public double saldo = 100;



        public bool Sacar (double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor) {
            this.saldo += valor;
        
        }

        public bool Transferir (double valor, ContaCorrente conta)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            conta.Depositar(valor);
            return true;
        }

    }
}
