using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {
        public int Agencia           { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero            { get; set; }
        public decimal Saldo         { get; set; }

        public Conta(int agencia, DateTime dataAbertura, int numero, decimal saldo)
        {
            this.Agencia = agencia;
            this.DataAbertura = dataAbertura;
            this.Numero = numero;
            this.Saldo = saldo;

        }
        public Conta()
        {

        }


        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);
    }
}
