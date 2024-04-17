﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{ 
    [Table("Clientes")]
    public class ClienteModel: EntidadBase
    {
       
            [Key]
            public int ClienteId { get; set; }
            [Required]
            [MaxLength(15)]
             public string Codigo { get; set; }
            [MaxLength(50)]
            [Required]
            public string Nombres { get; set; }

            [MaxLength(50)]
            [Required]
            public string Apellidos { get; set; }

            [Required]
            public int GrupoDescuentoId { get; set; }

            [Required]
            public int CondicionId { get; set; }
            [Required]
            public bool Estado { get; set; }
            [Required]
            public DateTime FechaCreacion { get; set; }
        }
    }
