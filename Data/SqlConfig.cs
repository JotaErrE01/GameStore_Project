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

        private static SqlConfig sql = null;
        private MySqlConnection connection = null;
        //private List<Usuario> usuarios = null;
        private Cliente cliente = null;
        private Juego juego = null;
        private List<Juego> juegos = null;

        private SqlConfig (){
            //MysqlConnect();
            //usuarios = new List<Usuario>();
            connection = new MySqlConnection("Database= digitalgames; Data Source= localhost; Port= 3306; User Id= root; Password= jotaerre01");
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
            string query = "SELECT juegos.id, ruta_imagen, precio, clasificacion, fecha_salida, nombre, tipo_plataforma, tipo_genero, peso FROM juegosplataformas INNER JOIN juegosgeneros ON juegosgeneros.idJuego = juegosplataformas.idJuego INNER JOIN juegos ON juegos.id = juegosgeneros.idJuego INNER JOIN plataformas ON plataformas.id = idPlataforma INNER JOIN generos ON generos.id = idGenero; ";

            try{
                connection.Open();
                MySqlCommand comando = new MySqlCommand(query);
                comando.Connection = connection;
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()){

                    int id = (int)reader["id"];
                    string rutaImagen = reader["ruta_imagen"].ToString();
                    string nombre = reader["nombre"].ToString();
                    string genero = reader["tipo_genero"].ToString();
                    string clasificacion = reader["clasificacion"].ToString();
                    double peso = (double)reader["peso"];
                    decimal precio = (decimal)reader["precio"];
                    string plataforma = reader["tipo_plataforma"].ToString();
                    DateTime fechaLanzamiento = (DateTime)reader["fecha_salida"];

                    juego = new Juego(id, rutaImagen, nombre, precio, genero, clasificacion, peso, plataforma, fechaLanzamiento);

                    //if (juego.Nombre == nombre){
                    //    plataforma = "Windows y Mac";
                    //    juegos.RemoveAt(juegos.Count - 1);
                    //}

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
            string query = $"SELECT * FROM clientes WHERE email= '{correo}' AND password= '{password}';";
            try{
                connection.Open();
                MySqlCommand comando = new MySqlCommand(query);
                comando.Connection = connection;
                MySqlDataReader reader = comando.ExecuteReader();


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


//string conectionString = "Data Source = DESKTOP-N6UR074\\SQLEXPRESS; Initial Catalog=DigitalGames; Integrated Security=True";

//SqlConnection connection = null;

//public void SqlConection(){

//    try{
//        connection = new SqlConnection(conectionString);
//        connection.Open();
//        MessageBox.Show("Conection Success");
//    }
//    catch{
//        MessageBox.Show("Error de Conexion con la BD");
//    }
//}

//public void CloseConection(){
//    connection.Close();
//    MessageBox.Show("Se cerró la conexión.");
//}