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
    public partial class FrmListarPago : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmListarPago(){
            InitializeComponent();
            adm.ListarPagos(dgvPago);
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            adm.EliminarPago(dgvPago);
        }

        private void FrmListarPago_Load(object sender, EventArgs e){
        }
    }
}
