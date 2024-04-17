using CapaDatos.Core;
using CapaDatos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_GrupoDescuento
    {
        UnitofWork _unitofWork;

        public CD_GrupoDescuento()
        {
            _unitofWork = new UnitofWork();
        }
        public int GrupoDescuentoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<GrupoDescuentoModel> TodosLosGruposDescuento()
        {
            return _unitofWork.Repository<GrupoDescuentoModel>().Consulta().ToList();
        }
    }
}
