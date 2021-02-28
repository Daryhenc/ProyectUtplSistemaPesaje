using CADBascula.Pesaje.DSPesajeTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADBascula.Pesaje
{
    public class CADBoletoSalida
    {

        BoletoSalidaTableAdapter adapter = new BoletoSalidaTableAdapter();
        public void InsertBoletoSalida(int IDBoletoDetalle, int PesoSalidaKg, decimal PesoSalidaQQ)
        {
            adapter.InsertBoletoSalida(IDBoletoDetalle, PesoSalidaKg, PesoSalidaQQ);
        }

    }
}
