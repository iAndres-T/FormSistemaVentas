namespace CapaPresentacion
{
    partial class MenuVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.texStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.texPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscarProd = new FontAwesome.Sharp.IconButton();
            this.texIdProducto = new System.Windows.Forms.TextBox();
            this.texNombreProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texCodigoProd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarDoc = new FontAwesome.Sharp.IconButton();
            this.texNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texDocumentoCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coDocumento = new System.Windows.Forms.ComboBox();
            this.texFecha = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.texTotalPagar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.texCambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.texPago = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Registrar Venta";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(753, 463);
            this.label10.TabIndex = 23;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numCantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.texStock);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.texPrecio);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BtnBuscarProd);
            this.groupBox3.Controls.Add(this.texIdProducto);
            this.groupBox3.Controls.Add(this.texNombreProd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.texCodigoProd);
            this.groupBox3.Location = new System.Drawing.Point(188, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 77);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(512, 42);
            this.numCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(92, 20);
            this.numCantidad.TabIndex = 32;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(509, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Cantidad:";
            // 
            // texStock
            // 
            this.texStock.BackColor = System.Drawing.SystemColors.Window;
            this.texStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texStock.Location = new System.Drawing.Point(413, 42);
            this.texStock.Name = "texStock";
            this.texStock.ReadOnly = true;
            this.texStock.Size = new System.Drawing.Size(81, 20);
            this.texStock.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Stock:";
            // 
            // texPrecio
            // 
            this.texPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.texPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texPrecio.Location = new System.Drawing.Point(305, 42);
            this.texPrecio.Name = "texPrecio";
            this.texPrecio.ReadOnly = true;
            this.texPrecio.Size = new System.Drawing.Size(86, 20);
            this.texPrecio.TabIndex = 28;
            this.texPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texPrecio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Precio:";
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.BackColor = System.Drawing.Color.White;
            this.BtnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProd.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarProd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarProd.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProd.IconSize = 18;
            this.BtnBuscarProd.Location = new System.Drawing.Point(144, 42);
            this.BtnBuscarProd.Name = "BtnBuscarProd";
            this.BtnBuscarProd.Size = new System.Drawing.Size(25, 22);
            this.BtnBuscarProd.TabIndex = 26;
            this.BtnBuscarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarProd.UseVisualStyleBackColor = false;
            this.BtnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // texIdProducto
            // 
            this.texIdProducto.BackColor = System.Drawing.SystemColors.Window;
            this.texIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texIdProducto.Location = new System.Drawing.Point(113, 17);
            this.texIdProducto.Name = "texIdProducto";
            this.texIdProducto.Size = new System.Drawing.Size(25, 20);
            this.texIdProducto.TabIndex = 25;
            this.texIdProducto.Visible = false;
            // 
            // texNombreProd
            // 
            this.texNombreProd.BackColor = System.Drawing.SystemColors.Window;
            this.texNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texNombreProd.Location = new System.Drawing.Point(187, 43);
            this.texNombreProd.Name = "texNombreProd";
            this.texNombreProd.ReadOnly = true;
            this.texNombreProd.Size = new System.Drawing.Size(108, 20);
            this.texNombreProd.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Codigo Producto:";
            // 
            // texCodigoProd
            // 
            this.texCodigoProd.BackColor = System.Drawing.SystemColors.Window;
            this.texCodigoProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texCodigoProd.Location = new System.Drawing.Point(6, 43);
            this.texCodigoProd.Name = "texCodigoProd";
            this.texCodigoProd.Size = new System.Drawing.Size(132, 20);
            this.texCodigoProd.TabIndex = 0;
            this.texCodigoProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texCodigoProd_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BtnBuscarDoc);
            this.groupBox2.Controls.Add(this.texNombreCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.texDocumentoCliente);
            this.groupBox2.Location = new System.Drawing.Point(542, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 79);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // BtnBuscarDoc
            // 
            this.BtnBuscarDoc.BackColor = System.Drawing.Color.White;
            this.BtnBuscarDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarDoc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarDoc.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarDoc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarDoc.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarDoc.IconSize = 18;
            this.BtnBuscarDoc.Location = new System.Drawing.Point(144, 42);
            this.BtnBuscarDoc.Name = "BtnBuscarDoc";
            this.BtnBuscarDoc.Size = new System.Drawing.Size(25, 22);
            this.BtnBuscarDoc.TabIndex = 26;
            this.BtnBuscarDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarDoc.UseVisualStyleBackColor = false;
            this.BtnBuscarDoc.Click += new System.EventHandler(this.BtnBuscarDoc_Click);
            // 
            // texNombreCliente
            // 
            this.texNombreCliente.BackColor = System.Drawing.SystemColors.Window;
            this.texNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texNombreCliente.Location = new System.Drawing.Point(187, 43);
            this.texNombreCliente.Name = "texNombreCliente";
            this.texNombreCliente.ReadOnly = true;
            this.texNombreCliente.Size = new System.Drawing.Size(158, 20);
            this.texNombreCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Completo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numero Documento:";
            // 
            // texDocumentoCliente
            // 
            this.texDocumentoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.texDocumentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texDocumentoCliente.Location = new System.Drawing.Point(6, 43);
            this.texDocumentoCliente.Name = "texDocumentoCliente";
            this.texDocumentoCliente.ReadOnly = true;
            this.texDocumentoCliente.Size = new System.Drawing.Size(132, 20);
            this.texDocumentoCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.coDocumento);
            this.groupBox1.Controls.Add(this.texFecha);
            this.groupBox1.Location = new System.Drawing.Point(188, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 79);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 23);
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
            // coDocumento
            // 
            this.coDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.coDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coDocumento.FormattingEnabled = true;
            this.coDocumento.Location = new System.Drawing.Point(122, 42);
            this.coDocumento.Name = "coDocumento";
            this.coDocumento.Size = new System.Drawing.Size(173, 21);
            this.coDocumento.TabIndex = 1;
            // 
            // texFecha
            // 
            this.texFecha.BackColor = System.Drawing.SystemColors.Window;
            this.texFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texFecha.Location = new System.Drawing.Point(6, 43);
            this.texFecha.Name = "texFecha";
            this.texFecha.ReadOnly = true;
            this.texFecha.Size = new System.Drawing.Size(100, 20);
            this.texFecha.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BtnAgregar.IconColor = System.Drawing.Color.ForestGreen;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 35;
            this.BtnAgregar.Location = new System.Drawing.Point(805, 185);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(95, 69);
            this.BtnAgregar.TabIndex = 31;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.BtnDelete});
            this.DgvData.Location = new System.Drawing.Point(188, 260);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 30;
            this.DgvData.Size = new System.Drawing.Size(611, 228);
            this.DgvData.TabIndex = 32;
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            this.DgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvData_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 117;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.HeaderText = "";
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ReadOnly = true;
            this.BtnDelete.Width = 50;
            // 
            // BtnCrearVenta
            // 
            this.BtnCrearVenta.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearVenta.ForeColor = System.Drawing.Color.Black;
            this.BtnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.BtnCrearVenta.IconColor = System.Drawing.Color.SteelBlue;
            this.BtnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCrearVenta.IconSize = 23;
            this.BtnCrearVenta.Location = new System.Drawing.Point(813, 451);
            this.BtnCrearVenta.Name = "BtnCrearVenta";
            this.BtnCrearVenta.Size = new System.Drawing.Size(95, 37);
            this.BtnCrearVenta.TabIndex = 35;
            this.BtnCrearVenta.Text = "Crear Venta";
            this.BtnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCrearVenta.UseVisualStyleBackColor = false;
            this.BtnCrearVenta.Click += new System.EventHandler(this.BtnCrearVenta_Click);
            // 
            // texTotalPagar
            // 
            this.texTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.texTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texTotalPagar.Location = new System.Drawing.Point(813, 313);
            this.texTotalPagar.Name = "texTotalPagar";
            this.texTotalPagar.ReadOnly = true;
            this.texTotalPagar.Size = new System.Drawing.Size(95, 20);
            this.texTotalPagar.TabIndex = 37;
            this.texTotalPagar.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(810, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Total a Pagar:";
            // 
            // texCambio
            // 
            this.texCambio.BackColor = System.Drawing.SystemColors.Window;
            this.texCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texCambio.Location = new System.Drawing.Point(813, 407);
            this.texCambio.Name = "texCambio";
            this.texCambio.ReadOnly = true;
            this.texCambio.Size = new System.Drawing.Size(95, 20);
            this.texCambio.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(810, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Cambio:";
            // 
            // texPago
            // 
            this.texPago.BackColor = System.Drawing.SystemColors.Window;
            this.texPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texPago.Location = new System.Drawing.Point(813, 362);
            this.texPago.Name = "texPago";
            this.texPago.Size = new System.Drawing.Size(95, 20);
            this.texPago.TabIndex = 41;
            this.texPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texPago_KeyDown);
            this.texPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texPago_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(810, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Paga con:";
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 541);
            this.Controls.Add(this.texPago);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.texCambio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnCrearVenta);
            this.Controls.Add(this.texTotalPagar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuVentas";
            this.Text = "MenuVentas";
            this.Load += new System.EventHandler(this.MenuVentas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox texStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox texPrecio;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton BtnBuscarProd;
        private System.Windows.Forms.TextBox texIdProducto;
        private System.Windows.Forms.TextBox texNombreProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texCodigoProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton BtnBuscarDoc;
        private System.Windows.Forms.TextBox texNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texDocumentoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox coDocumento;
        private System.Windows.Forms.TextBox texFecha;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
        private FontAwesome.Sharp.IconButton BtnCrearVenta;
        private System.Windows.Forms.TextBox texTotalPagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox texCambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox texPago;
        private System.Windows.Forms.Label label14;
    }
}