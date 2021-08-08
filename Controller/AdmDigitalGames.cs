using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public bool ValidarFormulario(TextBox txtCorreo, TextBox txtPassword, string confirmPass){

            string password = txtPassword.Text;
            string correo = txtCorreo.Text;

            //validar el correo y la contraseña
            


            if (confirmPass != "" && confirmPass != password)
            {
                //if (confirmPass != password){

                //}

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
