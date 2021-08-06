using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data{
    public class SqlConfig{

        public void SqlConection(){

            string stringConection = "Data Source = DESKTOP-N6UR074\\SQLEXPRESS; Initial Catalog=DigitalGames; Integrated Security=True";

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(stringConection);
                connection.Open();
                MessageBox.Show("Conection Success");
                connection.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
            catch
            {
                MessageBox.Show("Error de Conexion con la BD");
            }
        }

    }
}
