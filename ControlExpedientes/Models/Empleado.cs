using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlExpedientes.Models
{
    public class Empleado
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        public String Rol { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}
