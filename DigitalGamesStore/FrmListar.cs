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
    public partial class FrmListar : Form{

        //Fields
        private FrmEditar frm = null;

        public FrmListar(){
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e){
            //obtener fila seleccionada


            frm = new FrmEditar();
            //frm.openChildForm(new FrmEditar());
            panelChild.Visible = true;

            //activeForm = childForm;
            panelChild.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(frm);
            panelChild.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}
