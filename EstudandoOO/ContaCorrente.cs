using System;
using System.Collections.Generic;
using System.Text;

namespace EstudandoOO
{
    public class ContaCorrente
    {
        public String titular;
        public int conta;
        public int agencia;
        public double saldo;



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

    }
}
