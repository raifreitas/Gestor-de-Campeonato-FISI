using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol9_2.Modelos
{
    class Jugador
    {
        public int ID { get; set; }
        public string NombreDeEquipo { get; set; }
        public string DNI { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string NumeroMovil{ get; set; }
        public int NumeroCamiseta { get; set; } 
        public string Posicion { get; set; }
        public string Estado { get; set; }

        // Aquí vendrá la "llave foránea"
        // public int EquipoID { get; set; }
        // public Equipo Equipo { get; set; }
    }
}
