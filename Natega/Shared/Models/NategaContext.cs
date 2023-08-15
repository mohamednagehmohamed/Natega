using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natega.Shared.Models
{
    public class NategaContext:DbContext
    {
        public NategaContext(DbContextOptions<NategaContext> options):base(options) { }

        public DbSet<Stage_New_Dawly> Stage_New_Dawly { get; set; }
        public DbSet<Stage_New_Search> Stage_New_Search { get; set; }
        public DbSet<X_Search> X_Search { get; set; }
    }
}
