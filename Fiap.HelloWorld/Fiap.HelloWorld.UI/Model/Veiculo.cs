using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Veiculo
    {
        //FIELD (Campo, Atributo)
        private string _placa;

        //Gets e Sets
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        //Construtor
        public Veiculo(string placa)
        {
            _placa = placa;
        }

    }
}
