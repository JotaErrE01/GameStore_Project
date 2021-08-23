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
    public partial class FrmLoginAdmin : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmLoginAdmin(){
            InitializeComponent();
            txtPassword.PasswordChar = '●';
        }

        private void btnAtras_Click(object sender, EventArgs e){
            FrmStart frmStart = new FrmStart();
            frmStart.Show();
            this.Close();
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

        private void btnStartLauncher_Click(object sender, EventArgs e){

            /**
             *TODO: VALIDAR DATOS DEL ADMIN
             */

            //adm.VerificarAdmin(txtCorreo, txtPassword);

            FrmVendedor frmAdministrador = new FrmVendedor();
            frmAdministrador.Show();
            this.Close();
        }
    }
}
