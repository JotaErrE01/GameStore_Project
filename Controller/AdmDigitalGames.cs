using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class AdmDigitalGames{

        private static AdmDigitalGames adm = null;
        List<string> lista = null;
        //Validacion v = null;

        private AdmDigitalGames(){
            //inicializamos la lista
            lista = new List<string>();
        }

        public static AdmDigitalGames GetAdm(){
            if (adm == null){
                adm = new AdmDigitalGames();
            }
            return adm;

        }

        public bool ValidarFormulario(TextBox txtCorreo, TextBox txtPassword){

            //Expresion regular para validar el email
            string RegexEx = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            string password = txtPassword.Text;
            string correo = txtCorreo.Text;

            //Validacion del correo
            if (!Regex.IsMatch(correo, RegexEx)){
                MessageBox.Show("Correo no Valido");
                return false;
            }

            //validacion de la contraseña
            if (password.Length < 5){
                MessageBox.Show("La contraseña debe ser minimo de 5 caracteres");
                return false;
            }

            return true;
        }

        public bool GuardarUsuario(TextBox txtNombre, TextBox txtCorreo, TextBox txtPassword){

            //Guardar el usuario en la base de datos


            return true;
        }

        public bool ValidarFormularioRegistro(TextBox txtNombre, TextBox txtCorreo, TextBox txtPassword, TextBox txtConfirmPass){

            string nombre = txtNombre.Text;

            if (nombre.Trim().Length < 3) {
                MessageBox.Show("El Nombre es Obligatorio");
                return false;
            } 

            if(!ValidarFormulario(txtCorreo, txtPassword)) return false;

            string password = txtPassword.Text;
            string confirmPass = txtConfirmPass.Text;

            //Comprobar si las contraseñas son iguales
            if (password != confirmPass){
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }


            return true;
        }

        public bool ValidarLoginCliente(TextBox txtCorreo, TextBox txtPassword){
            //validar con la base de datos

            return true;
        }

        public void ValidarLoginAdministrador(TextBox txtCorreo, TextBox txtPassword){
            //validar con la base de datos
        }

        public void conectionSql()
        {
            SqlConfig conect = new SqlConfig();
            conect.SqlConection();
        }

    }
}
