using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("UnidadMedida")]
    public class UnidadMedidaModel: EntidadBase
    {
        [Key]
        public int UnidadMedidaId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; }
        [MaxLength(50)]
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
