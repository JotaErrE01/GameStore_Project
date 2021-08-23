using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{

    public class Pago{

        string tipoPago;
        int cantidadJuegos;
        Juego juego;
        Cliente cliente;
        Vendedor vendedor;
        DateTime fechaPago;
        DateTime fechaPagoFin;

        public Pago(string tipoPago, int cantidadJuegos, Juego juego, Cliente cliente, Vendedor vendedor, DateTime fechaPago, DateTime fechaPagoFin){
            this.tipoPago = tipoPago;
            this.cantidadJuegos = cantidadJuegos;
            this.juego = juego;
            this.cliente = cliente;
            this.vendedor = vendedor;
            this.fechaPago = fechaPago;
            this.fechaPagoFin = fechaPagoFin;
        }

        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public int CantidadJuegos { get => cantidadJuegos; set => cantidadJuegos = value; }
        public Juego Juego { get => juego; set => juego = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public DateTime FechaPagoFin { get => fechaPagoFin; set => fechaPagoFin = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }


        public decimal calcularTotal(decimal precio, int cantidad){

            decimal total = precio * cantidad;

            return total;
        }
    }
}
