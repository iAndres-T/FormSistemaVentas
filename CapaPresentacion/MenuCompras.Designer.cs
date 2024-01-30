namespace CapaPresentacion
{
    partial class MenuCompras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coDocumento = new System.Windows.Forms.ComboBox();
            this.texFecha = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarDoc = new FontAwesome.Sharp.IconButton();
            this.texIdProveedor = new System.Windows.Forms.TextBox();
            this.texNombreProv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texDocumentoProv = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.texPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.texPrecioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscarProd = new FontAwesome.Sharp.IconButton();
            this.texIdProducto = new System.Windows.Forms.TextBox();
            this.texNombreProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texCodigoProd = new System.Windows.Forms.TextBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.texTotalPagar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(753, 463);
            this.label10.TabIndex = 21;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.coDocumento);
            this.groupBox1.Controls.Add(this.texFecha);
            this.groupBox1.Location = new System.Drawing.Point(188, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 79);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BtnBuscarDoc);
            this.groupBox2.Controls.Add(this.texIdProveedor);
            this.groupBox2.Controls.Add(this.texNombreProv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.texDocumentoProv);
            this.groupBox2.Location = new System.Drawing.Point(542, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 79);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
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
            // texIdProveedor
            // 
            this.texIdProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.texIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texIdProveedor.Location = new System.Drawing.Point(320, 16);
            this.texIdProveedor.Name = "texIdProveedor";
            this.texIdProveedor.Size = new System.Drawing.Size(25, 20);
            this.texIdProveedor.TabIndex = 25;
            this.texIdProveedor.Visible = false;
            // 
            // texNombreProv
            // 
            this.texNombreProv.BackColor = System.Drawing.SystemColors.Window;
            this.texNombreProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texNombreProv.Location = new System.Drawing.Point(187, 43);
            this.texNombreProv.Name = "texNombreProv";
            this.texNombreProv.Size = new System.Drawing.Size(158, 20);
            this.texNombreProv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Razon Social:";
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
            // texDocumentoProv
            // 
            this.texDocumentoProv.BackColor = System.Drawing.SystemColors.Window;
            this.texDocumentoProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texDocumentoProv.Location = new System.Drawing.Point(6, 43);
            this.texDocumentoProv.Name = "texDocumentoProv";
            this.texDocumentoProv.Size = new System.Drawing.Size(132, 20);
            this.texDocumentoProv.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numCantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.texPrecioVenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.texPrecioCompra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BtnBuscarProd);
            this.groupBox3.Controls.Add(this.texIdProducto);
            this.groupBox3.Controls.Add(this.texNombreProd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.texCodigoProd);
            this.groupBox3.Location = new System.Drawing.Point(188, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 77);
            this.groupBox3.TabIndex = 27;
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
            // texPrecioVenta
            // 
            this.texPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.texPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texPrecioVenta.Location = new System.Drawing.Point(413, 42);
            this.texPrecioVenta.Name = "texPrecioVenta";
            this.texPrecioVenta.Size = new System.Drawing.Size(81, 20);
            this.texPrecioVenta.TabIndex = 30;
            this.texPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texPrecioVenta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Precio Venta:";
            // 
            // texPrecioCompra
            // 
            this.texPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.texPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texPrecioCompra.Location = new System.Drawing.Point(305, 42);
            this.texPrecioCompra.Name = "texPrecioCompra";
            this.texPrecioCompra.Size = new System.Drawing.Size(86, 20);
            this.texPrecioCompra.TabIndex = 28;
            this.texPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texPrecioCompra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Precio Compra:";
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
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Stock,
            this.SubTotal,
            this.BtnDelete});
            this.DgvData.Location = new System.Drawing.Point(188, 246);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 30;
            this.DgvData.Size = new System.Drawing.Size(611, 228);
            this.DgvData.TabIndex = 28;
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
            this.PrecioCompra.Width = 117;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Cantidad";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
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
            // texTotalPagar
            // 
            this.texTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.texTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texTotalPagar.Location = new System.Drawing.Point(813, 405);
            this.texTotalPagar.Name = "texTotalPagar";
            this.texTotalPagar.Size = new System.Drawing.Size(95, 20);
            this.texTotalPagar.TabIndex = 34;
            this.texTotalPagar.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(810, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Total a Pagar:";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.BtnRegistrar.IconColor = System.Drawing.Color.SteelBlue;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 23;
            this.BtnRegistrar.Location = new System.Drawing.Point(813, 431);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(95, 29);
            this.BtnRegistrar.TabIndex = 33;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
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
            this.BtnAgregar.Location = new System.Drawing.Point(805, 171);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(95, 69);
            this.BtnAgregar.TabIndex = 27;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // MenuCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 520);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.texTotalPagar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuCompras";
            this.Text = "MenuCompras";
            this.Load += new System.EventHandler(this.MenuCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox coDocumento;
        private System.Windows.Forms.TextBox texFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox texIdProveedor;
        private System.Windows.Forms.TextBox texNombreProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texDocumentoProv;
        private FontAwesome.Sharp.IconButton BtnBuscarDoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton BtnBuscarProd;
        private System.Windows.Forms.TextBox texIdProducto;
        private System.Windows.Forms.TextBox texNombreProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texCodigoProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox texPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox texPrecioCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.DataGridView DgvData;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.TextBox texTotalPagar;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}