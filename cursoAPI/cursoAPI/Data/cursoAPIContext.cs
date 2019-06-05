using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cursoAPI.Models
{
    public class cursoAPIContext : DbContext
    {
        public cursoAPIContext (DbContextOptions<cursoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<cursoAPI.Models.Person> Person { get; set; }
    }
}
