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

        public FrmRegister()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnAtras_Click(object sender, EventArgs e){
            FrmStart frmStart = new FrmStart();
            frmStart.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e){
            //validar que la contraseña y el correo esten correctos
            if (!adm.ValidarFormulario(txtCorreo, txtPassword, txtConfirmPass.Text)) return;

            FrmLauncher frmLauncher = new FrmLauncher();
            frmLauncher.ShowDialog();
            this.Close();
        }
    }
}
