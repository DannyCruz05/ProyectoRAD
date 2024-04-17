using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_GrupoDescuento
    {
        CD_GrupoDescuento cdGrupoDescuento;
        public NGrupoDescuento()
        {
            cdGrupoDescuento = new CD_GrupoDescuento();
        }

        public List<GrupoDescuentoModel> obtenerGrupoDescuento()
        {
            return cdGrupoDescuento.TodasLosGrupoDescuentos();
        }

        public List<GrupoDescuento> obtenerGrupoDescuentosGrid()
        {
            var GrupoDescuentos = cdGrupoDescuento.TodasLosGrupoDescuentos()
                                   .ToList()
                                   .Select(c => new { c.GrupoDescuentoId, c.Codigo, c.Nombres, c.Apellidos, c.ClasificacionGrupoDescuento.Descripcion, Grupo = c.GrupoGrupoDescuento.Descripcion });
            return cdGrupoDescuento.TodasLosGrupoDescuentos();
        }

        public List<GrupoDescuento> obtenerGrupoDescuentosInactivos()
        {
            var GrupoDescuentos = cdGrupoDescuento.TodasLosGrupoDescuentos();
            return GrupoDescuentos.Where(c => c.Estado == true).ToList();
        }

        public int Guardar(GrupoDescuento GrupoDescuento)
        {
            if (GrupoDescuento.GrupoDescuentoId == 0)
            {
                return cdGrupoDescuento.Agregar(GrupoDescuento);
            }
            else
            {
                return cdGrupoDescuento.Editar(GrupoDescuento);
            }

        }

        public int Eliminar(int GrupoDescuentoId)
        {
            return cdGrupoDescuento.Eliminar(GrupoDescuentoId);
        }
    }
}