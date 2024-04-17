using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("Factura")]
    public class FacturasModel
    {
        public int FacturaId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int PedidoId { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public DateTime FechaFactura { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Descuento { get; set; }
    }
}
