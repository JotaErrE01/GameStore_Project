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

        public FrmLoginAdmin(){
            InitializeComponent();
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
    }
}
