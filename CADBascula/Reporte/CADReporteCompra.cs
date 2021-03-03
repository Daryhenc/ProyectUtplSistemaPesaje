using CADBascula.Reporte.DSReporteTableAdapters;
using System;
using System.Collections.Generic;
using static CADBascula.Reporte.DSReporte;

namespace CADBascula.Reporte
{
    public class CADReporteCompra
    {

        public List<CADDatoReporteCompra> Datos = new List<CADDatoReporteCompra>();
        public ReporteCompraTableAdapter adapter = new ReporteCompraTableAdapter();


        public void LLenarReporteCompraLista(int Estado, string Nombre, string Producto, string FECHA1, string FECHA2)
        {
            
            if (Estado == 1)
            {
                GetDataByDia(Nombre, Producto);
                return;
            }

            if (Estado == 3)
            {
                GetDataByMes(Nombre, Producto);
                return;
            }
            if (Estado == 4)
            {
                GetDataPorFecha(Nombre, Producto, FECHA1, FECHA2);
                return;
            }
        }
        private void GetDataByDia(string Nombre, string Producto)
        {
            Datos.Clear();
            ReporteCompraDataTable mitabla = adapter.GetDataDia(Nombre, Producto);
            for (int i = 0; i < mitabla.Count; i++)
            {
                ReporteCompraRow misRegistros = (ReporteCompraRow)mitabla.Rows[i];
                CADDatoReporteCompra insertar = new CADDatoReporteCompra
                {
                    Nombre = misRegistros.Nombre,
                    Ci = misRegistros.Ci,
                    Producto = misRegistros.Ci,
                    Humedad = misRegistros.Humedad,
                    Impureza = misRegistros.Impureza,
                    PesoQQ = misRegistros.PesoQQ,
                    PesoKG = 0,
                    Precio = Convert.ToDecimal(misRegistros.Precio),
                    ValorPagar = misRegistros.ValorPagar,
                    Fecha = misRegistros.Fecha,
                };
                Datos.Add(insertar);

            }
        }

        private void GetDataByMes(string Nombre, string Producto)
        {
            Datos.Clear();
            ReporteCompraDataTable mitabla = adapter.GetDataByMes(Nombre, Producto);
            for (int i = 0; i < mitabla.Count; i++)
            {
                ReporteCompraRow misRegistros = (ReporteCompraRow)mitabla.Rows[i];
                CADDatoReporteCompra insertar = new CADDatoReporteCompra
                {
                    Nombre = misRegistros.Nombre,
                    Ci = misRegistros.Ci,
                    Producto = misRegistros.Ci,
                    Humedad = misRegistros.Humedad,
                    Impureza = misRegistros.Impureza,
                    PesoQQ = misRegistros.PesoQQ,
                    PesoKG = 0,
                    Precio = Convert.ToDecimal(misRegistros.Precio),
                    ValorPagar = misRegistros.ValorPagar,
                    Fecha = misRegistros.Fecha,
                };
                Datos.Add(insertar);
            }
        }
        private void GetDataPorFecha(string Nombre, string Producto, string Fecha1, string Fecha2)
        {
            Datos.Clear();
            ReporteCompraDataTable mitabla = adapter.GetDataByMes(Nombre, Producto);
            for (int i = 0; i < mitabla.Count; i++)
            {
                ReporteCompraRow misRegistros = (ReporteCompraRow)mitabla.Rows[i];
                CADDatoReporteCompra insertar = new CADDatoReporteCompra
                {
                    Nombre = misRegistros.Nombre,
                    Ci = misRegistros.Ci,
                    Producto = misRegistros.Ci,
                    Humedad = misRegistros.Humedad,
                    Impureza = misRegistros.Impureza,
                    PesoQQ = misRegistros.PesoQQ,
                    PesoKG = 0,
                    Precio = Convert.ToDecimal(misRegistros.Precio),
                    ValorPagar = misRegistros.ValorPagar,
                    Fecha = misRegistros.Fecha,
                };
                Datos.Add(insertar);
            }
        }

    }
}
