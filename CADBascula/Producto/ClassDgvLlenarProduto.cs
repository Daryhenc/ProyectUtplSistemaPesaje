using CADBascula.Producto.DataSet1TableAdapters;
using System.Linq;
using System.Windows.Forms;
using static CADBascula.Producto.DataSet1;

namespace CADBascula.Producto
{
    public class ClassDgvLlenarProduto
    {

        public void TraerProducto(DataGridView DgvMostrar)
        {
            DgvMostrar.Rows.Clear();
            ProductoTableAdapter adapter = new ProductoTableAdapter();
            ProductoDataTable mitabla = adapter.GetData();
            for (int i = 0; i < mitabla.Count; i++)
            {
                ProductoRow misRegistro = (ProductoRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                null,
                misRegistro.IdProducto,
                misRegistro.Producto
                );
            }
        }

    }
}
