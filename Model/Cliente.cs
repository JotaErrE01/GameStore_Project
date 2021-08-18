using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class Cliente : Usuario{

        decimal saldo;

        public Cliente(int id, string nombre, string email, string password, decimal saldo) : base(id, nombre, email, password){
            this.Saldo = saldo;
        }

        public decimal Saldo { get => saldo; set => saldo = value; }

        public double CalcularSaldo(double saldo, double total) {

            double saldoActual = saldo - total;

            return saldoActual;
        }

    }
}
