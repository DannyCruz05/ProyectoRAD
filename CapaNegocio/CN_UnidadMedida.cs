using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_UnidadMedida
    {
        UnidadMedidasD cdUnidadMedida;

        public CN_UnidadMedida()
        {
           cdUnidadMedida = new CD_UnidadMedidas();
        }

        public List<UnidadMedidasModel> obtenerTodasLasUnidadMedidas()
        {
            return cdUnidadMedida.TodasLasUnidadMedidas();
        }

        public List<UnidadMedidasModel> obtenerUnidadMedidasActivos()
        {
            return cdUnidadMedida.TodasLasUnidadMedidas().Where(c => c.Estado == true).ToList();
        }

        public int Guardar(UnidadMedidasModel UnidadMedida)
        {
            if (UnidadMedida.UnidadMedidaId == 0)
            {
                return cdUnidadMedida.Agregar(UnidadMedida);
            }
            else
            {
                return cdUnidadMedida.Editar(UnidadMedida);
            }

        }

        public int Eliminar(int UnidadMedidaId)
        {
            return cdUnidadMedida.Eliminar(UnidadMedidaId);
        }
    }
}