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
                    return false;
            }finally {
                connection.Close();
            }
            return true;
        }

        public PagoJARR ConsultarPago(int id){
            string query = $"SELECT * FROM pagos INNER JOIN TipoPagos ON pagos.idTipoPago = TipoPagos.id WHERE pagos.id= ${id};";

            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()){
                    juego = new JuegoJARR();
                    juego.IdJuego = (int)reader["idJuego"];
                    
                    vendedor = new VendedorJARR();
                    vendedor.Cedula = reader["cedulaVendedor"].ToString();

                    cliente = new ClienteJARR();
                    cliente.Cedula = reader["cedulaCliente"].ToString();

                    pago = new PagoJARR();
                    pago.Juego = juego;
                    pago.Cliente = cliente;
                    pago.Vendedor = vendedor;
                    pago.CantidadJuegos = (int)reader["cantidad"];
                    pago.FechaPago = (DateTime)reader["fechaPago"];
                    pago.TipoPago = reader["tipoPago"].ToString();

                    if(pago.TipoPago == "Credito"){
                        pago.FechaPagoFin = (DateTime)reader["fechaPagoFinal"];
                    }
                }

                return pago;
            }catch (Exception e){
                MessageBox.Show($"Error en la consulta {e}");
            }finally {
                connection.Close();
            }

            return pago;
        }

        public void EditarPago(PagoJARR pago, int id){

            string query = $"UPDATE pagos SET cedulaCliente={pago.Cliente.Cedula}, cedulaVendedor={pago.Vendedor.Cedula}, idJuego={pago.Juego.IdJuego}, fechaPago='{pago.FechaPago.ToString("yyyy-MM-dd")}', idTipoPago={pago.TipoPago}, cantidad={pago.CantidadJuegos}, fechaPagoFinal='{pago.FechaPagoFin.ToString("yyyy-MM-dd")}' WHERE id={id}";

            if (pago.FechaPagoFin.ToString("yyyy-MM-dd").Equals(DateTime.Today)){
                query = $"UPDATE pagos SET cedulaCliente={pago.Cliente.Cedula}, cedulaVendedor={pago.Vendedor.Cedula}, idJuego={pago.Juego.IdJuego}, fechaPago='{pago.FechaPago.ToString("yyyy-MM-dd")}', idTipoPago={pago.TipoPago}, cantidad={pago.CantidadJuegos} WHERE id={id}";
            }

            try{
                connection.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = connection;
                comando.ExecuteNonQuery();
            }catch (Exception e){
                MessageBox.Show($"Error al actualizar {e}");
            }finally{
                connection.Close();
            }
        }

        public List<PagoJARR> ConsultarPagos(){
            string query = $"SELECT pagos.id, cedulaCliente, cedulaVendedor, juegos.nombre, cantidad, precio, tipoPago, fechaPago, fechaPagoFinal FROM pagos INNER JOIN clientes ON clientes.cedula = pagos.cedulaCliente INNER JOIN Vendedores ON pagos.cedulaVendedor = Vendedores.cedula INNER JOIN juegos ON juegos.id = pagos.idJuego INNER JOIN TipoPagos ON TipoPagos.id = pagos.idTipoPago;";

            //Pago pago = null;

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
                    juego.Precio = (decimal)reader["precio"];
                    juego.Nombre = reader["nombre"].ToString();

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
                MessageBox.Show($"Ocurrio un error al consuiltar los datos {e}");
                return pagos;
            }
            finally{
                connection.Close();
            }

            return pagos;
        }

        public void InsertarPago(PagoJARR pago){

            string query = $"INSERT INTO PAGOS (cedulaCliente, cedulaVendedor, idJuego, cantidad, idTipoPago, fechaPago, fechaPagoFinal) VALUES ({pago.Cliente.Cedula}, {pago.Vendedor.Cedula}, {pago.Juego.IdJuego}, {pago.CantidadJuegos}, {pago.TipoPago}, '{pago.FechaPago.ToString("yyyy-MM-dd")}', '{pago.FechaPagoFin.ToString("yyyy-MM-dd")}')";

            if (pago.FechaPagoFin.ToString("yyyy-MM-dd").Equals(DateTime.Now.ToString("yyyy-MM-dd"))){
                query = $"INSERT INTO PAGOS (cedulaCliente, cedulaVendedor, idJuego, cantidad, idTipoPago, fechaPago) VALUES ({pago.Cliente.Cedula}, {pago.Vendedor.Cedula}, {pago.Juego.IdJuego}, {pago.CantidadJuegos}, {pago.TipoPago}, '{pago.FechaPago.ToString("yyyy-MM-dd")}')";
            }

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
    }
}