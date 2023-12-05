using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDPersonajes;

namespace AccesoDatos
{
    public class PersonajeAD
    {
        List<Personaje> listaPersonajes = new List<Personaje>
        {
            new Personaje {  }
        };

        public bool insertarPersonaje(Personaje nuevo)
        {
            return true;
        }

        public bool eliminarPersonaje(int id)
        {
            return true;
        }

        public Personaje modificarPersonaje(Personaje modificado)
        {
            return modificado;
        }

        public Personaje buscarPersonajePorId(int id)
        {
            return new Personaje();
        }

        public List<Personaje> buscarPersonajesPorRangoEdad(int minEdad, int maxEdad)
        {
            return new List<Personaje>();
        }

        public List<Personaje> buscarPersonajesPorOcupacion(OcupacionPersonaje ocupacion)
        {
            return new List<Personaje>();
        }

        public List<Personaje> buscarPersonajesPorTipo(TipoPersonaje tipo)
        {
            return new List<Personaje>();
        }
    }
}
