﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication15.Controllers.Models;

namespace WebApplication15.Data
{
    public class WebApplication15Context : DbContext
    {
        public WebApplication15Context (DbContextOptions<WebApplication15Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication15.Controllers.Models.Product> Product { get; set; } = default!;
    }
}
