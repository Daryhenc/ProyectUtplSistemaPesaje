
namespace ProyectBasculaUtpl.Pesaje.Salida
{
    partial class FrmBusquedaEntrada
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
            this.dgvDato = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdBoletoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoEntradaQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDato
            // 
            this.dgvDato.AllowUserToAddRows = false;
            this.dgvDato.AllowUserToDeleteRows = false;
            this.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBoletoDetalle,
            this.Cod,
            this.Producto,
            this.Nombre,
            this.Ci,
            this.Vehiculo,
            this.Placa,
            this.Humedad,
            this.Impureza,
            this.PesoEntrada,
            this.PesoEntradaQQ,
            this.Fecha});
            this.dgvDato.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDato.Location = new System.Drawing.Point(0, 0);
            this.dgvDato.Name = "dgvDato";
            this.dgvDato.ReadOnly = true;
            this.dgvDato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDato.Size = new System.Drawing.Size(879, 493);
            this.dgvDato.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 95);
            this.panel1.TabIndex = 2;
            // 
            // IdBoletoDetalle
            // 
            this.IdBoletoDetalle.HeaderText = "IdBoletoDetalle";
            this.IdBoletoDetalle.Name = "IdBoletoDetalle";
            this.IdBoletoDetalle.ReadOnly = true;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "COD";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 70;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "PRODUCTO";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Ci
            // 
            this.Ci.HeaderText = "CI";
            this.Ci.Name = "Ci";
            this.Ci.ReadOnly = true;
            this.Ci.Width = 90;
            // 
            // Vehiculo
            // 
            this.Vehiculo.HeaderText = "VEHICULO";
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "PLACA";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 80;
            // 
            // Humedad
            // 
            this.Humedad.HeaderText = "HUME.";
            this.Humedad.Name = "Humedad";
            this.Humedad.ReadOnly = true;
            this.Humedad.Width = 70;
            // 
            // Impureza
            // 
            this.Impureza.HeaderText = "IMP.";
            this.Impureza.Name = "Impureza";
            this.Impureza.ReadOnly = true;
            this.Impureza.Width = 70;
            // 
            // PesoEntrada
            // 
            this.PesoEntrada.HeaderText = "ENTR. KG";
            this.PesoEntrada.Name = "PesoEntrada";
            this.PesoEntrada.ReadOnly = true;
            // 
            // PesoEntradaQQ
            // 
            this.PesoEntradaQQ.HeaderText = "SALI. QQ";
            this.PesoEntradaQQ.Name = "PesoEntradaQQ";
            this.PesoEntradaQQ.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "FECHA";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnAceptar.Location = new System.Drawing.Point(0, 0);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(125, 95);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCancelar.Location = new System.Drawing.Point(754, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(125, 95);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmBusquedaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBusquedaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBusquedaEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoletoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoEntradaQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}