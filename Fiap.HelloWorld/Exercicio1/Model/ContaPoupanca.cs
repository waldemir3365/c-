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

        readonly decimal _rendimento;

        

        // Construtor poupanca
        public ContaPoupanca(decimal valor)
        {
            _rendimento += valor;
        }

        public ContaPoupanca()
        {
        }

        public override void Depositar(decimal valor)
        {
            this.Saldo += valor;  
        }


        //verifica se o saldo é suficiente, se for deve descontar também a Taxa de retirada, se não, lance uma exceção

        public override void Retirar(decimal valor)
        {

            valor += this.Taxa;

            if (this.Saldo <= 0 || valor > this.Saldo)
            {
                throw new Exception("saldo insuficiente para saque !");
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine("Saldo atual : " + this.Saldo);
            }
        }

        public decimal CalculaRetornoInvestimento()
        {
            return this.Saldo * this._rendimento;
        }
    }
}
