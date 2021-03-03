using CADBascula.Pesaje.DSPesajeTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADBascula.Pesaje
{
    public class CADLiquidacion
    {

        LiquidacionTableAdapter adapter = new LiquidacionTableAdapter();
        public void InsertLiquidacion(int IDBoletoDetalle, string Precio, decimal PesoQQ, int PesoKG, decimal ValorPagar, DateTime Fecha)
        {
            adapter.InsertLiquidacion(IDBoletoDetalle, Precio, PesoQQ, PesoKG, ValorPagar, Fecha);
        }

    }
}
