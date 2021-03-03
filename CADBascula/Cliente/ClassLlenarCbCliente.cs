using CADBascula.Cliente.DSClienteTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADBascula.Cliente
{
    public class ClassLlenarCbCliente
    {


        public void LlenarCliente(ComboBox CbCliente)
        {

            ClienteTableAdapter adapter = new ClienteTableAdapter();
            CbCliente.DataSource = adapter.GetDataByCb();
            CbCliente.DisplayMember = "Nombre";
            CbCliente.ValueMember = "IdCliente";
            CbCliente.SelectedIndex = 0;
        }

    }
}
