using ProyectBasculaUtpl.Pesaje.Entrada;
using ProyectBasculaUtpl.Pesaje.Salida;
using System;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Pesaje
{
    public partial class FrmMenuCompra : Form
    {
        public FrmMenuCompra()
        {
            InitializeComponent();
        }

        private Form FormActivo = null;
        private void AbrirFormulario(Form FrmHijo)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.None;
            PanelContenedorHijo.Controls.Add(FrmHijo);
            PanelContenedorHijo.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
        }

        private void BtnBoletoEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPesajeEntrada());
        }

        private void BtnBoletoSalida_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPesajeSalida());
        }
    }
}
