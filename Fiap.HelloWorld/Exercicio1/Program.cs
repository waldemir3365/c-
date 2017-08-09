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

            ContaCorrente cc = new ContaCorrente();

            cc.Depositar(100);

            Console.WriteLine(cc.Saldo);
           

            // INSTANCIAR CONTA POUPANÇA 


            /*
             * ContaPoupanca cp = new ContaPoupanca();
                        cp.Agencia =
                        cp.DataAbertura  =
                        cp.Numero = 
                        cp.Saldo = 
                        cp.Taxa = 
                        */
        }
    }
}
