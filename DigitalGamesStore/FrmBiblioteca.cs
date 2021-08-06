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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
            cmbGenero.SelectedItem = "Todos";
            txtDesde.Text = "0";
            txtHasta.Text = "0";
        }
    }
}
