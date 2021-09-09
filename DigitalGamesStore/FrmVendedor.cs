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

namespace DigitalGamesStore{
    public partial class FrmVendedor : Form{

        //Fields
        private Form activeForm = null;
        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmVendedor(){
            InitializeComponent();
            cmbTipoPago.SelectedItem = "Efectivo";
        }

        private void btnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }

        //Ui Mehods
        private void btnRegistrar_MouseHover(object sender, EventArgs e){
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(37, 36, 81);
            //btnBiblioteca.ForeColor = color;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e){
            if (sender != null){
                Button btn = (Button)sender;
                btn.BackColor = Color.FromArgb(11, 7, 17);
                //btnBiblioteca.ForeColor = color;
            }
        }

        public void openChildForm(Form childForm){
            if (activeForm != null){
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPago_Click(object sender, EventArgs e){
            //openChildForm(new FrmPago());
            if (activeForm != null){
                activeForm.Close();
            }
        }

        private void btnListarPagos_Click(object sender, EventArgs e){
            openChildForm(new FrmListarPago());
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e){
            adm.RegistrarPago(txtCedulaCliente, txtCedulaVendedor, txtCodigoJuego, txtCantidad, dtpFechaPagoFinal, cmbTipoPago);
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e){
            if (cmbTipoPago.Text == "Credito") {  
                dtpFechaPagoFinal.Enabled = true;
            }else{
                dtpFechaPagoFinal.Enabled = false;
            }
        }

        private void txtidJuego_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))){
                e.Handled = true;
                return;
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))){
                e.Handled = true;
                return;
            }
        }

        private void txtCedulaVendedor_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))){
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back))){
                e.Handled = true;
                return;
            }
        }
    }
}