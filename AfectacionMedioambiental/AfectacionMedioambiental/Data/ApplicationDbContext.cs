﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using AfectacionMedioambiental.Models;

namespace AfectacionMedioambiental.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}
