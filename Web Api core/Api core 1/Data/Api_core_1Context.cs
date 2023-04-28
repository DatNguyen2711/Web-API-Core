using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api_core_1.Model;

namespace ProductAPI.Data
{
    public class Api_core_1Context : DbContext
    {
        public Api_core_1Context (DbContextOptions<Api_core_1Context> options)
            : base(options)
        {
        }

        public DbSet<Api_core_1.Model.Product> Product { get; set; } = default!;
    }
}
