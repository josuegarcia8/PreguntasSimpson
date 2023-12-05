using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDPersonajes;

namespace AccesoDatos
{
    public class OcupacionPersonajeAD
    {
        List<OcupacionPersonaje> ocupaciones = new List<OcupacionPersonaje>()
        {
            new OcupacionPersonaje { idOcupacion = 1, descripcionOcupacion = "Planta Nuclear" },
            new OcupacionPersonaje { idOcupacion = 2, descripcionOcupacion = "Ama de Casa" },
            new OcupacionPersonaje { idOcupacion = 3, descripcionOcupacion = "Estudiante" },
            new OcupacionPersonaje { idOcupacion = 4, descripcionOcupacion = "Bebé" },
            new OcupacionPersonaje { idOcupacion = 5, descripcionOcupacion = "Jubilado" },
            new OcupacionPersonaje { idOcupacion = 6, descripcionOcupacion = "Propietario de Negocio" },
            new OcupacionPersonaje { idOcupacion = 7, descripcionOcupacion = "Director de Escuela" },
            new OcupacionPersonaje { idOcupacion = 8, descripcionOcupacion = "Empresario" },
            new OcupacionPersonaje { idOcupacion = 9, descripcionOcupacion = "Asistente Ejecutivo" },
            new OcupacionPersonaje { idOcupacion = 10, descripcionOcupacion = "Propietario de Bar" }
        };

        public List<OcupacionPersonaje> listarOcupaciones()
        {
            return ocupaciones.ToList();
        }

        public OcupacionPersonaje buscarOcupacionPorId(int id)
        {
            return ocupaciones.FirstOrDefault(o => o.idOcupacion == id);
        }

        public bool agregarOcupacion(OcupacionPersonaje ocupacion)
        {
            // .... ocupaciones.Add()
            return true;
        }

        public bool eliminarOcupacion(int id)
        {
            //..... ocupaciones.Remove()
            return true;
        }
    }
}
