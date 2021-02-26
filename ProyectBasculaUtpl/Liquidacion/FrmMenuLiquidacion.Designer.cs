
namespace ProyectBasculaUtpl.Liquidacion
{
    partial class FrmMenuLiquidacion
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
            this.PanelContenedorHijo = new System.Windows.Forms.Panel();
            this.PanelMenuCerrar = new System.Windows.Forms.Panel();
            this.BtnBoletoSalida = new System.Windows.Forms.Button();
            this.BtnLiquidar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.PanelContenedorHijo.TabIndex = 245;
            // 
            // PanelMenuCerrar
            // 
            this.PanelMenuCerrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenuCerrar.Controls.Add(this.BtnBoletoSalida);
            this.PanelMenuCerrar.Controls.Add(this.BtnLiquidar);
            this.PanelMenuCerrar.Controls.Add(this.label2);
            this.PanelMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuCerrar.Name = "PanelMenuCerrar";
            this.PanelMenuCerrar.Size = new System.Drawing.Size(1267, 61);
            this.PanelMenuCerrar.TabIndex = 244;
            // 
            // BtnBoletoSalida
            // 
            this.BtnBoletoSalida.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnBoletoSalida.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtnBoletoSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoletoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletoSalida.ForeColor = System.Drawing.Color.Navy;
            this.BtnBoletoSalida.Location = new System.Drawing.Point(80, 0);
            this.BtnBoletoSalida.Name = "BtnBoletoSalida";
            this.BtnBoletoSalida.Size = new System.Drawing.Size(80, 61);
            this.BtnBoletoSalida.TabIndex = 4;
            this.BtnBoletoSalida.Text = "REPORTE";
            this.BtnBoletoSalida.UseVisualStyleBackColor = true;
            // 
            // BtnLiquidar
            // 
            this.BtnLiquidar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLiquidar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLiquidar.ForeColor = System.Drawing.Color.Navy;
            this.BtnLiquidar.Location = new System.Drawing.Point(0, 0);
            this.BtnLiquidar.Name = "BtnLiquidar";
            this.BtnLiquidar.Size = new System.Drawing.Size(80, 61);
            this.BtnLiquidar.TabIndex = 3;
            this.BtnLiquidar.Text = "LIQUIDAR";
            this.BtnLiquidar.UseVisualStyleBackColor = true;
            this.BtnLiquidar.Click += new System.EventHandler(this.BtnLiquidar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(776, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "PESAJE ENTRADA Y SALIDA";
            // 
            // FrmMenuLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 846);
            this.Controls.Add(this.PanelContenedorHijo);
            this.Controls.Add(this.PanelMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuLiquidacion";
            this.PanelMenuCerrar.ResumeLayout(false);
            this.PanelMenuCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedorHijo;
        private System.Windows.Forms.Panel PanelMenuCerrar;
        private System.Windows.Forms.Button BtnBoletoSalida;
        private System.Windows.Forms.Button BtnLiquidar;
        private System.Windows.Forms.Label label2;
    }
}