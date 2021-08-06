using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AdmDigitalGames{

        public void conectionSql()
        {
            SqlConfig conect = new SqlConfig();
            conect.SqlConection();
        }

    }
}
