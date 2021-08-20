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
    public partial class FrmCarrito : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmCarrito(){
            InitializeComponent();
            adm.LlenarGridCarrito(dgvCarrito);
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            adm.GetEliminarJuegoCarrito(dgvCarrito);
        }
    }
}
