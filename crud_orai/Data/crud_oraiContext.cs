using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crud_orai.Models;

namespace crud_orai.Data
{
    public class crud_oraiContext : DbContext
    {
        public crud_oraiContext (DbContextOptions<crud_oraiContext> options)
            : base(options)
        {
        }

        public DbSet<crud_orai.Models.books> books { get; set; } = default!;
    }
}
