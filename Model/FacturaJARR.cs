using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    class FacturaJARR{

        int id;
        string emisor;
        string receptor;

        public FacturaJARR(int id, string emisor, string receptor){
            this.id = id;
            this.emisor = emisor;
            this.receptor = receptor;
        }

        public double CalcularTotal(double[] precioJuegos){
            return 0.0;
        }
    }
}