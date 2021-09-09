using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Model;

namespace Data{
    public class SqlConfig{

        string connectionString = "Data Source = DESKTOP-N6UR074\\SQLEXPRESS; Initial Catalog=DigitalGames; Integrated Security=True";
        private static SqlConfig sql = null;
        private SqlConnection connection = null;

        private List<PagoJARR> pagos = null;
        private ClienteJARR cliente = null;
        private VendedorJARR vendedor = null;
        private JuegoJARR juego = null;
        private PagoJARR pago = null;

        private SqlConfig (){
            connection = new SqlConnection(connectionString);
            pagos = new List<PagoJARR>();
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
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        public bool EditarPago(PagoJARR pago, int id){
            string query = $"UPDATE pagos SET idCliente={pago.Cliente.Id}, idVendedor={pago.Vendedor.Id}, idJuego={pago.Juego.IdJuego}, fechaPago='{pago.FechaPago.ToString("yyyy-MM-dd")}', idTipoPago={pago.TipoPago}, cantidad={pago.CantidadJuegos}, fechaPagoFinal='{pago.FechaPagoFin.ToString("yyyy-MM-dd")}' WHERE id={id}";

            if (pago.FechaPagoFin.ToString("yyyy-MM-dd").Equals(DateTime.Today)){
                query = $"UPDATE pagos SET idCliente={pago.Cliente.Id}, idVendedor={pago.Vendedor.Id}, idJuego={pago.Juego.IdJuego}, fechaPago='{pago.FechaPago.ToString("yyyy-MM-dd")}', idTipoPago={pago.TipoPago}, cantidad={pago.CantidadJuegos} WHERE id={id}";
            }
            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                comando.ExecuteNonQuery();
            }catch (Exception e){
                MessageBox.Show($"Error al actualizar los pagos");
                Console.WriteLine(e);
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        public List<PagoJARR> ConsultarPagos(){
            string query = $"SELECT pagos.id, clientes.cedula as cedulaCliente, vendedores.cedula as cedulaVendedor, Codigo_Juego,idJuego, juegos.nombre, cantidad, precio, tipoPago, fechaPago, fechaPagoFinal FROM pagos INNER JOIN clientes ON clientes.id = pagos.idCliente INNER JOIN vendedores ON pagos.idVendedor = Vendedores.id INNER JOIN juegos ON juegos.id = pagos.idJuego INNER JOIN TipoPagos ON TipoPagos.id = pagos.idTipoPago;";
            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) {
                    vendedor = new VendedorJARR();
                    vendedor.Cedula = reader["cedulaVendedor"].ToString();

                    cliente = new ClienteJARR();
                    cliente.Cedula = reader["cedulaCliente"].ToString();

                    juego = new JuegoJARR();
                    juego.IdJuego = (int)reader["idJuego"];
                    juego.Precio = (decimal)reader["precio"];
                    juego.Nombre = reader["nombre"].ToString();
                    juego.CodigoJuego = (int)reader["Codigo_Juego"];

                    pago = new PagoJARR();
                    pago.Id = (int)reader["id"];
                    pago.TipoPago = reader["tipoPago"].ToString();
                    pago.CantidadJuegos = (int)reader["cantidad"];
                    pago.FechaPago = (DateTime)reader["fechaPago"];
                    pago.Cliente = cliente;
                    pago.Vendedor = vendedor;
                    pago.Juego = juego;
                    if (reader["fechaPagoFinal"].GetType() != typeof(DBNull)){
                        pago.FechaPagoFin = (DateTime)reader["fechaPagoFinal"];
                    }else{
                        pago.FechaPagoFin = DateTime.Today;
                    }
                    pagos.Add(pago);
                }
            }
            catch (Exception e){
                MessageBox.Show($"Ocurrio un error al consultar los datos");
                Console.WriteLine(e);
            }
            connection.Close();
            return pagos;
        }

        public VendedorJARR ConsultarVendedor(string cedulaVendedor) {
            string query = $"SELECT * FROM vendedores WHERE cedula = '{cedulaVendedor}'";
            try {
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();
                vendedor = new VendedorJARR();

                if (!reader.HasRows) {
                    MessageBox.Show("No existe un Vendedor registrado con la cedula dada");
                    connection.Close();
                    return null;
                }

                while (reader.Read()) {
                    vendedor.Id = (int)reader["id"];
                    vendedor.Cedula = cedulaVendedor;
                }
            } catch (Exception e) {
                MessageBox.Show("Error al consultar vendedores");
                Console.WriteLine(e);
                connection.Close();
                return null;
            }
            connection.Close();
            return vendedor;
        }

        public ClienteJARR ConsultarCliente(string cedulaCliente) {
            string query = $"SELECT * FROM clientes WHERE cedula = '{cedulaCliente}'";
            try {
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();
                cliente = new ClienteJARR();

                if (!reader.HasRows) {
                    MessageBox.Show("No existe un cliente registrado con la cedula dada");
                    connection.Close();
                    return null;
                }

                while (reader.Read()) {
                    cliente.Id = (int)reader["id"];
                    cliente.Cedula = cedulaCliente;
                }
            } catch (Exception e) {
                MessageBox.Show("Error al consultar clientes");
                Console.WriteLine(e);
                connection.Close();
                return null;
            } 
            connection.Close();
            return cliente;
        }

        public JuegoJARR ConsultartJuego(int codigoJuego) {
            string query = $"SELECT * FROM juegos WHERE codigo_juego = {codigoJuego}";
            try {
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();
                juego = new JuegoJARR();

                if (!reader.HasRows) {
                    MessageBox.Show("No existe un juego registrado con el codigo dado");
                    connection.Close();
                    return null;
                }

                while (reader.Read()) {
                    juego.IdJuego = (int)reader["id"];
                    juego.CodigoJuego = codigoJuego;
                }
            } catch (Exception e) {
                MessageBox.Show("Error en al consultar los juegos");
                Console.WriteLine(e);
                connection.Close();
                return null;
            }
            connection.Close();
            return juego;
        }

        public bool InsertarPago(PagoJARR pago){
            string query = $"INSERT INTO PAGOS (idCliente, idVendedor, idJuego, cantidad, idTipoPago, fechaPago, fechaPagoFinal) VALUES ({pago.Cliente.Id}, {pago.Vendedor.Id}, {pago.Juego.IdJuego}, {pago.CantidadJuegos}, {pago.TipoPago}, '{pago.FechaPago.ToString("yyyy-MM-dd")}', '{pago.FechaPagoFin.ToString("yyyy-MM-dd")}')";

            if (pago.FechaPagoFin.ToString("yyyy-MM-dd").Equals(DateTime.Now.ToString("yyyy-MM-dd"))){
                query = $"INSERT INTO PAGOS (idCliente, idVendedor, idJuego, cantidad, idTipoPago, fechaPago) VALUES ({pago.Cliente.Id}, {pago.Vendedor.Id}, {pago.Juego.IdJuego}, {pago.CantidadJuegos}, {pago.TipoPago}, '{pago.FechaPago.ToString("yyyy-MM-dd")}')";
            }

            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                comando.ExecuteNonQuery();
            }
            catch (Exception e){
                MessageBox.Show($"Ocurrio un error al registrar el pago");
                Console.WriteLine(e);
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
    }
}