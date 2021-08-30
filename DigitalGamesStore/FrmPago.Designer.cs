﻿
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
            this.txtidJuego = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCedulaVendedor = new System.Windows.Forms.TextBox();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.dtpFechaPagoFinal = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::DigitalGamesStore.Properties.Resources.Group_31;
            this.btnGuardar.Location = new System.Drawing.Point(373, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(201, 39);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(559, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 79);
            this.panel1.TabIndex = 8;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImage = global::DigitalGamesStore.Properties.Resources.v;
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaPagoFinal);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.txtCedulaVendedor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtidJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidJuego;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCedulaVendedor;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPagoFinal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
    }
}