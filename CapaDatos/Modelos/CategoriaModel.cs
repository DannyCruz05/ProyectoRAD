using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CapaDatos.Modelos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    [Table("Categorias")]
    public class CategoriaModel: EntidadBase
    {
            [Key]
            public int CategoriaId { get; set; }

            [Required]
            [MaxLength(50)]
            public string Codigo { get; set; }
            [Required]
            [MaxLength(50)]
            public string Descripcion { get; set; }
            public bool Estado { get; set; }
            public DateTime FechaIngreso { get; set; }
        }
    }
