using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Neuma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuma.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<TopFeature> TopFeatures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>(e => { e.ToTable(name:"User"); });
            modelBuilder.Entity<IdentityRole>(e => { e.ToTable(name: "Role"); });
            modelBuilder.Entity<IdentityRoleClaim<string>>(e => { e.ToTable(name: "RoleClaims"); });
            modelBuilder.Entity<IdentityUserClaim<string>>(e => { e.ToTable(name: "UserClaims"); });
            modelBuilder.Entity<IdentityUserRole<string>>(e => { e.ToTable(name: "UserRoles"); });
            modelBuilder.Entity<IdentityUserToken<string>>(e => { e.ToTable(name: "UserTokens"); });

            //Definir algunos elementos dentro de la tabla
            modelBuilder.Entity<TopFeature>().HasData(
                
                new TopFeature
                {
                    Id = 1,
                    Title = "¿Quienes somos?",
                    Description = "Somos gente que intenta vivir su vida siguiendo lo que Jesús enseñaba y en el camino nos dimos cuenta que era más facil hacerlo entre amigos",
                    Image = "~/images/SomosUno.jpg"
                },
                new TopFeature
                {
                    Id = 2,
                    Title = "¿Porque lo hacemos?",
                    Description = "Porque creemos que solo a traves del verdadero amor podemos encontrar el proposito de nuestra vida",
                    Image = "~/images/OtraNico.jpg"
                },
                new TopFeature
                {
                    Id = 3,
                    Title = "¿Donde estamos?",
                    Description = "Neuma no tiene un espacio logico definido porque somos un grupo de amigos",
                    Image = "~/images/Nico.jpg"
                });
        }

    }
}
