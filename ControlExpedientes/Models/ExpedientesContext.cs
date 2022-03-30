using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ControlExpedientes.Models
{
    public class ExpedientesContext
    {
        public DbSet<Citas> Citas { get; set; }

        public DbSet<Consulta> Consultas { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Expediente> Expedientes { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

    }
}
