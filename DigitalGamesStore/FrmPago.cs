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

namespace DigitalGamesStore {
    public partial class FrmPago : Form {

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmPago() {
            InitializeComponent();
            adm.LlenarCampos(txtCedulaCliente, txtCedulaVendedor, txtidJuego, txtCantidad, cmbTipoPago, dtpFechaPagoFinal);
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e) {
            adm.ActualizarPago(txtCedulaCliente, txtCedulaVendedor, txtidJuego, txtCantidad, dtpFechaPagoFinal, cmbTipoPago);
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbTipoPago.Text == "Credito") {
                dtpFechaPagoFinal.Enabled = true;
            } else {
                dtpFechaPagoFinal.Enabled = false;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }

            if (txtCantidad.Text.Length > 2 && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }

            if (txtCedulaCliente.Text.Length > 9 && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;

            }
        }

        private void txtCedulaVendedor_KeyPress(object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }

            if (txtCedulaVendedor.Text.Length > 9 && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }
        }
    }
}
