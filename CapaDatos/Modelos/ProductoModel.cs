using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("Productos")]
    public class ProductoModel:EntidadBase
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [Required]
        public int UnidadMedidaId { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public decimal PrecioCompra { get; set; }
    }
}
