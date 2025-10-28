using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol9_2.Modelos
{
    class Equipo
    {
        public int ID { get; set; }
        public string NombreEquipo { get; set; }
        public string Delegado { get; set; }
        public string? MovilDelegado { get; set; }
        public string? FormaDePago { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }
    }
}
