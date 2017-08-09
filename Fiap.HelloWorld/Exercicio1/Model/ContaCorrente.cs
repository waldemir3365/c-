using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }



        public override void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (this.TipoConta.Equals("Comum") && this.Saldo < 0)
            {
                throw new Exception("valor não pode ser sacado devido ao saldo ser negativo !");
            }
            else
            {
                this.Saldo -= valor; 
            }
        }
    }
}
