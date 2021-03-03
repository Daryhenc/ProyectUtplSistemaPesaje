using System;
using System.IO.Ports;

namespace ProyectBasculaUtpl.Peso
{
    public class ClassCapturaPeso
    {

        string cadena;
        string datoconvertir;
        string resultado;
        string[] partes;
        public string Bascula(SerialPort bascula, string puertoName)
        {
            try
            {
                bascula.Close();
                bascula.Dispose();
                bascula.PortName = puertoName;
                bascula.Open();

                if (bascula.IsOpen == true)
                {
                    datoconvertir = null;
                    cadena = null;
                    partes = null;
                    resultado = null;

                    cadena = bascula.ReadTo("\r");
                    datoconvertir = cadena.Substring(0, 11);
                    partes = datoconvertir.Split(' ');
                    if (partes.Length >= 1)
                    {
                        resultado = partes[1];
                        if (resultado.Length == 7)
                        {
                            bascula.Close();
                            return Convert.ToInt32(resultado.Substring(0, 6)).ToString();
                        }
                        bascula.Close();
                        return Convert.ToInt32(resultado).ToString();
                    }
                }
            }
            catch (Exception)
            {
                return "0";
            }

            return null;
        }

    }
}
