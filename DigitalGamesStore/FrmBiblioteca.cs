using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalGamesStore{
    public partial class FrmBiblioteca : Form{

        AdmDigitalGames adm = AdmDigitalGames.GetAdm();

        public FrmBiblioteca(){
            InitializeComponent();
            cmbGenero.SelectedItem = "Todos";
            txtDesde.Text = "0";
            txtHasta.Text = "0";
            //MessageBox.Show(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Images\LoL2.jpg"));
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e){
            adm.LLenarGrid(dgvBiblioteca);
        }
    }
}
