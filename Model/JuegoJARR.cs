using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class JuegoJARR{

        int idJuego;
        int codigoJuego;
        string rutaImagen;
        string nombre;
        decimal precio;
        string clasificacion;
        double peso;
        string plataforma;
        string genero;
        DateTime fechaLanzamiento;

        public int IdJuego { get => idJuego; set => idJuego = value; }
        public string RutaImagen { get => rutaImagen; set => rutaImagen = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public double Peso { get => peso; set => peso = value; }
        public DateTime FechaLanzamiento { get => fechaLanzamiento; set => fechaLanzamiento = value; }
        public string Plataforma { get => plataforma; set => plataforma = value; }
        public string Genero { get => genero; set => genero = value; }
        public int CodigoJuego { get => codigoJuego; set => codigoJuego = value; }
    }
}