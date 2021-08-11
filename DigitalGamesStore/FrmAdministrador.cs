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
    public partial class FrmAdministrador : Form{

        //Fields
        //private IconButton currentBtn;
        private Form activeForm = null;

        public FrmAdministrador(){
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }

        //Ui Mehods
        private void btnRegistrar_MouseHover(object sender, EventArgs e){
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(37, 36, 81);
            //btnBiblioteca.ForeColor = color;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e){
            if (sender != null){
                Button btn = (Button)sender;
                btn.BackColor = Color.FromArgb(11, 7, 17);
                //btnBiblioteca.ForeColor = color;
            }
        }

        private void openChildForm(Form childForm){
            if (activeForm != null){
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e){
            if (activeForm != null){
                activeForm.Close();
            }
        }

        private void btnListar_Click(object sender, EventArgs e){
            //openChildForm(new FrmCarrito());
        }
    }
}
