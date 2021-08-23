using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using MySql.Data.MySqlClient;

namespace Data{
    public class SqlConfig{

        string connectionString = "Data Source = DESKTOP-N6UR074\\SQLEXPRESS; Initial Catalog=DigitalGames; Integrated Security=True";
        private static SqlConfig sql = null;
        private SqlConnection connection = null;
        //private List<Usuario> usuarios = null;
        private Cliente cliente = null;
        private Juego juego = null;
        private List<Juego> juegos = null;

        private SqlConfig (){
            connection = new SqlConnection(connectionString);
            juegos = new List<Juego>();
        }

        public static SqlConfig GetSql(){

            if (sql == null){
                sql = new SqlConfig();
                return sql;
            }

            return sql;

        }

        public bool EliminarPago(int id){
            string query = $"DELETE FROM pagos WHERE id = {id}";
            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                comando.ExecuteNonQuery();
            }
            catch (Exception e){
                MessageBox.Show($"Ocurrio un error a la hora de eliminar el pago {e}");
                    return false;
            }finally {
                connection.Close();
            }
            return true;
        }

        public List<Juego> ConsultarJuegos(){
            string query = "SELECT juegos.id, ruta_imagen, precio, clasificacion, fecha_Lanzamiento, nombre, tipo_plataforma, tipo_genero, peso FROM juegosplataformas INNER JOIN juegosgeneros ON juegosgeneros.idJuego = juegosplataformas.idJuego INNER JOIN juegos ON juegos.id = juegosgeneros.idJuego INNER JOIN plataformas ON plataformas.id = idPlataforma INNER JOIN generos ON generos.id = idGenero;";
            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();

                juegos.Clear();

                while (reader.Read()){

                    int id = (int)reader["id"];
                    string rutaImagen = reader["ruta_imagen"].ToString();
                    string nombre = reader["nombre"].ToString();
                    string genero = reader["tipo_genero"].ToString();
                    string clasificacion = reader["clasificacion"].ToString();
                    double peso = Convert.ToDouble(reader["peso"]);
                    decimal precio = (decimal)reader["precio"];
                    string plataforma = reader["tipo_plataforma"].ToString();
                    DateTime fechaLanzamiento = (DateTime)reader["fecha_Lanzamiento"];
                    juego = new Juego(id, rutaImagen, nombre, precio, genero, clasificacion, peso, plataforma, fechaLanzamiento);
                    juegos.Add(juego);
                }
            }
            catch (Exception e){

                MessageBox.Show("ERROR: " + e);
            }
            finally{
                connection.Close();
            }

            return juegos;

        }

        public Juego ConsultarJuego(int juegoId){
            string query = $"SELECT juegos.id, ruta_imagen, precio, clasificacion, fecha_Lanzamiento, nombre, tipo_plataforma, tipo_genero, peso FROM juegos INNER JOIN juegosgeneros ON juegos.id = juegosgeneros.idJuego INNER JOIN generos ON juegosgeneros.idGenero = generos.id INNER JOIN juegosplataformas ON juegosplataformas.idJuego = juegos.id INNER JOIN plataformas ON plataformas.id = juegosplataformas.idPlataforma WHERE juegos.id = {juegoId}";

            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()){
                    int id = (int)reader["id"];
                    string rutaImagen = reader["ruta_imagen"].ToString();
                    string nombre = reader["nombre"].ToString();
                    decimal precio = (decimal)reader["precio"];
                    string genero = reader["tipo_genero"].ToString();
                    string clasificacion = reader["clasificacion"].ToString();
                    double peso = Convert.ToDouble(reader["peso"]);
                    string plataforma = reader["tipo_plataforma"].ToString();
                    DateTime fechaLanzamiento = (DateTime)reader["fecha_Lanzamiento"];

                    juego = new Juego(id, rutaImagen, nombre, precio, genero, clasificacion, peso, plataforma, fechaLanzamiento);
                }

            }catch (Exception e){

                MessageBox.Show($"Error en la consulta {e}");
                
            }finally {
                connection.Close();
            }


            return juego;
        }

        public Vendedor ConsultarVendedor(string cedulaVendedor){
            string query = $"SELECT * FROM vendedores WHERE cedula = {cedulaVendedor}";
            Vendedor vendedor = null;
            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()){
                    string cedula = reader["cedula"].ToString();
                    string nombre = reader["nombre"].ToString();
                    string email = reader["email"].ToString();
                    string codigo = reader["codigo"].ToString();

                    vendedor = new Vendedor(cedula, nombre, email, codigo);
                }
            }
            catch (Exception e){

                MessageBox.Show($"Error en la consulta {e}");
            }finally{
                connection.Close();
            }

            return vendedor;
        }

        public Cliente ConsultarCliente(string cedulaCliente){

            Cliente cliente = null;

            try{
                string query = $"SELECT * FROM clientes WHERE cedula = {cedulaCliente}";
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read()){

                    string cedula = reader["cedula"].ToString();
                    string nombre = reader["nombre"].ToString();
                    string email = reader["email"].ToString();
                    string direccion = reader["direccion"].ToString();

                    cliente = new Cliente(cedula, nombre, email, direccion);
                }
            }
            catch (Exception e){

                MessageBox.Show($"Error en la consulta {e}");
            }finally{
                connection.Close();
            }
            return cliente;
        }

        public bool ConsultarPagos(DataGridView dgvPago){
            string query = $"SELECT pagos.id, cedulaCliente, cedulaVendedor, juegos.nombre, cantidad, precio, tipoPago, fechaPago, fechaPagoFinal FROM pagos INNER JOIN clientes ON clientes.cedula = pagos.cedulaCliente INNER JOIN Vendedores ON pagos.cedulaVendedor = Vendedores.cedula INNER JOIN juegos ON juegos.id = pagos.idJuego INNER JOIN TipoPagos ON TipoPagos.id = pagos.idTipoPago;";

            //Pago pago = null;

            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader =  comando.ExecuteReader();

                while (reader.Read()) {
                    int id = (int)reader["id"];
                    string cedulaVendedor = reader["cedulaVendedor"].ToString();
                    string cedulaCliente = reader["cedulaCliente"].ToString();
                    string nombre = reader["nombre"].ToString();
                    int cantidad = (int)reader["cantidad"];
                    string tipoPago = reader["tipoPago"].ToString();
                    decimal precio = (decimal)reader["precio"];
                    DateTime fechaPago = (DateTime)reader["fechaPago"];
                    if(reader["fechaPagoFinal"].GetType() != typeof(System.DBNull)){
                        DateTime fechaPagoFinal = (DateTime)reader["fechaPagoFinal"];
                    }
                    decimal total = precio * cantidad;

                    dgvPago.Rows.Add(id, cedulaVendedor, cedulaCliente, nombre, cantidad, precio, total,tipoPago, fechaPago.ToString("yyyy-MM-dd"), "");
                }
            }
            catch (Exception e){
                MessageBox.Show($"Ocurrio un error al consuiltar los datos {e}");
                return false;
            }finally{
                connection.Close();
            }

            return true;
        }

        public void InsertarPago(Pago pago){

            //MessageBox.Show($"INSERT INTO PAGOS (cedulaCliente, cedulaVendedor, idJuego, cantidad, idTipoPago, fechaPago) VALUES ({pago.Cliente.Cedula}, {pago.Vendedor.Cedula}, {pago.Juego.IdJuego}, {pago.CantidadJuegos}, {pago.TipoPago}, '{pago.FechaPago.ToString("yyyy-MM-dd")}')");

            string query = $"INSERT INTO PAGOS (cedulaCliente, cedulaVendedor, idJuego, cantidad, idTipoPago, fechaPago) VALUES ({pago.Cliente.Cedula}, {pago.Vendedor.Cedula}, {pago.Juego.IdJuego}, {pago.CantidadJuegos}, {pago.TipoPago}, '{pago.FechaPago.ToString("yyyy-MM-dd")}')";

            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                comando.ExecuteNonQuery();
            }
            catch (Exception e){

                MessageBox.Show($"Ocurrio un error al insertar los datos {e}");
            }finally{
                connection.Close();
            }
        }

        public Cliente ObtenerCliente(string correo, string password){
            string query = $"SELECT * FROM clientes WHERE email LIKE '{correo}' AND password LIKE '{password}';";
            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();


                while (reader.Read()){

                    int id = (int)reader["id"];
                    string nombre = reader["nombre"].ToString();
                    decimal saldo = (decimal)reader["saldo"];

                    //cliente = new Cliente(id, nombre, correo, password, saldo);

                    //usuarios.Add(cliente);
                }

                if (cliente == null){
                    MessageBox.Show("Correo o Contraseña incorrectos");
                }

            }catch (Exception e){
                MessageBox.Show("ERROR " + e);
            }finally{
                connection.Close();
            }
            return cliente;
        }
    }
}