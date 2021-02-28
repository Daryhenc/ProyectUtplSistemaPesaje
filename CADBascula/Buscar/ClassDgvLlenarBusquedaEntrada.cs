using CADBascula.Buscar.DSBusquedasTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CADBascula.Buscar.DSBusquedas;

namespace CADBascula.Buscar
{
    public class ClassDgvLlenarBusquedaEntrada
    {

        public void TraerBoletoEntrada(DataGridView DgvMostrar)
        {

            DgvMostrar.Rows.Clear();
            BusquedaEntradaTableAdapter adapter = new BusquedaEntradaTableAdapter();
            BusquedaEntradaDataTable mitabla = adapter.GetData();
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaEntradaRow misRegistro = (BusquedaEntradaRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                misRegistro.IdBoletoDetalle,
                misRegistro.Cod,
                misRegistro.Producto,
                misRegistro.Nombre,
                misRegistro.Ci,
                misRegistro.Vehiculo,
                misRegistro.Placa,
                misRegistro.Humedad,
                misRegistro.Impureza,
                misRegistro.PesoEntradaKg,
                misRegistro.PesoEntradaQQ,
                misRegistro.Fecha);
            }
        }

    }
}
