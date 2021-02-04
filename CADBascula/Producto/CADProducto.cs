using CADBascula.Producto.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADBascula.Producto
{
    public class CADProducto
    {

        ProductoTableAdapter adapter = new ProductoTableAdapter();
        public void InsertProducto(string Producto)
        {
            adapter.InsertProducto(Producto);
        }


    }
}
