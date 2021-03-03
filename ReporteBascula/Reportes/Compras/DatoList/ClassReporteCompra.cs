using CADBascula.Reporte;
using System;
using System.Collections.Generic;

namespace ReporteBascula.Reportes.Compras.DatoList
{
    public class ClassReporteCompra
    {

        CADReporteCompra Reporte { get; set; }

        public List<ClassObDatoListCompra> DatosLista { get; private set; }

        public void LlamarReporteListaCuenta(int Estado, string Nombre, string Producto, DateTime Fecha1, DateTime Fecha2 )
        {
            Reporte = new CADReporteCompra();
            DatosLista = new List<ClassObDatoListCompra>();

            Reporte.LLenarReporteCompraLista(Estado, Nombre, Producto, Fecha1.ToString(), Fecha2.ToString());

            for (int i = 0; i < Reporte.Datos.Count; i++)
            {
                ClassObDatoListCompra insertar = new ClassObDatoListCompra
                {
                     Nombre = Reporte.Datos[i].Nombre,
                     Ci = Reporte.Datos[i].Ci,
                     Producto = Reporte.Datos[i].Ci,
                     Humedad = Reporte.Datos[i].Humedad,
                     Impureza = Reporte.Datos[i].Impureza,
                     PesoQQ = Reporte.Datos[i].PesoQQ,
                     PesoKG = Reporte.Datos[i].PesoKG,
                     Precio = Reporte.Datos[i].Precio, 
                     ValorPagar = Reporte.Datos[i].ValorPagar,
                     Fecha = Reporte.Datos[i].Fecha,
                    
                  };

                DatosLista.Add(insertar);

            }
        }


    }
}
