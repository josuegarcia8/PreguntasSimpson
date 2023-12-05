using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDPersonajes;

namespace AccesoDatos
{
    public class TipoPersonajeAD
    {
        List<TipoPersonaje> tipos = new List<TipoPersonaje>()
        {
            new TipoPersonaje { idTipo = 1, descripcionTipo = "Adulto" },
            new TipoPersonaje { idTipo = 2, descripcionTipo = "Niño" },
            new TipoPersonaje { idTipo = 3, descripcionTipo = "Anciano" },
            new TipoPersonaje { idTipo = 4, descripcionTipo = "Difunto" },
            new TipoPersonaje { idTipo = 5, descripcionTipo = "Personaje histórico" },
            new TipoPersonaje { idTipo = 6, descripcionTipo = "Artista invitado" }
        };

        public List<TipoPersonaje> listarTipos()
        {
            return tipos.ToList();
        }

        public TipoPersonaje buscarTipoPorId(int id)
        {
            return tipos.FirstOrDefault(o => o.idTipo == id);
        }

        public bool agregarTipo(TipoPersonaje Tipo)
        {
            return true;
        }

        public bool eliminarTipo(int id)
        {
            return true;
        }
    }
}
