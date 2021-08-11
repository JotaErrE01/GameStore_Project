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
    public partial class FrmSaldo : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmSaldo(){
            InitializeComponent();
        }

        private void btnSaldo_Click(object sender, EventArgs e){
            if (!adm.validarSaldo(txtSaldo)) return;
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != '.'){
                e.Handled = true;
                return;
            }
        }
    }
}
