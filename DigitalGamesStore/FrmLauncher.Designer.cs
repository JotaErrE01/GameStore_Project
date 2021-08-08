
namespace DigitalGamesStore
{
    partial class FrmLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnConection = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnJuegos = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnConection);
            this.panelSideMenu.Controls.Add(this.btnJuegos);
            this.panelSideMenu.Controls.Add(this.btnCarrito);
            this.panelSideMenu.Controls.Add(this.btnBiblioteca);
            this.panelSideMenu.Controls.Add(this.btnInicio);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 626);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnConection
            // 
            this.btnConection.Location = new System.Drawing.Point(33, 363);
            this.btnConection.Name = "btnConection";
            this.btnConection.Size = new System.Drawing.Size(147, 53);
            this.btnConection.TabIndex = 4;
            this.btnConection.Text = "Test de Conexion";
            this.btnConection.UseVisualStyleBackColor = true;
            this.btnConection.Click += new System.EventHandler(this.btnConection_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 75);
            this.panel1.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Location = new System.Drawing.Point(250, 68);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(904, 558);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::DigitalGamesStore.Properties.Resources.Frame_2;
            this.pictureBox2.Location = new System.Drawing.Point(233, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(463, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::DigitalGamesStore.Properties.Resources.btnSalir;
            this.btnExit.Location = new System.Drawing.Point(0, 588);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnBiblioteca_MouseHover);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnBiblioteca_MouseLeave);
            // 
            // btnJuegos
            // 
            this.btnJuegos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJuegos.FlatAppearance.BorderSize = 0;
            this.btnJuegos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuegos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJuegos.Image = global::DigitalGamesStore.Properties.Resources.games;
            this.btnJuegos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJuegos.Location = new System.Drawing.Point(0, 280);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnJuegos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnJuegos.Size = new System.Drawing.Size(250, 60);
            this.btnJuegos.TabIndex = 3;
            this.btnJuegos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJuegos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJuegos.UseVisualStyleBackColor = true;
            this.btnJuegos.Click += new System.EventHandler(this.btnJuegos_Click);
            this.btnJuegos.MouseEnter += new System.EventHandler(this.btnBiblioteca_MouseHover);
            this.btnJuegos.MouseLeave += new System.EventHandler(this.btnBiblioteca_MouseLeave);
            // 
            // btnCarrito
            // 
            this.btnCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarrito.FlatAppearance.BorderSize = 0;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCarrito.Image = global::DigitalGamesStore.Properties.Resources.Group_2;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(0, 220);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCarrito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCarrito.Size = new System.Drawing.Size(250, 60);
            this.btnCarrito.TabIndex = 2;
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            this.btnCarrito.MouseEnter += new System.EventHandler(this.btnBiblioteca_MouseHover);
            this.btnCarrito.MouseLeave += new System.EventHandler(this.btnBiblioteca_MouseLeave);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBiblioteca.Image = global::DigitalGamesStore.Properties.Resources.libraryIcon;
            this.btnBiblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteca.Location = new System.Drawing.Point(0, 160);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBiblioteca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBiblioteca.Size = new System.Drawing.Size(250, 60);
            this.btnBiblioteca.TabIndex = 1;
            this.btnBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            this.btnBiblioteca.MouseEnter += new System.EventHandler(this.btnBiblioteca_MouseHover);
            this.btnBiblioteca.MouseLeave += new System.EventHandler(this.btnBiblioteca_MouseLeave);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicio.Image = global::DigitalGamesStore.Properties.Resources.homeIcon;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 100);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInicio.Size = new System.Drawing.Size(250, 60);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnBiblioteca_MouseHover);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnBiblioteca_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pictureBox1.Image = global::DigitalGamesStore.Properties.Resources.Frame_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLauncher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1154, 626);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLauncher";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJuegos;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConection;
        private System.Windows.Forms.Button btnExit;
    }
}

