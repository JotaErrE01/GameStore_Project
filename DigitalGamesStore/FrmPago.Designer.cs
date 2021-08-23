
namespace DigitalGamesStore
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.txtidJuego = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCedulaVendedor = new System.Windows.Forms.TextBox();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.dtpFechaPagoFinal = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtidJuego
            // 
            this.txtidJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidJuego.Location = new System.Drawing.Point(290, 67);
            this.txtidJuego.Multiline = true;
            this.txtidJuego.Name = "txtidJuego";
            this.txtidJuego.Size = new System.Drawing.Size(168, 29);
            this.txtidJuego.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(694, 201);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(92, 29);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(694, 139);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 29);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtCedulaVendedor
            // 
            this.txtCedulaVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaVendedor.Location = new System.Drawing.Point(290, 201);
            this.txtCedulaVendedor.Multiline = true;
            this.txtCedulaVendedor.Name = "txtCedulaVendedor";
            this.txtCedulaVendedor.Size = new System.Drawing.Size(168, 29);
            this.txtCedulaVendedor.TabIndex = 3;
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(290, 130);
            this.txtCedulaCliente.Multiline = true;
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(168, 29);
            this.txtCedulaCliente.TabIndex = 4;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Bitcoin",
            "Paypal"});
            this.cmbTipoPago.Location = new System.Drawing.Point(694, 68);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(168, 28);
            this.cmbTipoPago.TabIndex = 5;
            this.cmbTipoPago.TextUpdate += new System.EventHandler(this.cmbTipoPago_TextUpdate);
            // 
            // dtpFechaPagoFinal
            // 
            this.dtpFechaPagoFinal.Enabled = false;
            this.dtpFechaPagoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoFinal.Location = new System.Drawing.Point(271, 270);
            this.dtpFechaPagoFinal.Name = "dtpFechaPagoFinal";
            this.dtpFechaPagoFinal.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaPagoFinal.TabIndex = 6;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPago.Image")));
            this.btnRegistrarPago.Location = new System.Drawing.Point(373, 365);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(201, 39);
            this.btnRegistrarPago.TabIndex = 7;
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.dtpFechaPagoFinal);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.txtCedulaVendedor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtidJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidJuego;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCedulaVendedor;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoFinal;
        private System.Windows.Forms.Button btnRegistrarPago;
    }
}