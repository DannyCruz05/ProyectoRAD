using CapaDatos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class CD_Producto
    {
        Core.Repository<ProductoModel> _repository;
        public CD_Producto()
        {
            _repository = new Core.Repository<ProductoModel>();
        }
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        public int UnidadMedidaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public decimal PrecioCompra { get; set; }

        public List<ProductoModel> TodosLosProductos()
        {
            return _repository.Consulta().ToList();
        }

        public int Agregar(ProductoModel Producto)
        {
            Producto.FechaCreacion = DateTime.Now;
            Producto.FechaModificacion = DateTime.Now;
            _repository.Agregar(Producto);

            return 1;
        }
        public int Editar(ProductoModel Producto)
        {
            var ProductoInDb = _repository.Consulta().FirstOrDefault(C => C.ProductoId == Producto.ProductoId);

            if (ProductoInDb != null)
            {
                ProductoInDb.FechaModificacion = DateTime.Now;
                ProductoInDb.CategoriaId = Producto.CategoriaId;
                ProductoInDb.UnidadMedidaId = Producto.UnidadMedidaId;
                ProductoInDb.FechaCreacion = Producto.FechaCreacion;
                ProductoInDb.Estado = Producto.Estado;
                ProductoInDb.PrecioCompra = Producto.PrecioCompra;
                _repository.Editar(ProductoInDb);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int ProductoId)
        {
            var ProductoInDb = _repository.Consulta().FirstOrDefault(C => C.ProductoId == ProductoId);
            if (ProductoInDb != null)
            {
                _repository.Eliminar(ProductoInDb);
                return 1;
            }
            return 0;
        }

    }
}