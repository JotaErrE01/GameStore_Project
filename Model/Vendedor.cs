using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class Vendedor : Usuario{

        string codigo;

        public Vendedor(string cedula, string nombre, string email, string codigo) : base (cedula, nombre, email){
            this.Codigo = codigo;
        }

        public string Codigo { get => codigo; set => codigo = value; }
    }
}
