using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlExpedientes.Models
{
    public class Expediente
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("PacienteId")]
        public int PacienteId { get; set; }

        public Paciente Paciente { get; set; }

        [Required]
        [ForeignKey("EmpleadoId")]
        public int EmpleadoId { get; set; }

        public Empleado Empleado { get; set; }

        [Required]
        [DisplayName("Presión asistólica")]
        public int Presion1 { get; set; }

        [Required]
        [DisplayName("Presión diástolica")]
        public int Presion2 { get; set; }

        [Required]
        public float Peso { get; set; }

        [Required]
        public float Altura{ get; set; }

        [DisplayName("Enfermedad Crónica Degenerativa")]
        public String CrónicoDegenerativa{ get; set; }


        [DisplayName("Operaciones")]
        public String Operaciones { get; set; }

        [DisplayName("Alergias")]
        public String Alergias { get; set; }

        [Required]
        public String Reflejos { get; set; }

        [Required]
        public String Movimientos { get; set; }

        public String Observaciones { get; set; }
    }
}
