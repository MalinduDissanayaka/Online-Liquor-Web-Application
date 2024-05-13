using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LiquorOnline.Models;

namespace LiquorOnline.Data
{
    public class LiquorOnlineContext : DbContext
    {
        public LiquorOnlineContext (DbContextOptions<LiquorOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<LiquorOnline.Models.Product> Product { get; set; } = default!;
        public DbSet<LiquorOnline.Models.User> Users { get; set; } = default!;
        public DbSet<LiquorOnline.Models.Deliver> Deliver { get; set; } = default!;
    }
}
