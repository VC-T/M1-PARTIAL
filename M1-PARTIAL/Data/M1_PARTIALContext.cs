using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using M1_PARTIAL.Model;

namespace M1_PARTIAL.Data
{
    public class M1_PARTIALContext : DbContext
    {
        public M1_PARTIALContext (DbContextOptions<M1_PARTIALContext> options)
            : base(options)
        {
        }

        public DbSet<M1_PARTIAL.Model.User> User { get; set; } = default!;
    }
}
