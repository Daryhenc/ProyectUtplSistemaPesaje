using CADBascula.Cliente;
using CADBascula.Pesaje;
using CADBascula.Producto;
using ProyectBasculaUtpl.Peso;
using ProyectBasculaUtpl.Varios.Cliente;
using ProyectBasculaUtpl.Varios.Producto;
using System;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Pesaje.Entrada
{
    public partial class FrmPesajeEntrada : Form
    {
        public FrmPesajeEntrada()
        {
            InitializeComponent();
            LLenarCombos();
        }

        ClassLlenarCbCliente LlenarCliente { get; set; }
        ClassLlenarCbProducto LlenarProducto { get; set; }
        ClassCapturaPeso PesoCapturar { get; set; }

        private void LLenarCombos()
        {
            LlenarCliente = new ClassLlenarCbCliente();
            LlenarCliente.LlenarCliente(CbCliente);
            LlenarProducto = new ClassLlenarCbProducto();
            LlenarProducto.LlenarProducto(CbProducto);
        }

      

        private void TxtHumedad_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(TxtHumedad.Text);
                if (Convert.ToDecimal(TxtHumedad.Text) < 0)
                {
                    TxtHumedad.Text = "0";
                }
            }
            catch (Exception)
            {

                TxtHumedad.Text = "0";
            }
        }
        private void TxtImpureza_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(TxtImpureza.Text);
                if (Convert.ToDecimal(TxtImpureza.Text) < 0)
                {
                    TxtImpureza.Text = "0";
                }
            }
            catch (Exception)
            {

                TxtImpureza.Text = "0";
            }
        }
        private void TxtCod_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(TxtCod.Text);
                if (Convert.ToDecimal(TxtCod.Text) < 0)
                {
                    TxtCod.Text = "0";
                }
            }
            catch (Exception)
            {

                TxtCod.Text = "0";
            }
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

        #region BOTONES

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbCliente.SelectedValue) == 0)
            {
                MessageBox.Show("Debe escoger un cliente.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbCliente.Focus();
                return;
            }
            if (Convert.ToInt32(CbProducto.SelectedValue) == 0)
            {
                MessageBox.Show("Debe escoger un producto.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CbProducto.Focus();
                return;
            }
            if (TxtVehiculo.Text == "" || TxtVehiculo.Text == null)
            {
                MessageBox.Show("Debe ingresar un vehículo", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtVehiculo.Focus();
                return;
            }
            if (TxtPlaca.Text == "" || TxtPlaca.Text == null)
            {
                MessageBox.Show("Debe ingresar un vehículo", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtVehiculo.Focus();
                return;
            }
            if (TxtHumedad.Text == "" || TxtHumedad.Text == null)
            {
                MessageBox.Show("Debe ingresar la humedad.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtHumedad.Focus();
                return;
            }
            if (TxtImpureza.Text == "" || TxtImpureza.Text == null)
            {
                MessageBox.Show("Debe ingresar la impureza.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtImpureza.Focus();
                return;
            }
            if (TxtCod.Text == "" || TxtCod.Text == null)
            {
                MessageBox.Show("Debe ingresar el código.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCod.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show("¿Esta seguro de  ingresar el registro?",
           "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            CADGuardarEntrada Guardar = new CADGuardarEntrada();
            Guardar.GuardarEntrda(Convert.ToInt32(CbCliente.SelectedValue), Convert.ToInt32(CbProducto.SelectedValue), Convert.ToInt32(TxtCod.Text),
            TxtVehiculo.Text.ToUpper(), TxtPlaca.Text.ToUpper(), Convert.ToDecimal(TxtHumedad.Text), Convert.ToDecimal(TxtImpureza.Text),
            Convert.ToInt32(TxtPesoKG.Text), Convert.ToDecimal(TxtPesoQQ.Text));

            MessageBox.Show("Registro guardado correctamente.",
            "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CbCliente.SelectedIndex = 0;
            CbProducto.SelectedIndex = 0;
            TxtVehiculo.Text = null;
            TxtPlaca.Text = null;
            TxtHumedad.Text = "0";
            TxtImpureza.Text = "0";
            TxtCod.Text = "0";
        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente FrmCrearCli = new FrmCliente();
            FrmCrearCli.ShowDialog();

            LLenarCombos();
        }
        private void BtnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto FrmCrearPr = new FrmProducto();
            FrmCrearPr.ShowDialog();

            LLenarCombos();
        }
        private void BtnPesarEntrada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe tener una bascula conectada al puerto COM1.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // PesoCapturar = new ClassCapturaPeso();
            // int PesoKG = Convert.ToInt32(PesoCapturar.Bascula(serialPort, "COM1"));
        }

        #endregion




    }
}
