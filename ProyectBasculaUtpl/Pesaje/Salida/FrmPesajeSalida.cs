using CADBascula.Pesaje;
using System;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Pesaje.Salida
{
    public partial class FrmPesajeSalida : Form
    {
        public FrmPesajeSalida()
        {
            InitializeComponent();
        }
        ClassDatoEntrada DatoEntrada = new ClassDatoEntrada();
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaEntrada BEntrada = new FrmBusquedaEntrada();
            BEntrada.ShowDialog();
            if (BEntrada.Estado == true)
            {
                DatoEntrada.IdBoletoDetalle = BEntrada.Dato.IdBoletoDetalle;
                DatoEntrada.Cod = BEntrada.Dato.Cod;
                DatoEntrada.Producto = BEntrada.Dato.Producto;
                DatoEntrada.Nombre = BEntrada.Dato.Nombre;
                DatoEntrada.Ci = BEntrada.Dato.Ci;
                DatoEntrada.Vehiculo = BEntrada.Dato.Vehiculo;
                DatoEntrada.Placa = BEntrada.Dato.Placa;
                DatoEntrada.Humedad = BEntrada.Dato.Humedad;
                DatoEntrada.Impureza = BEntrada.Dato.Impureza;
                DatoEntrada.PesoEntradaKg = BEntrada.Dato.PesoEntradaKg;
                DatoEntrada.PesoEntradaQQ = BEntrada.Dato.PesoEntradaQQ;
                DatoEntrada.Fecha = BEntrada.Dato.Fecha;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DatoEntrada.IdBoletoDetalle) == 0)
            {
                MessageBox.Show("Debe buscar una entrada.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(TxtPesoQQ.Text )== 0 )
            {
                MessageBox.Show("Debe ingresar el código.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPesoQQ.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show("¿Esta seguro de  ingresar el registro?",
           "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            CADBoletoSalida Guardar = new CADBoletoSalida();

            
            Guardar.InsertBoletoSalida(Convert.ToInt32(DatoEntrada.IdBoletoDetalle), Convert.ToInt32(TxtPesoKG.Text), Convert.ToDecimal(TxtPesoQQ.Text));

            MessageBox.Show("Registro guardado correctamente.",
            "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);


            TxtVehiculo.Text = null;
            TxtPlaca.Text = null;
            TxtHumedad.Text = "0";
            TxtImpureza.Text = "0";

        }
    }
}
