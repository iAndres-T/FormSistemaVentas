namespace CapaPresentacion
{
    partial class MenuNegocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.DetalleUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.texDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texRUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texNegocio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSubir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Detalle Negocio";
            // 
            // DetalleUser
            // 
            this.DetalleUser.BackColor = System.Drawing.Color.White;
            this.DetalleUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetalleUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.DetalleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleUser.Location = new System.Drawing.Point(0, 0);
            this.DetalleUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DetalleUser.Name = "DetalleUser";
            this.DetalleUser.Size = new System.Drawing.Size(518, 520);
            this.DetalleUser.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.texDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.texRUC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.texNegocio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnSubir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureLogo);
            this.groupBox1.Location = new System.Drawing.Point(16, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 304);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Silver;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnGuardar.IconColor = System.Drawing.Color.Black;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 18;
            this.BtnGuardar.Location = new System.Drawing.Point(216, 216);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(194, 23);
            this.BtnGuardar.TabIndex = 41;
            this.BtnGuardar.Text = "Guardar Cambios";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // texDireccion
            // 
            this.texDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texDireccion.Location = new System.Drawing.Point(216, 168);
            this.texDireccion.Name = "texDireccion";
            this.texDireccion.Size = new System.Drawing.Size(194, 20);
            this.texDireccion.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Direccion:";
            // 
            // texRUC
            // 
            this.texRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texRUC.Location = new System.Drawing.Point(216, 116);
            this.texRUC.Name = "texRUC";
            this.texRUC.Size = new System.Drawing.Size(194, 20);
            this.texRUC.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(213, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "RUC:";
            // 
            // texNegocio
            // 
            this.texNegocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texNegocio.Location = new System.Drawing.Point(216, 62);
            this.texNegocio.Name = "texNegocio";
            this.texNegocio.Size = new System.Drawing.Size(194, 20);
            this.texNegocio.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre Negocio:";
            // 
            // BtnSubir
            // 
            this.BtnSubir.BackColor = System.Drawing.Color.Silver;
            this.BtnSubir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSubir.FlatAppearance.BorderSize = 0;
            this.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnSubir.IconColor = System.Drawing.Color.Black;
            this.BtnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSubir.IconSize = 18;
            this.BtnSubir.Location = new System.Drawing.Point(6, 216);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(177, 23);
            this.BtnSubir.TabIndex = 2;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSubir.UseVisualStyleBackColor = false;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logo:";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Location = new System.Drawing.Point(6, 45);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(177, 164);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // MenuNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DetalleUser);
            this.Name = "MenuNegocio";
            this.Text = "MenuNegocio";
            this.Load += new System.EventHandler(this.MenuNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DetalleUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton BtnSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TextBox texDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texRUC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texNegocio;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtnGuardar;
    }
}