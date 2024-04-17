using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("DetalleFacturas")]
    public class FacturasDetalleModel : EntidadBase
    {
        [Key]
        public int FacturaDetalleId { get; set; }
        [Required]
        public int FacturaId { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public int ProductoId { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal Descuento { get; set; }
    }
}
