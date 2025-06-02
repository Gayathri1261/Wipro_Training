using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication14.Controllers.Models;

namespace WebApplication14.Data
{
    public class WebApplication14Context : DbContext
    {
        public WebApplication14Context (DbContextOptions<WebApplication14Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication14.Controllers.Models.Employee> Employee { get; set; } = default!;
    }
}
