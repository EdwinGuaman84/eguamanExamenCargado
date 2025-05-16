using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eguamanExamen.Views
{
    public class Estudiante
    {
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public double MontoInicial { get; set; }
        public double PagoMensual { get; set; }

        public double PagoTotal => MontoInicial + (PagoMensual * 4);
       

    }
}
