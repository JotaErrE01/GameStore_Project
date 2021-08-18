using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace DigitalGamesStore{
    public partial class FrmLogin : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmLogin(){
            InitializeComponent();
            txtPassword.PasswordChar = '●';
        }

        private void btnStartLauncher_Click(object sender, EventArgs e){

            //validar que la contraseña y el correo esten correctos
            if (!adm.ValidarFormulario(txtCorreo, txtPassword)) return;

            if (!adm.ValidarLoginCliente(txtCorreo, txtPassword)) return;
            
            FrmLauncher frmLauncher = new FrmLauncher();
            frmLauncher.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e){
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e){
            FrmStart frmStart = new FrmStart();
            frmStart.Show();
            this.Close();
            //this.Hide();
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e){
            //char c = e.KeyChar;
            if (e.KeyChar == Convert.ToChar(Keys.Enter)){
                e.Handled = true;
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e){
            //char c = e.KeyChar;
            if (e.KeyChar == Convert.ToChar(Keys.Enter)){
                e.Handled = true;
                return;
            }
        }
    }
}
