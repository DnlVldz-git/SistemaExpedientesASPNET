using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ControlExpedientes.Models;

namespace ControlExpedientes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ControlExpedientes.Models.Paciente> Paciente { get; set; }
        public DbSet<ControlExpedientes.Models.Empleado> Empleado { get; set; }
        public DbSet<ControlExpedientes.Models.Citas> Citas { get; set; }
        public DbSet<ControlExpedientes.Models.Consulta> Consulta { get; set; }
        public DbSet<ControlExpedientes.Models.Expediente> Expediente { get; set; }
        public DbSet<ControlExpedientes.Models.ProjectoRole> ProjectoRole { get; set; }
    }
}
