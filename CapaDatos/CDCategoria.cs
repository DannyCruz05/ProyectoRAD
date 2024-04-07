using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Modelos;

namespace CapaDatos
{
    public class CDCategoria
    {
        Core.Repository<CategoriaModel> _repository;
        public CDCategoria()
        {
            _repository = new Core.Repository<CategoriaModel>();
        }
        public int CategoriaID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        
        public bool Estado { get; set; }
        public DateTime FechaIngreso { get; set; }

        public List<CategoriaModel> TodasLasCategorias()
        {
            return _repository.Consulta().ToList();
        }

        public int Agregar(CategoriaModel categoria)
        {
            categoria.FechaCreacion = DateTime.Now;
            categoria.FechaModificacion = DateTime.Now;
            _repository.Agregar(categoria);

            return 1;
        }

        public int Editar(CategoriaModel categoria)
        {
            var categoriaInDb = _repository.Consulta().FirstOrDefault(C => C.CategoriaId == categoria.CategoriaId);

            if (categoriaInDb != null)
            {
                categoriaInDb.FechaModificacion = DateTime.Now;
                categoriaInDb.Codigo = categoria.Codigo;
                categoriaInDb.Descripcion = categoria.Descripcion;
                categoriaInDb.FechaIngreso = categoria.FechaIngreso;
                categoriaInDb.Estado = categoria.Estado;
                _repository.Editar(categoriaInDb);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int categoriaId)
        {
            var categoriaInDb = _repository.Consulta().FirstOrDefault(C => C.CategoriaId == categoriaId);
            if (categoriaInDb != null)
            {
                _repository.Eliminar(categoriaInDb);
                return 1;
            }
            return 0;
        }
    }
}
