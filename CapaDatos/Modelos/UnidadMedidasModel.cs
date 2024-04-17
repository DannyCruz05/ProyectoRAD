using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("TablaUnidadMedida")]
    public class UnidadMedidasModel : EntidadBase
    {

        [Key]
        public int UnidadMedidaId { get; set; }

        [MaxLength(50)]
        public string Codigo { get; set; }
        [MaxLength(50)]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
