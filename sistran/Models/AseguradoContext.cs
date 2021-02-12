using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistran.Models
{
    public class AseguradoContext:DbContext
    {
        public AseguradoContext(DbContextOptions<AseguradoContext> options) : base(options)
        {

        }

        public DbSet<sistran.Models.AseguradoModel> t_asegurado { get; set; }
    }
}
