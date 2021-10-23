using AppEventos.Shared.Entidades;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEventos.Server
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
           IOptions<OperationalStoreOptions> operationalStoreOptions)
          : base(options, operationalStoreOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaEvento>().HasKey(x => new { x.CategoriaId, x.EventoId });
            modelBuilder.Entity<EstadoEvento>().HasKey(x => new { x.EstadoId, x.EventoId });


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaEvento> CategoriaEventos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<EstadoEvento> EstadoEventos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
    }
}
