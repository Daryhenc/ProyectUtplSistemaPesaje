using CADBascula.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Varios.Cliente
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            LLenarCliente = new ClassDgvLlenarCliente();
            LLenarCliente.TraerClientes(DgvDatos);
        }

        ClassDgvLlenarCliente LLenarCliente { get; set; }

        private void BnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombres.Text == "" || TxtNombres.Text == null)
            {
                MessageBox.Show("Debe ingresar los nombres y apellidos", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombres.Focus();
                return;
            }
            if (TxtCi.Text == "" || TxtCi.Text == null)
            {
                MessageBox.Show("Debes ingresar la cédula.", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCi.Focus();
                return;
            }
            if (TxtTelefono.Text == "" || TxtTelefono.Text == null)
            {
                MessageBox.Show("Debes ingresar un número de teléfono", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTelefono.Focus();
                return;
            }
            

            DialogResult rta = MessageBox.Show("¿Esta seguro de  ingresar el registro?",
           "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            CADCliente Guardar = new CADCliente();
            Guardar.InsertCliente(TxtNombres.Text.ToUpper(), TxtCi.Text.ToUpper(), TxtTelefono.Text, TxtFechaNa.Value);
            LLenarCliente = new ClassDgvLlenarCliente();
            LLenarCliente.TraerClientes(DgvDatos);

            MessageBox.Show("Registro guardado correctamente.",
            "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtNombres.Text = null;
            TxtCi.Text = null;
            TxtTelefono.Text = null;
        }

        private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDatos.CurrentRow == null)
            {
                return;
            }

            int Fila = e.RowIndex;
            int Column = e.ColumnIndex;
            if (Fila < 0)
            {
                return;
            }
            // MOSTRAR COMPRA O VENTA
            if (Column == 0)
            {
                DialogResult rta = MessageBox.Show("¿Esta seguro de borrar el registro?",
                "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rta == DialogResult.No) return;

                CADCliente BorrarCliente = new CADCliente();
                BorrarCliente.DeleteCliente(Convert.ToInt32(DgvDatos.Rows[Fila].Cells[1].Value));

                LLenarCliente = new ClassDgvLlenarCliente();
                LLenarCliente.TraerClientes(DgvDatos);

                return;
            }
        }
    }
}
