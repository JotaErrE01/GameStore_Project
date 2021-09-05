using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class ClienteJARR : UsuarioJARR{

        string direccion;


        public ClienteJARR() { }

        public string Direccion { get => direccion; set => direccion = value; }

        public double CalcularSaldo(double saldo, double total) {

            double saldoActual = saldo - total;

            return saldoActual;
        }

    }
}
