
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
            this.txtCodigoJuego = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCedulaVendedor = new System.Windows.Forms.TextBox();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.dtpFechaPagoFinal = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigoJuego
            // 
            this.txtCodigoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoJuego.Location = new System.Drawing.Point(280, 73);
            this.txtCodigoJuego.Multiline = true;
            this.txtCodigoJuego.Name = "txtCodigoJuego";
            this.txtCodigoJuego.Size = new System.Drawing.Size(168, 29);
            this.txtCodigoJuego.TabIndex = 0;
            this.txtCodigoJuego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoJuego_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(684, 139);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 29);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtCedulaVendedor
            // 
            this.txtCedulaVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaVendedor.Location = new System.Drawing.Point(280, 201);
            this.txtCedulaVendedor.Multiline = true;
            this.txtCedulaVendedor.Name = "txtCedulaVendedor";
            this.txtCedulaVendedor.Size = new System.Drawing.Size(168, 29);
            this.txtCedulaVendedor.TabIndex = 3;
            this.txtCedulaVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaVendedor_KeyPress);
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(280, 139);
            this.txtCedulaCliente.Multiline = true;
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(168, 29);
            this.txtCedulaCliente.TabIndex = 4;
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
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
            this.cmbTipoPago.Location = new System.Drawing.Point(684, 74);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(168, 28);
            this.cmbTipoPago.TabIndex = 5;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            // 
            // dtpFechaPagoFinal
            // 
            this.dtpFechaPagoFinal.Enabled = false;
            this.dtpFechaPagoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPagoFinal.Location = new System.Drawing.Point(280, 271);
            this.dtpFechaPagoFinal.Name = "dtpFechaPagoFinal";
            this.dtpFechaPagoFinal.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaPagoFinal.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::DigitalGamesStore.Properties.Resources.Group_31;
            this.btnGuardar.Location = new System.Drawing.Point(336, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(201, 39);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImage = global::DigitalGamesStore.Properties.Resources.FrmRegistroPagos;
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaPagoFinal);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.txtCedulaVendedor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigoJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoJuego;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCedulaVendedor;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoFinal;
        private System.Windows.Forms.Button btnGuardar;
    }
}