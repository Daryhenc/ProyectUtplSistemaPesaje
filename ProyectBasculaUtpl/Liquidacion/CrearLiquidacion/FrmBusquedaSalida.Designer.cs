
namespace ProyectBasculaUtpl.Liquidacion.CrearLiquidacion
{
    partial class FrmBusquedaSalida
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
            this.dgvDato = new System.Windows.Forms.DataGridView();
            this.IdBoletoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEntradaKG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEntradaQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSalidaKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSalidaQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 91);
            this.panel1.TabIndex = 4;
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
            this.PEntradaKG,
            this.PEntradaQQ,
            this.PSalidaKg,
            this.PSalidaQQ});
            this.dgvDato.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDato.Location = new System.Drawing.Point(0, 0);
            this.dgvDato.Name = "dgvDato";
            this.dgvDato.ReadOnly = true;
            this.dgvDato.Size = new System.Drawing.Size(961, 578);
            this.dgvDato.TabIndex = 3;
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
            // 
            // Ci
            // 
            this.Ci.HeaderText = "CI";
            this.Ci.Name = "Ci";
            this.Ci.ReadOnly = true;
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
            // 
            // Humedad
            // 
            this.Humedad.HeaderText = "HUMEDAD";
            this.Humedad.Name = "Humedad";
            this.Humedad.ReadOnly = true;
            // 
            // Impureza
            // 
            this.Impureza.HeaderText = "IMPUREZA";
            this.Impureza.Name = "Impureza";
            this.Impureza.ReadOnly = true;
            // 
            // PEntradaKG
            // 
            this.PEntradaKG.HeaderText = "ENT. KG";
            this.PEntradaKG.Name = "PEntradaKG";
            this.PEntradaKG.ReadOnly = true;
            // 
            // PEntradaQQ
            // 
            this.PEntradaQQ.HeaderText = "ENT. QQ";
            this.PEntradaQQ.Name = "PEntradaQQ";
            this.PEntradaQQ.ReadOnly = true;
            // 
            // PSalidaKg
            // 
            this.PSalidaKg.HeaderText = "SAL. KG";
            this.PSalidaKg.Name = "PSalidaKg";
            this.PSalidaKg.ReadOnly = true;
            // 
            // PSalidaQQ
            // 
            this.PSalidaQQ.HeaderText = "SAL. QQ";
            this.PSalidaQQ.Name = "PSalidaQQ";
            this.PSalidaQQ.ReadOnly = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnCancelar.Location = new System.Drawing.Point(836, 0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(125, 91);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnAceptar.Size = new System.Drawing.Size(125, 91);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmBusquedaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBusquedaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBusquedaSalida";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBoletoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEntradaKG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEntradaQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSalidaKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSalidaQQ;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}