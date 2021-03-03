using CADBascula.Pesaje;
using ProyectBasculaUtpl.Peso;
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
        ClassCapturaPeso PesoCapturar { get; set; }


        private void Limpiar()
        {
            DatoEntrada.IdBoletoDetalle = 0;
            DatoEntrada.Cod = null;
            DatoEntrada.Producto = null;
            DatoEntrada.Nombre = null;
            DatoEntrada.Ci = null;
            DatoEntrada.Vehiculo = null;
            DatoEntrada.Placa = null;
            DatoEntrada.Humedad = null;
            DatoEntrada.Impureza = null;
            DatoEntrada.PesoEntradaKg = null;
            DatoEntrada.PesoEntradaQQ = null;
            DatoEntrada.Fecha = null;
            TxtCliente.Text = null;
            TxtProducto.Text = null;
            TxtVehiculo.Text = null;
            TxtPlaca.Text = null;
            TxtHumedad.Text = null;
            TxtImpureza.Text = null;
        }

        private void TxtPesoKG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(TxtPesoKG.Text);
                if (Convert.ToInt32(TxtPesoKG.Text) < 0)
                {
                    TxtPesoKG.Text = "0";
                }
                TxtPesoQQ.Text = (Convert.ToDouble(TxtPesoKG.Text) * 0.022).ToString();
            }
            catch (Exception)
            {
                TxtPesoKG.Text = "0";
                TxtPesoQQ.Text = (Convert.ToDouble(TxtPesoKG.Text) * 0.022).ToString();
            }
        }

        #region Botones

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
                TxtCliente.Text = DatoEntrada.Nombre.ToUpper();
                TxtProducto.Text = DatoEntrada.Producto.ToUpper();
                TxtVehiculo.Text = DatoEntrada.Vehiculo.ToUpper();
                TxtPlaca.Text = DatoEntrada.Placa.ToUpper();
                TxtHumedad.Text = DatoEntrada.Humedad.ToUpper();
                TxtImpureza.Text = DatoEntrada.Impureza.ToUpper();
            }
            else
            {
                Limpiar();
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DatoEntrada.IdBoletoDetalle) == 0)
            {
                MessageBox.Show("Debe buscar una entrada.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(TxtPesoQQ.Text) == 0)
            {
                MessageBox.Show("Debe obtener el peso de salida.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnPesarSalida.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show("¿Esta seguro de  ingresar el registro?",
           "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            CADBoletoSalida Guardar = new CADBoletoSalida();


            Guardar.InsertBoletoSalida(Convert.ToInt32(DatoEntrada.IdBoletoDetalle), Convert.ToInt32(TxtPesoKG.Text), Convert.ToDecimal(TxtPesoQQ.Text));

            MessageBox.Show("Registro guardado correctamente.",
            "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Limpiar();

        }
        private void BtnPesarSalida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe tener una bascula conectada al puerto COM1.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // PesoCapturar = new ClassCapturaPeso();
            // int PesoKG = Convert.ToInt32(PesoCapturar.Bascula(serialPort, "COM1"));
        }

        #endregion


    }
}
