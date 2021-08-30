
namespace DigitalGamesStore
{
    partial class FrmVendedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnListarPagos = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.dtpFechaPagoFinal = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.txtCedulaVendedor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtidJuego = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 75);
            this.panel1.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Location = new System.Drawing.Point(6, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(280, 31);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Bienvenido, Vendedor";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnListarPagos);
            this.panelSideMenu.Controls.Add(this.btnPago);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 575);
            this.panelSideMenu.TabIndex = 3;
            // 
            // btnListarPagos
            // 
            this.btnListarPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarPagos.FlatAppearance.BorderSize = 0;
            this.btnListarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPagos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListarPagos.Image = global::DigitalGamesStore.Properties.Resources.btnlistarp;
            this.btnListarPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarPagos.Location = new System.Drawing.Point(0, 160);
            this.btnListarPagos.Name = "btnListarPagos";
            this.btnListarPagos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnListarPagos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListarPagos.Size = new System.Drawing.Size(250, 60);
            this.btnListarPagos.TabIndex = 8;
            this.btnListarPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListarPagos.UseVisualStyleBackColor = true;
            this.btnListarPagos.Click += new System.EventHandler(this.btnListarPagos_Click);
            // 
            // btnPago
            // 
            this.btnPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPago.Image = global::DigitalGamesStore.Properties.Resources.Group_38;
            this.btnPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.Location = new System.Drawing.Point(0, 100);
            this.btnPago.Name = "btnPago";
            this.btnPago.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPago.Size = new System.Drawing.Size(250, 60);
            this.btnPago.TabIndex = 6;
            this.btnPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::DigitalGamesStore.Properties.Resources.btnSalir;
            this.btnExit.Location = new System.Drawing.Point(0, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseHover);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
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
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Controls.Add(this.btnRegistrarPago);
            this.panelChildForm.Controls.Add(this.dtpFechaPagoFinal);
            this.panelChildForm.Controls.Add(this.cmbTipoPago);
            this.panelChildForm.Controls.Add(this.txtCedulaCliente);
            this.panelChildForm.Controls.Add(this.txtCedulaVendedor);
            this.panelChildForm.Controls.Add(this.txtCantidad);
            this.panelChildForm.Controls.Add(this.txtidJuego);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 75);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(896, 500);
            this.panelChildForm.TabIndex = 5;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Image = global::DigitalGamesStore.Properties.Resources.pagobtn;
            this.btnRegistrarPago.Location = new System.Drawing.Point(373, 364);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(201, 39);
            this.btnRegistrarPago.TabIndex = 15;
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // dtpFechaPagoFinal
            // 
            this.dtpFechaPagoFinal.Enabled = false;
            this.dtpFechaPagoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoFinal.Location = new System.Drawing.Point(271, 269);
            this.dtpFechaPagoFinal.Name = "dtpFechaPagoFinal";
            this.dtpFechaPagoFinal.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaPagoFinal.TabIndex = 14;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Bitcoin",
            "Paypal"});
            this.cmbTipoPago.Location = new System.Drawing.Point(694, 67);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(168, 28);
            this.cmbTipoPago.TabIndex = 13;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(290, 129);
            this.txtCedulaCliente.Multiline = true;
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(168, 29);
            this.txtCedulaCliente.TabIndex = 12;
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // txtCedulaVendedor
            // 
            this.txtCedulaVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaVendedor.Location = new System.Drawing.Point(290, 200);
            this.txtCedulaVendedor.Multiline = true;
            this.txtCedulaVendedor.Name = "txtCedulaVendedor";
            this.txtCedulaVendedor.Size = new System.Drawing.Size(168, 29);
            this.txtCedulaVendedor.TabIndex = 11;
            this.txtCedulaVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaVendedor_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(694, 138);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 29);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtidJuego
            // 
            this.txtidJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidJuego.Location = new System.Drawing.Point(290, 66);
            this.txtidJuego.Multiline = true;
            this.txtidJuego.Name = "txtidJuego";
            this.txtidJuego.Size = new System.Drawing.Size(168, 29);
            this.txtidJuego.TabIndex = 8;
            this.txtidJuego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidJuego_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::DigitalGamesStore.Properties.Resources.v;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(896, 500);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(564, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 48);
            this.panel2.TabIndex = 16;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 575);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnListarPagos;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoFinal;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.TextBox txtCedulaVendedor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtidJuego;
        private System.Windows.Forms.Panel panel2;
    }
}