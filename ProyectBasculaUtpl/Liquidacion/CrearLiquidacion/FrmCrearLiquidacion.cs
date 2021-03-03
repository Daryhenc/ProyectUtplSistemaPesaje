using CADBascula.Pesaje;
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

                TxtNombres.Text = DatoSalida.Nombre;
                TxtCi.Text = DatoSalida.Ci;
                TxtCod.Text = DatoSalida.Cod;
                TxtVehiculo.Text = DatoSalida.Vehiculo;
                TxtPlaca.Text = DatoSalida.Placa;
                TxtEntradaQQ.Text = DatoSalida.PesoEntradaQQ;
                TxtSalidaQQ.Text = DatoSalida.PesoSalidaQQ;
                TxtProducto.Text = DatoSalida.Producto;
                TxtImpureza.Text = DatoSalida.Impureza;
                TxtHumedad.Text = DatoSalida.Humedad;

                TxtPesoPagar.Text = Convert.ToString(Convert.ToDecimal(TxtEntradaQQ.Text) - Convert.ToDecimal(TxtSalidaQQ.Text));
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (DatoSalida.IdBoletoDetalle == 0)
            {
                MessageBox.Show("Debe buscar un cliente.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(TxtPrecio.Text) == 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            DialogResult rta = MessageBox.Show("¿Esta seguro de  ingresar el registro?",
           "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            CADLiquidacion Guardar = new CADLiquidacion();

            int PesoPagar = Convert.ToInt32(Math.Floor(Convert.ToDecimal(TxtPesoPagar.Text) * 100)); 

            Guardar.InsertLiquidacion(DatoSalida.IdBoletoDetalle, TxtPrecio.Text, 
            Convert.ToDecimal(TxtPesoPagar.Text), PesoPagar, Convert.ToDecimal(TxtVPagar.Text), DateTime.Now);

            MessageBox.Show("Registro guardado correctamente.",
            "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (DatoSalida.IdBoletoDetalle == 1)
            {
                try
                {
                    Convert.ToDecimal(TxtPrecio.Text);
                    if (Convert.ToDecimal(TxtPrecio.Text) < 0)
                    {
                        TxtPrecio.Text = "0";                        
                    }

                    TxtVPagar.Text = Convert.ToString(Convert.ToDecimal( TxtPrecio.Text ) * Convert.ToDecimal(TxtPesoPagar.Text));
                }
                catch (Exception)
                {
                    TxtPrecio.Text = "0";
                    TxtVPagar.Text = Convert.ToString(Convert.ToDecimal(TxtPrecio.Text) * Convert.ToDecimal(TxtPesoPagar.Text));
                }
            }
        }

        private void Limpiar()
        {
            DatoSalida.IdBoletoDetalle = 0;
            DatoSalida.Cod = null;
            DatoSalida.Producto = null;
            DatoSalida.Nombre = null;
            DatoSalida.Ci = null;
            DatoSalida.Vehiculo = null;
            DatoSalida.Placa = null;
            DatoSalida.Humedad = null;
            DatoSalida.Impureza = null;
            DatoSalida.PesoEntradaKg = null;
            DatoSalida.PesoEntradaQQ = null;
            DatoSalida.PesoSalidaKg = null;
            DatoSalida.PesoSalidaQQ = null;

            TxtNombres.Text = null;
            TxtCi.Text = null;
            TxtCod.Text = null;
            TxtVehiculo.Text = null;
            TxtPlaca.Text = null;
            TxtEntradaQQ.Text = null;
            TxtSalidaQQ.Text = null;
            TxtProducto.Text = null;
            TxtImpureza.Text = null;
            TxtHumedad.Text = null;
            TxtPrecio.Text = "0";
            TxtPesoPagar.Text = "0";
            TxtVPagar.Text = "0";


        }
    }
}
