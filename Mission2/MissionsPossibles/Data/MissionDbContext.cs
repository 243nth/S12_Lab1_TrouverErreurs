using Microsoft.EntityFrameworkCore;
using Mission.Models;


namespace Mission.Data
{
    public class MissionDbContext: DbContext
    {
        public MissionDbContext(DbContextOptions<MissionDbContext> options)
            : base(options)
        {

        }

        public DbSet<Categorie> Categories { get; set; }
        //Il faut DbSet le produit afin que les données soit accèssible pour l'application.
        public DbSet<Produit> Produits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //Générer des données de départ
             modelBuilder.GenerateData();
       }

    }
}
