namespace CapaPresentacion
{
    partial class MenuDetalleCompra
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
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarDoc = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.texBuscarDocumento = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texFecha = new System.Windows.Forms.TextBox();
            this.texTipoDocumento = new System.Windows.Forms.TextBox();
            this.texUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.texNumeroDocumento = new System.Windows.Forms.TextBox();
            this.texRazonSocial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texDocumentoProv = new System.Windows.Forms.TextBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.texMontoTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnPDF = new FontAwesome.Sharp.IconButton();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(734, 521);
            this.label10.TabIndex = 22;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Detalle Compra";
            // 
            // BtnBuscarDoc
            // 
            this.BtnBuscarDoc.BackColor = System.Drawing.Color.White;
            this.BtnBuscarDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarDoc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarDoc.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarDoc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarDoc.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarDoc.IconSize = 18;
            this.BtnBuscarDoc.Location = new System.Drawing.Point(733, 51);
            this.BtnBuscarDoc.Name = "BtnBuscarDoc";
            this.BtnBuscarDoc.Size = new System.Drawing.Size(81, 24);
            this.BtnBuscarDoc.TabIndex = 29;
            this.BtnBuscarDoc.Text = "Buscar";
            this.BtnBuscarDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarDoc.UseVisualStyleBackColor = false;
            this.BtnBuscarDoc.Click += new System.EventHandler(this.BtnBuscarDoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(484, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Numero Documento:";
            // 
            // texBuscarDocumento
            // 
            this.texBuscarDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.texBuscarDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texBuscarDocumento.Location = new System.Drawing.Point(595, 52);
            this.texBuscarDocumento.Name = "texBuscarDocumento";
            this.texBuscarDocumento.Size = new System.Drawing.Size(132, 20);
            this.texBuscarDocumento.TabIndex = 27;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.White;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 18;
            this.BtnLimpiar.Location = new System.Drawing.Point(820, 51);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(81, 24);
            this.BtnLimpiar.TabIndex = 30;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.texUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.texTipoDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.texFecha);
            this.groupBox1.Location = new System.Drawing.Point(215, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 79);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // texFecha
            // 
            this.texFecha.BackColor = System.Drawing.Color.LightGray;
            this.texFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texFecha.Location = new System.Drawing.Point(6, 43);
            this.texFecha.Name = "texFecha";
            this.texFecha.ReadOnly = true;
            this.texFecha.Size = new System.Drawing.Size(155, 20);
            this.texFecha.TabIndex = 0;
            // 
            // texTipoDocumento
            // 
            this.texTipoDocumento.BackColor = System.Drawing.Color.LightGray;
            this.texTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texTipoDocumento.Location = new System.Drawing.Point(192, 43);
            this.texTipoDocumento.Name = "texTipoDocumento";
            this.texTipoDocumento.ReadOnly = true;
            this.texTipoDocumento.Size = new System.Drawing.Size(207, 20);
            this.texTipoDocumento.TabIndex = 4;
            // 
            // texUsuario
            // 
            this.texUsuario.BackColor = System.Drawing.Color.LightGray;
            this.texUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texUsuario.Location = new System.Drawing.Point(425, 43);
            this.texUsuario.Name = "texUsuario";
            this.texUsuario.ReadOnly = true;
            this.texUsuario.Size = new System.Drawing.Size(207, 20);
            this.texUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.texNumeroDocumento);
            this.groupBox2.Controls.Add(this.texRazonSocial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.texDocumentoProv);
            this.groupBox2.Location = new System.Drawing.Point(215, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 79);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // texNumeroDocumento
            // 
            this.texNumeroDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.texNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texNumeroDocumento.Location = new System.Drawing.Point(655, 17);
            this.texNumeroDocumento.Name = "texNumeroDocumento";
            this.texNumeroDocumento.Size = new System.Drawing.Size(25, 20);
            this.texNumeroDocumento.TabIndex = 25;
            this.texNumeroDocumento.Visible = false;
            // 
            // texRazonSocial
            // 
            this.texRazonSocial.BackColor = System.Drawing.Color.LightGray;
            this.texRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texRazonSocial.Location = new System.Drawing.Point(259, 43);
            this.texRazonSocial.Name = "texRazonSocial";
            this.texRazonSocial.ReadOnly = true;
            this.texRazonSocial.Size = new System.Drawing.Size(209, 20);
            this.texRazonSocial.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Razon Social:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Numero Documento:";
            // 
            // texDocumentoProv
            // 
            this.texDocumentoProv.BackColor = System.Drawing.Color.LightGray;
            this.texDocumentoProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texDocumentoProv.Location = new System.Drawing.Point(6, 43);
            this.texDocumentoProv.Name = "texDocumentoProv";
            this.texDocumentoProv.ReadOnly = true;
            this.texDocumentoProv.Size = new System.Drawing.Size(224, 20);
            this.texDocumentoProv.TabIndex = 0;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.DgvData.Location = new System.Drawing.Point(215, 260);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 30;
            this.DgvData.Size = new System.Drawing.Size(686, 226);
            this.DgvData.TabIndex = 33;
            // 
            // texMontoTotal
            // 
            this.texMontoTotal.BackColor = System.Drawing.Color.LightGray;
            this.texMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texMontoTotal.Location = new System.Drawing.Point(292, 497);
            this.texMontoTotal.Name = "texMontoTotal";
            this.texMontoTotal.ReadOnly = true;
            this.texMontoTotal.Size = new System.Drawing.Size(65, 20);
            this.texMontoTotal.TabIndex = 36;
            this.texMontoTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(212, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Monto Total:";
            // 
            // BtnPDF
            // 
            this.BtnPDF.BackColor = System.Drawing.Color.White;
            this.BtnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPDF.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPDF.ForeColor = System.Drawing.Color.Black;
            this.BtnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.BtnPDF.IconColor = System.Drawing.Color.Firebrick;
            this.BtnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPDF.IconSize = 16;
            this.BtnPDF.Location = new System.Drawing.Point(775, 497);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(126, 25);
            this.BtnPDF.TabIndex = 57;
            this.BtnPDF.Text = "Descargar PDF";
            this.BtnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPDF.UseVisualStyleBackColor = false;
            this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 112;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 130;
            // 
            // MenuDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 541);
            this.Controls.Add(this.BtnPDF);
            this.Controls.Add(this.texMontoTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscarDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texBuscarDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuDetalleCompra";
            this.Text = "MenuDetalleCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnBuscarDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texBuscarDocumento;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox texUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox texNumeroDocumento;
        private System.Windows.Forms.TextBox texRazonSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texDocumentoProv;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.TextBox texMontoTotal;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton BtnPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}