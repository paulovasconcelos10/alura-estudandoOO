using System;

namespace EstudandoOO
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = new Cliente();
            conta1.titular.nome = "Paulo";
            conta1.Depositar(200);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = new Cliente();
            conta2.titular.nome = "Victor";
            conta2.Depositar(100);
            Console.WriteLine(conta1.titular.nome + " Saldo: " + conta1.saldo);
            
            if (conta1.Sacar(150))
            {
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Sem saldo");
            }
            Console.WriteLine(conta1.titular.nome + " Saldo: " + conta1.saldo);

            Console.WriteLine(conta2.titular.nome + " Saldo: " + conta2.saldo);
            if (conta2.Sacar(150))
            {
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Sem saldo para sacar");
            }
            Console.WriteLine(conta2.titular.nome + " Saldo: " + conta2.saldo);

            
            
            if (conta2.Transferir(50, conta1))
            {
                Console.WriteLine("Transferencia realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Sem saldo para transferencia");
            }
            Console.WriteLine(conta2.titular.nome + " Saldo: " + conta2.saldo);
            Console.WriteLine(conta1.titular.nome + " Saldo: " + conta1.saldo);


            Console.ReadLine();
  
        }
    }
}
