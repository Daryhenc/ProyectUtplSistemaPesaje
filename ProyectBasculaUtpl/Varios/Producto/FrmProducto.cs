using CADBascula.Producto;
using System;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Varios.Producto
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            LlenarProducto = new ClassDgvLlenarProduto();
            LlenarProducto.TraerProducto(DgvDatos);
        }

        ClassDgvLlenarProduto LlenarProducto { get; set; }
        private void BnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtProducto.Text == "" || TxtProducto.Text == null)
            {
                MessageBox.Show("Debe ingresar los nombres y apellidos", "ALTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtProducto.Focus();
                return;
            }
          


            DialogResult rta = MessageBox.Show("¿Esta seguro de  ingresar el registro?",
           "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            CADProducto Guardar = new CADProducto();
            Guardar.InsertProducto(TxtProducto.Text.ToUpper());
            LlenarProducto = new ClassDgvLlenarProduto();
            LlenarProducto.TraerProducto(DgvDatos);

            MessageBox.Show("Registro guardado correctamente.",
            "CONFIRMAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtProducto.Text = null;

        }
    }
}
