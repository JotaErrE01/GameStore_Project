
namespace DigitalGamesStore
{
    partial class FrmListar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBiblioteca = new System.Windows.Forms.DataGridView();
            this.ImageCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelChild = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBiblioteca
            // 
            this.dgvBiblioteca.AllowUserToAddRows = false;
            this.dgvBiblioteca.AllowUserToDeleteRows = false;
            this.dgvBiblioteca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBiblioteca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBiblioteca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBiblioteca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvBiblioteca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBiblioteca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBiblioteca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBiblioteca.ColumnHeadersHeight = 30;
            this.dgvBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBiblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageCol,
            this.NameCol,
            this.TypeCol,
            this.ReleaseDate,
            this.AgeCol,
            this.PriceCol});
            this.dgvBiblioteca.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBiblioteca.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBiblioteca.EnableHeadersVisualStyles = false;
            this.dgvBiblioteca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(227)))));
            this.dgvBiblioteca.Location = new System.Drawing.Point(75, 92);
            this.dgvBiblioteca.Name = "dgvBiblioteca";
            this.dgvBiblioteca.ReadOnly = true;
            this.dgvBiblioteca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBiblioteca.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBiblioteca.RowHeadersVisible = false;
            this.dgvBiblioteca.RowHeadersWidth = 80;
            this.dgvBiblioteca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBiblioteca.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBiblioteca.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBiblioteca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBiblioteca.Size = new System.Drawing.Size(731, 250);
            this.dgvBiblioteca.TabIndex = 3;
            // 
            // ImageCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.ImageCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.ImageCol.HeaderText = "Imagen";
            this.ImageCol.Name = "ImageCol";
            this.ImageCol.ReadOnly = true;
            this.ImageCol.Width = 63;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Juego";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Width = 74;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Genero";
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            this.TypeCol.Width = 82;
            // 
            // ReleaseDate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ReleaseDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReleaseDate.HeaderText = "Fecha de Lanzamiento";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 187;
            // 
            // AgeCol
            // 
            this.AgeCol.HeaderText = "Clasificacion";
            this.AgeCol.Name = "AgeCol";
            this.AgeCol.ReadOnly = true;
            this.AgeCol.Width = 120;
            // 
            // PriceCol
            // 
            this.PriceCol.HeaderText = "Precio";
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            this.PriceCol.Width = 76;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(487, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 31);
            this.textBox1.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Location = new System.Drawing.Point(356, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 31);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Juego:";
            // 
            // panelChild
            // 
            this.panelChild.Location = new System.Drawing.Point(352, 365);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(147, 87);
            this.panelChild.TabIndex = 19;
            this.panelChild.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::DigitalGamesStore.Properties.Resources.Group_36;
            this.btnEditar.Location = new System.Drawing.Point(118, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 39);
            this.btnEditar.TabIndex = 18;
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
            this.btnEliminar.Image = global::DigitalGamesStore.Properties.Resources.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(635, 380);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 39);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::DigitalGamesStore.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(118, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 39);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvBiblioteca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBiblioteca;
        private System.Windows.Forms.DataGridViewImageColumn ImageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelChild;
    }
}