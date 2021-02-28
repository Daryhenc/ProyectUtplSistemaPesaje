using CADBascula.Buscar.DSBusquedasTableAdapters;
using System.Windows.Forms;
using static CADBascula.Buscar.DSBusquedas;

namespace CADBascula.Buscar
{
    public class ClassDgvLlenarBusquedaSalida
    {

        public void TraerBoletoSalida(DataGridView DgvMostrar)
        {

            DgvMostrar.Rows.Clear();
            BusquedaSalidaTableAdapter adapter = new BusquedaSalidaTableAdapter();
            BusquedaSalidaDataTable mitabla = adapter.GetData();
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaSalidaRow misRegistro = (BusquedaSalidaRow)mitabla.Rows[i];
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
                misRegistro.PesoSalidaKg,
                misRegistro.PesoSalidaQQ);
            }
        }

    }
}
