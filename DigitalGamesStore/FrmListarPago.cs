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
    }
}
