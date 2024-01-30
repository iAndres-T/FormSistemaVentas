﻿namespace CapaPresentacion.Buscadores
{
    partial class BuscadorCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.BtnLimpiarBarra = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.texBuscar = new System.Windows.Forms.TextBox();
            this.coBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(661, 59);
            this.label10.TabIndex = 52;
            this.label10.Text = "Lista de Clientes:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.NombreCompleto});
            this.DgvData.Location = new System.Drawing.Point(147, 91);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvData.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvData.RowTemplate.Height = 28;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(374, 399);
            this.DgvData.TabIndex = 51;
            this.DgvData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvData_CellMouseDoubleClick);
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
            this.BtnLimpiarBarra.Location = new System.Drawing.Point(625, 35);
            this.BtnLimpiarBarra.Name = "BtnLimpiarBarra";
            this.BtnLimpiarBarra.Size = new System.Drawing.Size(35, 34);
            this.BtnLimpiarBarra.TabIndex = 64;
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
            this.BtnBuscar.Location = new System.Drawing.Point(580, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(39, 34);
            this.BtnBuscar.TabIndex = 63;
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // texBuscar
            // 
            this.texBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texBuscar.Location = new System.Drawing.Point(425, 42);
            this.texBuscar.Name = "texBuscar";
            this.texBuscar.Size = new System.Drawing.Size(149, 20);
            this.texBuscar.TabIndex = 62;
            // 
            // coBuscar
            // 
            this.coBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBuscar.FormattingEnabled = true;
            this.coBuscar.Location = new System.Drawing.Point(293, 42);
            this.coBuscar.Name = "coBuscar";
            this.coBuscar.Size = new System.Drawing.Size(126, 21);
            this.coBuscar.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Buscar por:";
            // 
            // Documento
            // 
            this.Documento.HeaderText = "No. Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // BuscadorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 509);
            this.Controls.Add(this.BtnLimpiarBarra);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.texBuscar);
            this.Controls.Add(this.coBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvData);
            this.Name = "BuscadorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscadorCliente";
            this.Load += new System.EventHandler(this.BuscadorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvData;
        private FontAwesome.Sharp.IconButton BtnLimpiarBarra;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox texBuscar;
        private System.Windows.Forms.ComboBox coBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
    }
}