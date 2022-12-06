using System;
using AR.Domain;
using Microsoft.EntityFrameworkCore;

namespace AR.Data
{
    public class ContextoPrincipal : DbContext // herdando do EntityFramework
    {
        public ContextoPrincipal(DbContextOptions options) 
            : base(options)
        {

        }
        // Tabela
        public DbSet<Cliente> Cliente { get; set; }
    }
}
