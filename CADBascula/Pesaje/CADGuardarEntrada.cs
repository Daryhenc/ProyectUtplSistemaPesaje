using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADBascula.Pesaje
{
    public class CADGuardarEntrada
    {

        CADBoletoDetalle BDetalle { get; set; }
        CADBoletoEntrada BEntrada { get; set; }

        public void GuardarEntrda(int IDCliente, int IDProducto, int Cod, string Vehiculo, string Placa, decimal Humedad, decimal Impureza, int PesoEntradaKg, decimal PesoEntradaQQ)
        {
            BDetalle = new CADBoletoDetalle();
            int ID = BDetalle.InsertBoletoDetalle(IDCliente, IDProducto, Cod, Vehiculo, Placa, Humedad, Impureza);
            BEntrada = new CADBoletoEntrada();
            BEntrada.InsertBoletoEntrada(ID, PesoEntradaKg, PesoEntradaQQ);
        }

    }
}
