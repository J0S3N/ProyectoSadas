using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoSadas.Models;

namespace ProyectoSadas.Data
{
    public class ProyectoSadasContexto : DbContext
    {
        public ProyectoSadasContexto (DbContextOptions<ProyectoSadasContexto> options)
            : base(options)
        {
        }

        public DbSet<ProyectoSadas.Models.Solicitud> Solicitud { get; set; } = default!;
    }
}
