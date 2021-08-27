
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
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
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPago.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPago.EnableHeadersVisualStyles = false;
            this.dgvPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(227)))));
            this.dgvPago.Location = new System.Drawing.Point(12, 71);
            this.dgvPago.Name = "dgvPago";
            this.dgvPago.ReadOnly = true;
            this.dgvPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvPago.RowHeadersVisible = false;
            this.dgvPago.RowHeadersWidth = 80;
            this.dgvPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPago.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvPago.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPago.Size = new System.Drawing.Size(857, 308);
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(9)))), ((int)(((byte)(77)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::DigitalGamesStore.Properties.Resources.btneliminarpago;
            this.btnEliminar.Location = new System.Drawing.Point(49, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 39);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::DigitalGamesStore.Properties.Resources.Group_36;
            this.btnEditar.Location = new System.Drawing.Point(593, 420);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 39);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(303, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 74);
            this.panel1.TabIndex = 20;
            // 
            // FrmListarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarPago";
            this.Text = "FrmListarPago";
            this.Load += new System.EventHandler(this.FrmListarPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}