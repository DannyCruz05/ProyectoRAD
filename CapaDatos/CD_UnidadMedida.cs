using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CapaDatos.Core;
using CapaDatos.Modelos;

namespace CapaDatos
{
    public class CD_UnidadMedida
    {

        UnitofWork _unitofWork;

        Core.Repository<UnidadMedidaModel> _repository;

        public CD_UnidadMedida()
        {
            _unitofWork = new UnitofWork();
        }
        public int ClienteId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }


        public List<UnidadMedidaModel> TodasLasunidadMedidas()
        {
            return _repository.Consulta().ToList();
        }

        public int Agregar(UnidadMedidaModel UnidadMedida)
        {
            _unitofWork.Repository<UnidadMedidaModel>().Agregar(UnidadMedida);
            return _unitofWork.Guardar(); ;
        }
        public int Editar(UnidadMedidaModel UnidadMedida)
        {
            var unidadMedidaInDb = _repository.Consulta().FirstOrDefault(C => C.UnidadMedidaId == UnidadMedida.UnidadMedidaId);

            if (unidadMedidaInDb != null)
            {
                unidadMedidaInDb.FechaModificacion = DateTime.Now;
                unidadMedidaInDb.UnidadMedidaId = UnidadMedida.UnidadMedidaId;
                unidadMedidaInDb.Codigo = UnidadMedida.Codigo;
                unidadMedidaInDb.FechaCreacion = UnidadMedida.FechaCreacion;
                unidadMedidaInDb.Estado = UnidadMedida.Estado;
                _repository.Editar(unidadMedidaInDb);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int UnidadMedidaId)
        {
            var unidadMedidaInDb = _repository.Consulta().FirstOrDefault(C => C.UnidadMedidaId == UnidadMedidaId);
            if (unidadMedidaInDb != null)
            {
                _repository.Eliminar(unidadMedidaInDb);
                return 1;
            }
            return 0;
        }


    }
}
