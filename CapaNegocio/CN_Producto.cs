using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        CD_Productos cdProducto;

        public CN_Producto()
        {
            cdProducto = new CD_Productos();
        }

        public List<ProductosModel> obtenerTodosLosProductos()
        {
            return cdProducto.TodosLosProductos();
        }

        public List<ProductosModel> obtenerProductosActivos()
        {
            return cdProducto.TodosLosProductos().Where(c => c.Estado == true).ToList();
        }

        public int Guardar(ProductosModel Producto)
        {
            if (Producto.ProductoId == 0)
            {
                return cdProducto.Agregar(Producto);
            }
            else
            {
                return cdProducto.Editar(Producto);
            }

        }

        public int Eliminar(int ProductoId)
        {
            return cdProducto.Eliminar(ProductoId);
        }
    }