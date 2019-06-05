using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoAPI.Models.Context
{
    public class MySQLDbContext : DbContext
    {
        public MySQLDbContext()
        {

        }

        public MySQLDbContext(DbContextOptions<MySQLDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
