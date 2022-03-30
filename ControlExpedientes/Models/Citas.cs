using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlExpedientes.Models
{
    public class Citas
    {
        [Required]
        [Key]
        public int Id { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        public DateTime Hora { get; set; }

        [Required]
        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }

        [Required]
        public Paciente Paciente { get; set; }

        [Required]
        [ForeignKey("EmpleadoId")]
        public int EmpleadoId { get; set; }
        
        [Required]
        public Empleado Empleado{ get; set; }



    }
}
