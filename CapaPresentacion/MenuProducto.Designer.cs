namespace CapaPresentacion
{
    partial class MenuProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.coEstado = new System.Windows.Forms.ComboBox();
            this.coCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DetalleUser = new System.Windows.Forms.Label();
            this.BtnExportar = new FontAwesome.Sharp.IconButton();
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
            this.label10.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label10.Size = new System.Drawing.Size(753, 70);
            this.label10.TabIndex = 48;
            this.label10.Text = "Lista de Productos:";
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
            this.BtnDescartar.Location = new System.Drawing.Point(52, 373);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(52, 344);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSelect,
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.IdCategoria,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.EstadoValor,
            this.Estado});
            this.DgvData.Location = new System.Drawing.Point(323, 99);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 55;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 90;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 90;
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
            this.Estado.Width = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Detalle Producto";
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
            this.BtnGuardar.Location = new System.Drawing.Point(52, 314);
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
            this.coEstado.Location = new System.Drawing.Point(52, 269);
            this.coEstado.Name = "coEstado";
            this.coEstado.Size = new System.Drawing.Size(194, 21);
            this.coEstado.TabIndex = 42;
            // 
            // coCategoria
            // 
            this.coCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coCategoria.FormattingEnabled = true;
            this.coCategoria.Location = new System.Drawing.Point(52, 217);
            this.coCategoria.Name = "coCategoria";
            this.coCategoria.Size = new System.Drawing.Size(194, 21);
            this.coCategoria.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Categoria:";
            // 
            // texDescripcion
            // 
            this.texDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texDescripcion.Location = new System.Drawing.Point(53, 167);
            this.texDescripcion.Name = "texDescripcion";
            this.texDescripcion.Size = new System.Drawing.Size(194, 20);
            this.texDescripcion.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descripción:";
            // 
            // texNombre
            // 
            this.texNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texNombre.Location = new System.Drawing.Point(53, 115);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(194, 20);
            this.texNombre.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre:";
            // 
            // texCodigo
            // 
            this.texCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texCodigo.Location = new System.Drawing.Point(53, 61);
            this.texCodigo.Name = "texCodigo";
            this.texCodigo.Size = new System.Drawing.Size(194, 20);
            this.texCodigo.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Codigo:";
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
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.White;
            this.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExportar.ForeColor = System.Drawing.Color.Black;
            this.BtnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnExportar.IconColor = System.Drawing.Color.ForestGreen;
            this.BtnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportar.IconSize = 16;
            this.BtnExportar.Location = new System.Drawing.Point(349, 44);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(126, 25);
            this.BtnExportar.TabIndex = 56;
            this.BtnExportar.Text = "Descargar Excel";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // MenuProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 520);
            this.Controls.Add(this.BtnExportar);
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
            this.Controls.Add(this.coCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DetalleUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuProducto";
            this.Text = "MenuProducto";
            this.Load += new System.EventHandler(this.MenuProducto_Load);
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
        private System.Windows.Forms.ComboBox coCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DetalleUser;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton BtnExportar;
    }
}