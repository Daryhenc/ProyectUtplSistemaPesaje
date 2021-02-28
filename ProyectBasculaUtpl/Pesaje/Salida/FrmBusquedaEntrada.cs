using System;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Pesaje.Salida
{
    public partial class FrmBusquedaEntrada : Form
    {
        public FrmBusquedaEntrada()
        {
            InitializeComponent();
        }

        public ClassDatoEntrada Dato = new ClassDatoEntrada();
        public bool Estado;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Estado = false;
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDato.CurrentRow == null)
            {
                return;
            }
            else
            {
               
                int fila = Convert.ToInt32(dgvDato.CurrentRow.Index);
                Dato.IdBoletoDetalle = dgvDato.Rows[fila].Cells[0].Value.ToString();
                Dato.Cod = dgvDato.Rows[fila].Cells[1].Value.ToString();
                Dato.Producto = dgvDato.Rows[fila].Cells[2].Value.ToString();
                Dato.Nombre = dgvDato.Rows[fila].Cells[3].Value.ToString();
                Dato.Ci = dgvDato.Rows[fila].Cells[4].Value.ToString();
                Dato.Vehiculo = dgvDato.Rows[fila].Cells[5].Value.ToString();
                Dato.Placa = dgvDato.Rows[fila].Cells[6].Value.ToString();
                Dato.Humedad = dgvDato.Rows[fila].Cells[7].Value.ToString();
                Dato.Impureza = dgvDato.Rows[fila].Cells[8].Value.ToString();
                Dato.PesoEntradaKg = dgvDato.Rows[fila].Cells[9].Value.ToString();
                Dato.PesoEntradaQQ = dgvDato.Rows[fila].Cells[10].Value.ToString();
                Dato.Fecha = dgvDato.Rows[fila].Cells[11].Value.ToString();
                Estado = true;
                this.Close();
            }

          
        }
    }
}
