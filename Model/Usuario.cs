using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class Usuario{

        int id;
        string nombre;
        string email;
        string password;

        public Usuario(int id, string nombre, string email, string password){
            this.Id = id;
            this.Nombre = nombre;
            this.Email = email;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
