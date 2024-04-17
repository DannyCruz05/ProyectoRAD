using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("GruposDescuento")]
    public class GrupoDescuentoModel: EntidadBase
    {
        [Key]
        public int GrupoDescuentoId { get; set; }
        [MaxLength(50)]
        public string Codigo { get; set; }
        [MaxLength(50)]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; } 
    }
}
