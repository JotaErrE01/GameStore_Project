
namespace DigitalGamesStore
{
    partial class FrmListarPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPago = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaVendedorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaClienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPagoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtJuego = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPago
            // 
            this.dgvPago.AllowUserToAddRows = false;
            this.dgvPago.AllowUserToDeleteRows = false;
            this.dgvPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPago.ColumnHeadersHeight = 30;
            this.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.cedulaVendedorCol,
            this.cedulaClienteCol,
            this.NameCol,
            this.cantidadcol,
            this.precioCol,
            this.totalCol,
            this.tipoPagoCol,
            this.fechaPagoCol,
            this.fechaPagoFinal});
            this.dgvPago.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPago.EnableHeadersVisualStyles = false;
            this.dgvPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(227)))));
            this.dgvPago.Location = new System.Drawing.Point(12, 122);
            this.dgvPago.Name = "dgvPago";
            this.dgvPago.ReadOnly = true;
            this.dgvPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPago.RowHeadersVisible = false;
            this.dgvPago.RowHeadersWidth = 80;
            this.dgvPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPago.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPago.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPago.Size = new System.Drawing.Size(857, 304);
            this.dgvPago.TabIndex = 1;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 48;
            // 
            // cedulaVendedorCol
            // 
            this.cedulaVendedorCol.HeaderText = "Cedula Vendedor";
            this.cedulaVendedorCol.Name = "cedulaVendedorCol";
            this.cedulaVendedorCol.ReadOnly = true;
            this.cedulaVendedorCol.Width = 152;
            // 
            // cedulaClienteCol
            // 
            this.cedulaClienteCol.HeaderText = "Cedula Cliente";
            this.cedulaClienteCol.Name = "cedulaClienteCol";
            this.cedulaClienteCol.ReadOnly = true;
            this.cedulaClienteCol.Width = 132;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Juego";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Width = 74;
            // 
            // cantidadcol
            // 
            this.cantidadcol.HeaderText = "Cantidad";
            this.cantidadcol.Name = "cantidadcol";
            this.cantidadcol.ReadOnly = true;
            this.cantidadcol.Width = 93;
            // 
            // precioCol
            // 
            this.precioCol.HeaderText = "Precio";
            this.precioCol.Name = "precioCol";
            this.precioCol.ReadOnly = true;
            this.precioCol.Width = 76;
            // 
            // totalCol
            // 
            this.totalCol.HeaderText = "Total";
            this.totalCol.Name = "totalCol";
            this.totalCol.ReadOnly = true;
            this.totalCol.Width = 67;
            // 
            // tipoPagoCol
            // 
            this.tipoPagoCol.HeaderText = "Tipo de Pago";
            this.tipoPagoCol.Name = "tipoPagoCol";
            this.tipoPagoCol.ReadOnly = true;
            this.tipoPagoCol.Width = 126;
            // 
            // fechaPagoCol
            // 
            this.fechaPagoCol.HeaderText = "Fecha de Pago";
            this.fechaPagoCol.Name = "fechaPagoCol";
            this.fechaPagoCol.ReadOnly = true;
            this.fechaPagoCol.Width = 137;
            // 
            // fechaPagoFinal
            // 
            this.fechaPagoFinal.HeaderText = "Pago Final";
            this.fechaPagoFinal.Name = "fechaPagoFinal";
            this.fechaPagoFinal.ReadOnly = true;
            this.fechaPagoFinal.Width = 106;
            // 
            // txtJuego
            // 
            this.txtJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuego.Location = new System.Drawing.Point(254, 25);
            this.txtJuego.Multiline = true;
            this.txtJuego.Name = "txtJuego";
            this.txtJuego.Size = new System.Drawing.Size(235, 28);
            this.txtJuego.TabIndex = 22;
            this.txtJuego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuego_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre del Juego:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnPrint.BackgroundImage = global::DigitalGamesStore.Properties.Resources.PdfBtn;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(346, 442);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(185, 46);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::DigitalGamesStore.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(561, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 39);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::DigitalGamesStore.Properties.Resources.Group_36;
            this.btnEditar.Location = new System.Drawing.Point(58, 442);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(172, 46);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(9)))), ((int)(((byte)(77)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::DigitalGamesStore.Properties.Resources.btneliminarpago;
            this.btnEliminar.Location = new System.Drawing.Point(676, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 46);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cedula del Cliente:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(254, 71);
            this.txtCedulaCliente.Multiline = true;
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(235, 28);
            this.txtCedulaCliente.TabIndex = 27;
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(551, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 46);
            this.panel1.TabIndex = 26;
            // 
            // FrmListarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJuego);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarPago";
            this.Text = "FrmListarPago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPago;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaVendedorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaClienteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoFinal;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Panel panel1;
    }
}