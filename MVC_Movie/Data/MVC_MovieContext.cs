using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Movie.Models
{
    public class MVC_MovieContext : DbContext
    {
        public MVC_MovieContext (DbContextOptions<MVC_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Movie.Models.Movie> Movie { get; set; }
    }
}
