using ReporteBascula.Reportes.Compras.DatoList;
using System;
using System.Windows.Forms;

namespace ReporteBascula.Reportes.Compras
{
    public partial class FrmReporteCompra : Form
    {
        public FrmReporteCompra(int Estado, string Nombre, string Producto, DateTime Fecha1, DateTime Fecha2)
        {
            InitializeComponent();
            ClassReporteCompra TraerDatos = new ClassReporteCompra();
            TraerDatos.LlamarReporteListaCuenta(Estado, Nombre, Producto, Fecha1, Fecha2);
            ClassObDatoListCompraBindingSource.DataSource = TraerDatos.DatosLista;
            this.reportViewerCompras.RefreshReport();
        }

    }
}
