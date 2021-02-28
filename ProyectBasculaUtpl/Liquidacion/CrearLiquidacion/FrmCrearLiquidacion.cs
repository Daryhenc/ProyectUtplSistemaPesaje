using System;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Liquidacion.CrearLiquidacion
{
    public partial class FrmCrearLiquidacion : Form
    {
        public FrmCrearLiquidacion()
        {
            InitializeComponent();
        }
        
        ClassDatoSalida DatoSalida = new ClassDatoSalida();
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            FrmBusquedaSalida FrmBSalida = new FrmBusquedaSalida();
            FrmBSalida.ShowDialog();
            if (FrmBSalida.Estado == true)
            {
                DatoSalida.IdBoletoDetalle = FrmBSalida.Dato.IdBoletoDetalle;
                DatoSalida.Cod = FrmBSalida.Dato.Cod;
                DatoSalida.Producto = FrmBSalida.Dato.Producto;
                DatoSalida.Nombre = FrmBSalida.Dato.Nombre;
                DatoSalida.Ci = FrmBSalida.Dato.Ci;
                DatoSalida.Vehiculo = FrmBSalida.Dato.Vehiculo;
                DatoSalida.Placa = FrmBSalida.Dato.Placa;
                DatoSalida.Humedad = FrmBSalida.Dato.Humedad;
                DatoSalida.Impureza = FrmBSalida.Dato.Impureza;
                DatoSalida.PesoEntradaKg = FrmBSalida.Dato.PesoEntradaKg;
                DatoSalida.PesoEntradaQQ = FrmBSalida.Dato.PesoEntradaQQ;
                DatoSalida.PesoSalidaKg = FrmBSalida.Dato.PesoSalidaKg;
                DatoSalida.PesoSalidaQQ = FrmBSalida.Dato.PesoSalidaQQ;
            }
        }
    }
}
