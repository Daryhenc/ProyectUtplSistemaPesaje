using CADBascula.Cliente.DSClienteTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADBascula.Cliente
{
    public class CADCliente
    {

        ClienteTableAdapter adapter = new ClienteTableAdapter();
        public void InsertCliente(string CI, string Cliente, string Telefono)
        {
            adapter.InsertCliente(CI, Cliente, Telefono);
        }


    }
}
