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
    public partial class FrmRegister : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmRegister(){
            InitializeComponent();
            txtPassword.PasswordChar = '●';
            txtConfirmPass.PasswordChar = '●';
        }

        private void btnAtras_Click(object sender, EventArgs e){
            FrmStart frmStart = new FrmStart();
            frmStart.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e){
            //validar que la contraseña y el correo esten correctos
            if (!adm.ValidarFormularioRegistro(txtNombre, txtCorreo, txtPassword, txtConfirmPass)) return;

            //Guardar en la base de datos
            if (!adm.GuardarUsuario(txtNombre, txtCorreo, txtPassword)) return;

            FrmLauncher frmLauncher = new FrmLauncher();
            frmLauncher.Show();
            this.Close();
        }

        public void SaldoScreen(){
            FrmSaldo saldo =  new FrmSaldo();
            saldo.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != ' '){
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == Convert.ToChar(Keys.Enter)){
                e.Handled = true;
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == Convert.ToChar(Keys.Enter)){
                e.Handled = true;
                return;
            }
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == Convert.ToChar(Keys.Enter)){
                e.Handled = true;
                return;
            }
        }
    }
}