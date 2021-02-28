using CADBascula.Pesaje.DSPesajeTableAdapters;
using System;

namespace CADBascula.Pesaje
{
    public class CADBoletoDetalle
    {

        BoletoDetalleTableAdapter adapter = new BoletoDetalleTableAdapter();
        public int InsertBoletoDetalle(int IDCliente, int IDProducto, int Cod, string Vehiculo, string Placa, decimal Humedad, decimal Impureza)
        {
            return Convert.ToInt32(adapter.InsertBoletoDetalle(IDCliente, IDProducto, Cod, Vehiculo, Placa, Humedad, Impureza));
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
