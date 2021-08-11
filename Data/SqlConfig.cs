using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data{
    public class SqlConfig{

        string conectionString = "Data Source = DESKTOP-N6UR074\\SQLEXPRESS; Initial Catalog=DigitalGames; Integrated Security=True";

        SqlConnection connection = null;

        public void SqlConection(){

            try{
                connection = new SqlConnection(conectionString);
                connection.Open();
                MessageBox.Show("Conection Success");
            }
            catch{
                MessageBox.Show("Error de Conexion con la BD");
            }
        }

        public void CloseConection(){
            connection.Close();
            MessageBox.Show("Se cerró la conexión.");
        }

    }
}
