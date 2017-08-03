using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.HelloWorld.UI.Model;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Carro
            Carro carro = new Carro("FFF-45587");
            Moto moto = new Moto("FSG-8899")
            {
                Bau = true
            };

            //Atribuir valores a placa e portas
            carro.Placa = "FFF-44546";
            carro.Porta = 5;
            //Exibir a placa
            Console.WriteLine(carro.Placa);
            Console.ReadLine();
        }
    }
}
