using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDPersonajes
{
    public class Personaje
    {
        public int idPersonaje { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string descripcion { get; set; }
        public OcupacionPersonaje ocupacion { get; set; }
        public TipoPersonaje TipoPersonaje { get; set; }
    }
}
