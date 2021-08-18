using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller{
    public class AdmDigitalGames{

        private static AdmDigitalGames adm = null;
        Validacion v = null;
        List<Juego> juegos= null;
        List<Juego> carrito = null;
        Cliente cliente = null;
        SqlConfig bd = null;
        //Validacion v = null;

        private AdmDigitalGames(){
            //inicializamos la lista
            juegos = new List<Juego>();
            carrito = new List<Juego>();
            bd = SqlConfig.GetSql();
        }

        public void GetEliminarJuegoCarrito(DataGridView dgvCarrito){
            if (dgvCarrito.SelectedRows.Count != 1) {
                MessageBox.Show("Selleccione un juego para eliminarlo del carrito");
                return;
            }

            carrito.RemoveAt(dgvCarrito.CurrentRow.Index);

            LlenarGridCarrito(dgvCarrito);

        }

        public static AdmDigitalGames GetAdm(){
            if (adm == null){
                adm = new AdmDigitalGames();
            }
            return adm;
        }

        public void LLenarGridBiblioteca(DataGridView dgvBiblioteca){
            // Consultar Juegos de la base de datos
            juegos = bd.ConsultarJuegos();
            LlenarTablasDeJuegos(juegos, dgvBiblioteca);            
        }

        public void LlenarTablasDeJuegos(List<Juego> juegos, DataGridView dgvBiblioteca){
            juegos.ForEach(juego => {
                dgvBiblioteca.Rows.Add(Image.FromFile(juego.RutaImagen), juego.Nombre, juego.Genero, juego.FechaLanzamiento.ToString("yyyy-MM-dd"), juego.Clasificacion, "$" + juego.Precio, juego.Peso, juego.Plataforma);
            });
        }

        public void agregarAlCarrito(DataGridView dgvBiblioteca){
            if (dgvBiblioteca.SelectedRows.Count != 1) {
                MessageBox.Show("Seleccione un Juego para agregarlo al carrito");
                return;
            }

            /*
             * TODO: MEJORAR AGREGAR AL CARRITO, NO FUNCIONA CUANDO SE FILTRA
             * **/

            carrito.Add(juegos.ElementAt(dgvBiblioteca.CurrentRow.Index));          
        }

        public void LlenarGridCarrito(DataGridView dgvCarrito){

            dgvCarrito.Rows.Clear();

            carrito.ForEach( juego => {
                dgvCarrito.Rows.Add(Image.FromFile(juego.RutaImagen), juego.Nombre, juego.Genero, juego.FechaLanzamiento.ToString("yyyy-mm-dd"), juego.Clasificacion, "$" + juego.Precio);
            });
        }

        public bool validarSaldo(TextBox txtSaldo){
            string saldo = txtSaldo.Text;
            if (!v.EsReal(saldo)) return false;
            return true;
        }

        public bool ValidarLoginCliente(TextBox txtCorreo, TextBox txtPassword){

            string correo = txtCorreo.Text;
            string password = txtPassword.Text;

            cliente = bd.ObtenerCliente(correo, password);

            if (cliente == null) return false;

            //MessageBox.Show(cliente.Saldo.ToString());
            return true;
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

        public void IniciarLauncher(Label lblNombre, Label lblSaldo){
            lblNombre.Text = $"Bienvenido {cliente.Nombre}";
            lblSaldo.Text = $"Saldo = ${cliente.Saldo}";
        }

        public void ValidarLoginAdministrador(TextBox txtCorreo, TextBox txtPassword){
            //validar con la base de datos
        }

        public void conectionSql(){
            //bd.mysql();
        }
    }
}