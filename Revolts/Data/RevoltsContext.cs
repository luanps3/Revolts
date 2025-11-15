using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Revolts.Models;

namespace Revolts.Data
{
    public class RevoltsContext : DbContext
    {
        public RevoltsContext (DbContextOptions<RevoltsContext> options)
            : base(options)
        {
        }

        public DbSet<Revolts.Models.TipoUsuario> TipoUsuario { get; set; } = default!;
        public DbSet<Revolts.Models.Usuario> Usuario { get; set; } = default!;
    }
}
