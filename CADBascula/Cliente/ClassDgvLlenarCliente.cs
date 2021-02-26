using CADBascula.Cliente.DSClienteTableAdapters;
using System.Windows.Forms;
using static CADBascula.Cliente.DSCliente;

namespace CADBascula.Cliente
{
    public class ClassDgvLlenarCliente
    {

        public void TraerClientes(DataGridView DgvMostrar)
        {
            
            DgvMostrar.Rows.Clear();
            ClienteTableAdapter adapter = new ClienteTableAdapter();
            ClienteDataTable mitabla = adapter.GetData();
            for (int i = 0; i < mitabla.Count; i++)
            {
                ClienteRow misRegistro = (ClienteRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                null,
                misRegistro.IdCliente,
                misRegistro.Nombre,
                misRegistro.Ci,
                misRegistro.Telefono,
                misRegistro.FechaNacimiento);
            } 
        }

    }
}
