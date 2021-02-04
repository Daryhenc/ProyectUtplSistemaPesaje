using CADBascula.Pesaje.DSPesajeTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADBascula.Pesaje
{
    public class CADBoletoDetalle
    {

        BoletoDetalleTableAdapter adapter = new BoletoDetalleTableAdapter();
        public void InsertBoletoDetalle(int IDCliente, int IDProducto, int Cod, string Vehiculo, string Placa, decimal Humedad, decimal Impureza)
        {
            adapter.InsertBoletoDetalle(IDCliente, IDProducto, Cod, Vehiculo, Placa, Humedad, Impureza);
        }

        /*
        public void UpdateJerar(string Nombre, string Codigo, int IDConta_Jera)
        {
            adapter.UpdateJerar(Nombre, Codigo, IDConta_Jera);
        }

        public void DeleteJerar(int IDConta_Jera)
        {
            adapter.DeleteJerar(IDConta_Jera);
        }
         */
    }
}
