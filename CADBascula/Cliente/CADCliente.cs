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
        public void InsertCliente(string Nombre, string CI, string Telefono, DateTime FechaNacimiento)
        {
            adapter.InsertCliente( Nombre, CI, Telefono, FechaNacimiento);
        }

        public void DeleteCliente(int IdCliente)
        {
            adapter.DeleteCliente(IdCliente);
        }
    }
}
