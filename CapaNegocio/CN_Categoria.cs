namespace CapaNegocio
{
    internal class CN_Categoria
    {
        CDCategoria dCategoria;
        public CN_Categoria()
        {
            dCategoria = new CDCategoria();
        }

        public List<Categoria> obtenerCategoria()
        {
            return dCategoria.TodasLosCategorias();
        }

        public List<Categoria> obtenerCategoriasGrid()
        {
            var categorias = dCategoria.TodasLosCategorias()
                                   .ToList()
                                   .Select(c => new { c.CategoriaId, c.Codigo, c.Descripcion });
            return dCategoria.TodasLosCategorias();
        }

        public List<Categoria> obtenerCategoriasInactivos()
        {
            var categorias = dCategoria.TodasLosCategorias();
            return categorias.Where(c => c.Estado == true).ToList();
        }

        public int Guardar(Categoria categoria)
        {
            if (categoria.CategoriaId == 0)
            {
                return dCategoria.Agregar(categoria);
            }
            else
            {
                return dCategoria.Editar(categoria);
            }

        }

        public int Eliminar(int categoriaId)
        {
            return dCategoria.Eliminar(categoriaId);
        }
    }
}
