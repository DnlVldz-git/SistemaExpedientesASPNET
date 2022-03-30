using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlExpedientes.Models
{
    public class Consulta
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Fecha de consulta")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Fecha{ get; set; }

        [Required]
        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }

        [Required]
        public Paciente Paciente { get; set; }

        [Required]
        public String Sintomas { get; set; }

        [Required]
        public String Diagnostico { get; set; }

        [Required]
        public String Medicamentos { get; set; }
    }
}
