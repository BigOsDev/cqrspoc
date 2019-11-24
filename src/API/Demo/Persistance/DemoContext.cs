using Demo.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Persistance
{
   public  class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options)
               : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
