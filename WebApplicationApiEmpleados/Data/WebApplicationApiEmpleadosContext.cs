using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationApiEmpleados.Modelo;

namespace WebApplicationApiEmpleados.Data
{
    public class WebApplicationApiEmpleadosContext : DbContext
    {
        public WebApplicationApiEmpleadosContext (DbContextOptions<WebApplicationApiEmpleadosContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationApiEmpleados.Modelo.Empleados> Empleados { get; set; } = default!;
    }
}
