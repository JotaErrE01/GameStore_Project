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
    public partial class FrmMenu : Form{

        //Fields
        //private IconButton currentBtn;
        private Form activeForm = null;

        public FrmMenu(){
            InitializeComponent();
        }

        //Ui Mehods
        private void btnBiblioteca_MouseHover(object sender, EventArgs e){
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(37,36,81);
            //btnBiblioteca.ForeColor = color;
        }

        private void btnBiblioteca_MouseLeave(object sender, EventArgs e){
            if (sender != null)
            {
                Button btn = (Button)sender;
                btn.BackColor = Color.FromArgb(11, 7, 17);
                //btnBiblioteca.ForeColor = color;
            }
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm != null){
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

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmLibreria());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
        }
    }
}
