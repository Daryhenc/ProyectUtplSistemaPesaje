using ReporteBascula.Reportes.Compras;
using System;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Liquidacion.ReporteLiquidacion
{
    public partial class FrmReporteLiquidacion : Form
    {
        public FrmReporteLiquidacion()
        {
            InitializeComponent();
        }
        int Estado;

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

        private void BtnDia_Click(object sender, EventArgs e)
        {
            Estado = 1;
            AbrirFormulario(new FrmReporteCompra(Estado, TxtCliente.Text, TxtProducto.Text, TxtBusquedaFechaInicio.Value, TxtBusquedaFechaFinal.Value));
        }

        private void BtnMes_Click(object sender, EventArgs e)
        {
            Estado = 2;
            AbrirFormulario(new FrmReporteCompra(Estado, TxtCliente.Text, TxtProducto.Text, TxtBusquedaFechaInicio.Value, TxtBusquedaFechaFinal.Value));
        }

        private void BtnVariado_Click(object sender, EventArgs e)
        {
            Estado = 3;
            AbrirFormulario(new FrmReporteCompra(Estado, TxtCliente.Text, TxtProducto.Text, TxtBusquedaFechaInicio.Value, TxtBusquedaFechaFinal.Value));
        }
    }
}
