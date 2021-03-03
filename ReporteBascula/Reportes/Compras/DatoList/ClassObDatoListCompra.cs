using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteBascula.Reportes.Compras.DatoList
{
    public class ClassObDatoListCompra
    {

        public string Nombre { get; set; }
        public string Ci { get; set; }
        public string Producto { get; set; }
        public decimal Humedad { get; set; }
        public decimal Impureza { get; set; }        
        public decimal PesoQQ  { get; set; }
        public int PesoKG { get; set; }
        public decimal Precio { get; set; }
        public decimal ValorPagar { get; set; }
        public DateTime Fecha { get; set; }

    }
}
