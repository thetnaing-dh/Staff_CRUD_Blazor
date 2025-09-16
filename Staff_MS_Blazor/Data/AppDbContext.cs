using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Staff_MS_Blazor.Models;

namespace Staff_MS_Blazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Staff_MS_Blazor.Models.Staff> Staff { get; set; } = default!;
    }
}
