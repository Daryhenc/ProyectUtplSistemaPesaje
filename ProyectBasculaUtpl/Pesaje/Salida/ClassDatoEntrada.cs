using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectBasculaUtpl.Pesaje.Salida
{
    public class ClassDatoEntrada
    {

        public int IdBoletoDetalle { get; set; }
        public string  Cod { get; set; }
        public string Producto { get; set; }
        public string Nombre { get; set; }
        public string Ci { get; set; }
        public string Vehiculo { get; set; }
        public string Placa { get; set; }
        public string Humedad { get; set; }
        public string Impureza { get; set; }
        public string PesoEntradaKg { get; set; }
        public string PesoEntradaQQ { get; set; }
        public string Fecha { get; set; }

    }
}
