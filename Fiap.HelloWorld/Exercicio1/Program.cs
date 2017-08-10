using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            // instanciar contacorrente 

            var cc = new ContaCorrente()
            {
                Agencia = 123,
                Numero = 321,
                DataAbertura = DateTime.Now,
                TipoConta = TipoConta.Comum,
                Saldo = 1000

            };

            // INSTANCIAR CONTA POUPANÇA 

            var cp = new ContaPoupanca(0.006m)
            {
                Agencia = 123,
                Numero = 521,
                DataAbertura = DateTime.Now,
                Saldo = 500,
                Taxa = 10


            };

            cc.Depositar(500);
            cc.Retirar(100);
            Console.WriteLine(cp.CalculaRetornoInvestimento());
            Console.WriteLine(cc.Saldo);
            Console.ReadLine();//parar a aplicação.....

                        
        }
    }
}
