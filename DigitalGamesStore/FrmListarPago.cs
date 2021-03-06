using Controller;
using System;
using System.Windows.Forms;

namespace DigitalGamesStore{
    public partial class FrmListarPago : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmListarPago(){
            InitializeComponent();
            adm.ListarPagos(dgvPago);
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            adm.EliminarPago(dgvPago);
        }

        private void btnEditar_Click(object sender, EventArgs e){
            if(!adm.EditarPago(dgvPago)) return;
            FrmPago frm = new FrmPago();
            panel1.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            panel1.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e){
            adm.BuscarJuego(txtJuego, txtCedulaCliente, dgvPago);
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            // Metodo para generar el reporte
            adm.GenerarReporte(txtJuego);
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }

            if (txtCedulaCliente.Text.Length > 9 && (e.KeyChar != Convert.ToChar(Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        private void txtJuego_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                e.Handled = true;
                return;
            }
        }
    }
}