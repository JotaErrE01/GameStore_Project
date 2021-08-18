
namespace DigitalGamesStore
{
    partial class FrmAdministrador
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnImagen = new System.Windows.Forms.Button();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbPlataforma = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.lblNombre.Size = new System.Drawing.Size(330, 31);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Bienvenido, Administrador";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnTest);
            this.panelSideMenu.Controls.Add(this.btnListar);
            this.panelSideMenu.Controls.Add(this.btnRegistrar);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 575);
            this.panelSideMenu.TabIndex = 3;
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
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTest.Image = global::DigitalGamesStore.Properties.Resources.conexion;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(0, 220);
            this.btnTest.Name = "btnTest";
            this.btnTest.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTest.Size = new System.Drawing.Size(250, 60);
            this.btnTest.TabIndex = 3;
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseHover);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            // 
            // btnListar
            // 
            this.btnListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListar.Image = global::DigitalGamesStore.Properties.Resources.Listar;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(0, 160);
            this.btnListar.Name = "btnListar";
            this.btnListar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnListar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnListar.Size = new System.Drawing.Size(250, 60);
            this.btnListar.TabIndex = 1;
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            this.btnListar.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseHover);
            this.btnListar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Image = global::DigitalGamesStore.Properties.Resources.Registro;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 100);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrar.Size = new System.Drawing.Size(250, 60);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseHover);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
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
            this.panelChildForm.Controls.Add(this.cmbPlataforma);
            this.panelChildForm.Controls.Add(this.btnImagen);
            this.panelChildForm.Controls.Add(this.checkBox9);
            this.panelChildForm.Controls.Add(this.checkBox8);
            this.panelChildForm.Controls.Add(this.checkBox7);
            this.panelChildForm.Controls.Add(this.checkBox6);
            this.panelChildForm.Controls.Add(this.checkBox5);
            this.panelChildForm.Controls.Add(this.checkBox4);
            this.panelChildForm.Controls.Add(this.checkBox3);
            this.panelChildForm.Controls.Add(this.checkBox2);
            this.panelChildForm.Controls.Add(this.checkBox1);
            this.panelChildForm.Controls.Add(this.cmbClasificacion);
            this.panelChildForm.Controls.Add(this.dateTimePicker1);
            this.panelChildForm.Controls.Add(this.textBox2);
            this.panelChildForm.Controls.Add(this.textBox1);
            this.panelChildForm.Controls.Add(this.pictureBox3);
            this.panelChildForm.Controls.Add(this.btnGuardar);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 75);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(896, 500);
            this.panelChildForm.TabIndex = 5;
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagen.FlatAppearance.BorderSize = 0;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Image = global::DigitalGamesStore.Properties.Resources.btnImagen;
            this.btnImagen.Location = new System.Drawing.Point(590, 197);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(156, 40);
            this.btnImagen.TabIndex = 17;
            this.btnImagen.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.White;
            this.checkBox9.Location = new System.Drawing.Point(746, 449);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(61, 20);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "Sigilo";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.White;
            this.checkBox8.Location = new System.Drawing.Point(468, 388);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(88, 20);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "Estrategia";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.White;
            this.checkBox7.Location = new System.Drawing.Point(606, 327);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 20);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.Text = "Aventura";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.Location = new System.Drawing.Point(606, 388);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(63, 20);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "Lucha";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(746, 327);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 20);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Battle Royal";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(746, 388);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 20);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "MMORPG";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(468, 449);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 20);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "MOBA";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(606, 449);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 20);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Simulacion";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(468, 327);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Accion";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Items.AddRange(new object[] {
            "E – Everyone",
            "EC – Early Childhood",
            "E 10+",
            "T – Teen ",
            "M – Mature 17+ ",
            "AO – Adults only 18+"});
            this.cmbClasificacion.Location = new System.Drawing.Point(292, 200);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(173, 28);
            this.cmbClasificacion.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(307, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(204, 273);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 28);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(326, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 28);
            this.textBox1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(562, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(217, 140);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::DigitalGamesStore.Properties.Resources.Group_31;
            this.btnGuardar.Location = new System.Drawing.Point(154, 406);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 39);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::DigitalGamesStore.Properties.Resources.Registerbtn;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(896, 500);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // cmbPlataforma
            // 
            this.cmbPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlataforma.FormattingEnabled = true;
            this.cmbPlataforma.Items.AddRange(new object[] {
            "E – Everyone",
            "EC – Early Childhood",
            "E 10+",
            "T – Teen ",
            "M – Mature 17+ ",
            "AO – Adults only 18+"});
            this.cmbPlataforma.Location = new System.Drawing.Point(266, 327);
            this.cmbPlataforma.Name = "cmbPlataforma";
            this.cmbPlataforma.Size = new System.Drawing.Size(173, 28);
            this.cmbPlataforma.TabIndex = 18;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 575);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbPlataforma;
    }
}