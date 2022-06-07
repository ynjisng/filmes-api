using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt){}

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Filme> Cinemas { get; set; }

        public DbSet<Filme> Enderecos { get; set; }

        public DbSet<Filme> Estudios { get; set; }
    }
}
