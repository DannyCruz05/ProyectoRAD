using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("Empleados")]
    public class ClientesModel : EntidadBase
    {
        [Key]
        public int? idempleado { get; set; }

        [Required]
        public string? razonsocial { get; set; }

        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? fechanacimiento { get; set; }

        [Range(0, 150)]
        public int? edad { get; set; }

        [DataType(DataType.Currency)]
        public float? salario { get; set; }
    }
}
