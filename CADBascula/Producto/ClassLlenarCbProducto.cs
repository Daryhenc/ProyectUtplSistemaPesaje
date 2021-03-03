using CADBascula.Producto.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADBascula.Producto
{
    public class ClassLlenarCbProducto
    {

        public void LlenarProducto(ComboBox CbProducto)
        {

            ProductoTableAdapter adapter = new ProductoTableAdapter();
            CbProducto.DataSource = adapter.GetDataByCb();
            CbProducto.DisplayMember = "Producto";
            CbProducto.ValueMember = "IdProducto";
            CbProducto.SelectedIndex = 0;
        }

    }
}
