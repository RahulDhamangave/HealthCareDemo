using EvolnetHealth.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvolentHealth.Providers.DataContexts
{
    public class HealthContactsDbContext : DbContext
    {
        public HealthContactsDbContext(DbContextOptions<HealthContactsDbContext> options)
            : base(options) { }
        public DbSet<Contacts> Contacts { get; set; }
        
    }
}
