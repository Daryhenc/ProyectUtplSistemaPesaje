using CADBascula.Pesaje.DSPesajeTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADBascula.Pesaje
{
    public class CADBoletoEntrada
    {

        BoletoEntradaTableAdapter adapter = new BoletoEntradaTableAdapter();
        public void InsertBoletoEntrada(int IDBoletoDetalle, int PesoEntradaKg, decimal PesoEntradaQQ)
        {
            adapter.InsertBoletoEntrada(IDBoletoDetalle, PesoEntradaKg, PesoEntradaQQ);
        }


    }
}
