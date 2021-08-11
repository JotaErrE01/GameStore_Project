using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller{
    class Validacion{
        internal bool EsReal(string saldo){
            try{
                double valor = Convert.ToDouble(saldo);
                return true;
            }catch (Exception e){
                MessageBox.Show("El Valor Ingresado no es un Numero Valido para el Saldo");
                return false;
            }
        }
    }
}
