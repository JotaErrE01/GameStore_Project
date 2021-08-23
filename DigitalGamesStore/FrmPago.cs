using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalGamesStore
{
    public partial class FrmPago : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmPago(){
            InitializeComponent();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e){
            adm.RegistrarPago(txtCedulaCliente, txtCedulaVendedor, txtidJuego, txtPrecio, txtCantidad, dtpFechaPagoFinal, cmbTipoPago);
        }
    }
}
