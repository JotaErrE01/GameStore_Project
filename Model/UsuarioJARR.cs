using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class UsuarioJARR{

        int id;
        string cedula;
        string nombre;
        string email;

        //public UsuarioJARR(string cedula, string nombre, string email){
        //    this.Id = id;
        //    this.Cedula = cedula;
        //    this.Nombre = nombre;
        //    this.Email = email;
        //}

        public int Id { get => id; set => id = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
    }
}
