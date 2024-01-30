namespace CapaPresentacion
{
    partial class MenuProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.texIndice = new System.Windows.Forms.TextBox();
            this.BtnLimpiarBarra = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.texBuscar = new System.Windows.Forms.TextBox();
            this.coBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDescartar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.BtnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.coEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.texTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.texCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DetalleUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // texIndice
            // 
            this.texIndice.Location = new System.Drawing.Point(214, 35);
            this.texIndice.Name = "texIndice";
            this.texIndice.Size = new System.Drawing.Size(33, 20);
            this.texIndice.TabIndex = 55;
            this.texIndice.Text = "-1";
            this.texIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.texIndice.Visible = false;
            // 
            // BtnLimpiarBarra
            // 
            this.BtnLimpiarBarra.BackColor = System.Drawing.Color.White;
            this.BtnLimpiarBarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarBarra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiarBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarBarra.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarBarra.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiarBarra.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiarBarra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiarBarra.IconSize = 18;
            this.BtnLimpiarBarra.Location = new System.Drawing.Point(1032, 23);
            this.BtnLimpiarBarra.Name = "BtnLimpiarBarra";
            this.BtnLimpiarBarra.Size = new System.Drawing.Size(35, 34);
            this.BtnLimpiarBarra.TabIndex = 54;
            this.BtnLimpiarBarra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiarBarra.UseVisualStyleBackColor = false;
            this.BtnLimpiarBarra.Click += new System.EventHandler(this.BtnLimpiarBarra_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 18;
            this.BtnBuscar.Location = new System.Drawing.Point(987, 23);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(39, 34);
            this.BtnBuscar.TabIndex = 53;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // texBuscar
            // 
            this.texBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texBuscar.Location = new System.Drawing.Point(832, 30);
            this.texBuscar.Name = "texBuscar";
            this.texBuscar.Size = new System.Drawing.Size(149, 20);
            this.texBuscar.TabIndex = 52;
            // 
            // coBuscar
            // 
            this.coBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBuscar.FormattingEnabled = true;
            this.coBuscar.Location = new System.Drawing.Point(700, 30);
            this.coBuscar.Name = "coBuscar";
            this.coBuscar.Size = new System.Drawing.Size(126, 21);
            this.coBuscar.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Buscar por:";
            // 
            // texId
            // 
            this.texId.Location = new System.Drawing.Point(214, 11);
            this.texId.Name = "texId";
            this.texId.Size = new System.Drawing.Size(33, 20);
            this.texId.TabIndex = 49;
            this.texId.Text = "0";
            this.texId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.texId.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(753, 59);
            this.label10.TabIndex = 48;
            this.label10.Text = "Lista de Proveedores:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnDescartar
            // 
            this.BtnDescartar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDescartar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescartar.ForeColor = System.Drawing.Color.White;
            this.BtnDescartar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnDescartar.IconColor = System.Drawing.Color.White;
            this.BtnDescartar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDescartar.IconSize = 16;
            this.BtnDescartar.Location = new System.Drawing.Point(52, 369);
            this.BtnDescartar.Name = "BtnDescartar";
            this.BtnDescartar.Size = new System.Drawing.Size(194, 24);
            this.BtnDescartar.TabIndex = 45;
            this.BtnDescartar.Text = "Eliminar";
            this.BtnDescartar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDescartar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDescartar.UseVisualStyleBackColor = false;
            this.BtnDescartar.Click += new System.EventHandler(this.BtnDescartar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 18;
            this.BtnLimpiar.Location = new System.Drawing.Point(52, 340);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(194, 24);
            this.BtnLimpiar.TabIndex = 44;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSelect,
            this.Id,
            this.Documento,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.DgvData.Location = new System.Drawing.Point(323, 99);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvData.RowTemplate.Height = 28;
            this.DgvData.Size = new System.Drawing.Size(753, 399);
            this.DgvData.TabIndex = 47;
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            this.DgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvData_CellPainting);
            // 
            // BtnSelect
            // 
            this.BtnSelect.HeaderText = "";
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.ReadOnly = true;
            this.BtnSelect.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "No. Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado Valor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Detalle Proveedor";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(52, 310);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(194, 24);
            this.BtnGuardar.TabIndex = 43;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // coEstado
            // 
            this.coEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coEstado.FormattingEnabled = true;
            this.coEstado.Location = new System.Drawing.Point(52, 265);
            this.coEstado.Name = "coEstado";
            this.coEstado.Size = new System.Drawing.Size(194, 21);
            this.coEstado.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Estado:";
            // 
            // texTelefono
            // 
            this.texTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texTelefono.Location = new System.Drawing.Point(53, 216);
            this.texTelefono.Name = "texTelefono";
            this.texTelefono.Size = new System.Drawing.Size(194, 20);
            this.texTelefono.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Telefono:";
            // 
            // texCorreo
            // 
            this.texCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texCorreo.Location = new System.Drawing.Point(53, 167);
            this.texCorreo.Name = "texCorreo";
            this.texCorreo.Size = new System.Drawing.Size(194, 20);
            this.texCorreo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Correo:";
            // 
            // texRazonSocial
            // 
            this.texRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texRazonSocial.Location = new System.Drawing.Point(53, 115);
            this.texRazonSocial.Name = "texRazonSocial";
            this.texRazonSocial.Size = new System.Drawing.Size(194, 20);
            this.texRazonSocial.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Razón Social:";
            // 
            // texDocumento
            // 
            this.texDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texDocumento.Location = new System.Drawing.Point(53, 61);
            this.texDocumento.Name = "texDocumento";
            this.texDocumento.Size = new System.Drawing.Size(194, 20);
            this.texDocumento.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Número de Documento:";
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
            this.DetalleUser.Size = new System.Drawing.Size(295, 520);
            this.DetalleUser.TabIndex = 28;
            // 
            // MenuProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 520);
            this.Controls.Add(this.texIndice);
            this.Controls.Add(this.BtnLimpiarBarra);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.texBuscar);
            this.Controls.Add(this.coBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnDescartar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.coEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.texTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texRazonSocial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DetalleUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuProveedores";
            this.Text = "MenuProveedores";
            this.Load += new System.EventHandler(this.MenuProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox texIndice;
        private FontAwesome.Sharp.IconButton BtnLimpiarBarra;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox texBuscar;
        private System.Windows.Forms.ComboBox coBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texId;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnDescartar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.ComboBox coEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DetalleUser;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}