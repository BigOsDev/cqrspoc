using Demo.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Persistance
{
   public  class DemoContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}
