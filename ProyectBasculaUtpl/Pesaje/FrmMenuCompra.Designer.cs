namespace ProyectBasculaUtpl.Pesaje
{
    partial class FrmMenuCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCompra));
            this.PanelContenedorHijo = new System.Windows.Forms.Panel();
            this.PanelMenuCerrar = new System.Windows.Forms.Panel();
            this.BtnBoletoSalida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBoletoEntrada = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMenuCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedorHijo
            // 
            this.PanelContenedorHijo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelContenedorHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorHijo.Location = new System.Drawing.Point(0, 61);
            this.PanelContenedorHijo.Name = "PanelContenedorHijo";
            this.PanelContenedorHijo.Size = new System.Drawing.Size(1267, 785);
            this.PanelContenedorHijo.TabIndex = 243;
            // 
            // PanelMenuCerrar
            // 
            this.PanelMenuCerrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenuCerrar.Controls.Add(this.panel2);
            this.PanelMenuCerrar.Controls.Add(this.BtnBoletoEntrada);
            this.PanelMenuCerrar.Controls.Add(this.panel1);
            this.PanelMenuCerrar.Controls.Add(this.BtnBoletoSalida);
            this.PanelMenuCerrar.Controls.Add(this.label2);
            this.PanelMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuCerrar.Name = "PanelMenuCerrar";
            this.PanelMenuCerrar.Size = new System.Drawing.Size(1267, 61);
            this.PanelMenuCerrar.TabIndex = 242;
            // 
            // BtnBoletoSalida
            // 
            this.BtnBoletoSalida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBoletoSalida.BackgroundImage")));
            this.BtnBoletoSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBoletoSalida.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBoletoSalida.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtnBoletoSalida.FlatAppearance.BorderSize = 0;
            this.BtnBoletoSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoletoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletoSalida.ForeColor = System.Drawing.Color.Navy;
            this.BtnBoletoSalida.Location = new System.Drawing.Point(1187, 0);
            this.BtnBoletoSalida.Name = "BtnBoletoSalida";
            this.BtnBoletoSalida.Size = new System.Drawing.Size(80, 61);
            this.BtnBoletoSalida.TabIndex = 4;
            this.BtnBoletoSalida.UseVisualStyleBackColor = true;
            this.BtnBoletoSalida.Click += new System.EventHandler(this.BtnBoletoSalida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "PESAJE ENTRADA Y SALIDA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1186, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 61);
            this.panel1.TabIndex = 6;
            // 
            // BtnBoletoEntrada
            // 
            this.BtnBoletoEntrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBoletoEntrada.BackgroundImage")));
            this.BtnBoletoEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBoletoEntrada.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBoletoEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtnBoletoEntrada.FlatAppearance.BorderSize = 0;
            this.BtnBoletoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoletoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletoEntrada.ForeColor = System.Drawing.Color.Navy;
            this.BtnBoletoEntrada.Location = new System.Drawing.Point(1106, 0);
            this.BtnBoletoEntrada.Name = "BtnBoletoEntrada";
            this.BtnBoletoEntrada.Size = new System.Drawing.Size(80, 61);
            this.BtnBoletoEntrada.TabIndex = 7;
            this.BtnBoletoEntrada.UseVisualStyleBackColor = true;
            this.BtnBoletoEntrada.Click += new System.EventHandler(this.BtnBoletoEntrada_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1105, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 61);
            this.panel2.TabIndex = 8;
            // 
            // FrmMenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 846);
            this.Controls.Add(this.PanelContenedorHijo);
            this.Controls.Add(this.PanelMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuCompra";
            this.PanelMenuCerrar.ResumeLayout(false);
            this.PanelMenuCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedorHijo;
        private System.Windows.Forms.Panel PanelMenuCerrar;
        private System.Windows.Forms.Button BtnBoletoSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBoletoEntrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}