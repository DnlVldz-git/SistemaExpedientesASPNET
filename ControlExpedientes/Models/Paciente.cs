using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlExpedientes.Models
{
    public class Paciente
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        [DisplayName("Apellido Paterno")]
        public String ApellidoPat { get; set; }

        [Required]
        [DisplayName("Apellido Materno")]
        public String ApellidoMat { get; set; }

        [Required]
        public String Sexo { get; set; }
            
        public String RFC { get; set; }

        [Required]
        [DisplayName("Tipo de Sangre")]
        public String TipoSangre { get; set; }

        [Required]
        [DisplayName("Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime FechaNac { get; set; }

        [Required]
        public bool Alcoholismo { get; set; }

        [Required]
        public bool Tabaquismo { get; set; }

        [Required]
        public bool Toxicomanía { get; set; }

        [Required]
        public string Dirección { get; set; }

        [Required]
        public string Correo{ get; set; }

        [Required]
        public string CURP { get; set; }

        [Required]
        public string Aseguradora { get; set; }
    }
}

