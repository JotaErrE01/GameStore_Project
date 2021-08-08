
namespace DigitalGamesStore
{
    partial class FrmStart
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnStartAdmin = new System.Windows.Forms.PictureBox();
            this.btnStartLauncher = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartLauncher)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = global::DigitalGamesStore.Properties.Resources.Group_9;
            this.pictureBox3.Location = new System.Drawing.Point(49, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(339, 143);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnStartAdmin
            // 
            this.btnStartAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAdmin.Image = global::DigitalGamesStore.Properties.Resources.btnAdmin;
            this.btnStartAdmin.Location = new System.Drawing.Point(119, 381);
            this.btnStartAdmin.Name = "btnStartAdmin";
            this.btnStartAdmin.Size = new System.Drawing.Size(237, 60);
            this.btnStartAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStartAdmin.TabIndex = 1;
            this.btnStartAdmin.TabStop = false;
            // 
            // btnStartLauncher
            // 
            this.btnStartLauncher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartLauncher.Image = global::DigitalGamesStore.Properties.Resources.firstButton;
            this.btnStartLauncher.Location = new System.Drawing.Point(119, 271);
            this.btnStartLauncher.Name = "btnStartLauncher";
            this.btnStartLauncher.Size = new System.Drawing.Size(237, 61);
            this.btnStartLauncher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStartLauncher.TabIndex = 0;
            this.btnStartLauncher.TabStop = false;
            this.btnStartLauncher.Click += new System.EventHandler(this.btnStartLauncher_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::DigitalGamesStore.Properties.Resources.btnSalir;
            this.btnExit.Location = new System.Drawing.Point(0, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(473, 544);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnStartAdmin);
            this.Controls.Add(this.btnStartLauncher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartLauncher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnStartLauncher;
        private System.Windows.Forms.PictureBox btnStartAdmin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnExit;
    }
}