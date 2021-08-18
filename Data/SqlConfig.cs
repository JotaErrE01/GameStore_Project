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
            //MysqlConnect();
            //usuarios = new List<Usuario>();
            //connection = new MySqlConnection("Database= digitalgames; Data Source= localhost; Port= 3306; User Id= root; Password= jotaerre01");
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

        public List<Juego> ConsultarJuegos(){
            string query = "SELECT juegos.id, ruta_imagen, precio, clasificacion, fecha_Lanzamiento, nombre, tipo_plataforma, tipo_genero, peso FROM juegosplataformas INNER JOIN juegosgeneros ON juegosgeneros.idJuego = juegosplataformas.idJuego INNER JOIN juegos ON juegos.id = juegosgeneros.idJuego INNER JOIN plataformas ON plataformas.id = idPlataforma INNER JOIN generos ON generos.id = idGenero; ";
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

        //public void MysqlConnect(){
        //    try{
        //        //connection = 
        //        connection.Open();
        //        MessageBox.Show("Conection Success");
        //    }
        //    catch (Exception){
        //        MessageBox.Show("Error en la Conexion de la base de datos");
        //    }
        //}

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

                    cliente = new Cliente(id, nombre, correo, password, saldo);

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