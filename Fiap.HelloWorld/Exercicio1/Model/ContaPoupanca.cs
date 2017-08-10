using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }

        private readonly decimal _rendimento;

        

        // Construtor poupanca
        public ContaPoupanca(decimal valor)
        {
            _rendimento += valor;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;  
        }


        //verifica se o saldo é suficiente, se for deve descontar também a Taxa de retirada, se não, lance uma exceção

        public override void Retirar(decimal valor)
        {

            valor += Taxa;

            if (Saldo <= 0 || valor > Saldo)
            {
                throw new Exception("saldo insuficiente para saque !");
            }
           
                Saldo -= valor;
                Console.WriteLine("Saldo atual : " + Saldo);
            
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }
    }
}
