using Microsoft.EntityFrameworkCore;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using Bogus;


namespace AutomotiveApi.DAL
{
    public partial class AppDbContext : DbContext
    {
        public IConfiguration Configuration { get; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Agence> Agences { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Marque> Marques { get; set; }
        public virtual DbSet<Modele> Modeles { get; set; }
        public virtual DbSet<Offre> Offres { get; set; }
        public virtual DbSet<Vehicule> Vehicules { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Contrat> Contrats { get; set; }
        public virtual DbSet<Log_journal> log_journal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Gerant" },
                new Role { Id = 3, Name = "Agent" },
                new Role { Id = 4, Name = "Client" },
                new Role { Id = 5, Name = "Commercial" }
            );


            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.Agence)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdAgence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_id_agence");

                entity.HasOne(d => d.Role).WithMany(p => p.Users).HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Users_id_role");
            });


            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasOne(d => d.Vehicule)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.IdVehicule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservation_id_vehicule");
            });


            modelBuilder.Entity<Modele>(entity =>
            {
                entity.HasOne(d => d.Marque)
                    .WithMany(p => p.Modeles)
                    .HasForeignKey(d => d.IdMarque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modeles_id_marque");
            });

            modelBuilder.Entity<Contrat>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Contrats)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contrats_id_client");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.Contrats)
                    .HasForeignKey(d => d.IdReservation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contrats_id_reservation");
            });

            modelBuilder.Entity<Vehicule>(entity =>
            {
                entity.HasOne(d => d.Modele)
                    .WithMany(p => p.Vehicules)
                    .HasForeignKey(d => d.IdModele)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicules_id_modele");

                entity.HasOne(d => d.Agence)
                    .WithMany(p => p.Vehicules)
                    .HasForeignKey(d => d.IdAgence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicules_id_agence");
            });

            modelBuilder.Entity<Offre>(entity =>
            {
                entity.HasOne(d => d.Vehicule)
                    .WithMany(p => p.Offre)
                    .HasForeignKey(d => d.IdVehicule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offre_id_vehicule");
            });

            modelBuilder
        .Entity<Agence>()
        .HasData(DataSeeder.seedAgence().Generate(10));

            modelBuilder.Entity<Marque>()
        .HasData(DataSeeder.seedMarque().Generate(10));

            modelBuilder.Entity<Modele>().HasData(DataSeeder.seedModele().Generate(10));

            modelBuilder.Entity<User>().HasData(DataSeeder.seedUser().Generate(10));


            // filter deleted entities
            
            modelBuilder.Entity<Agence>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Marque>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Modele>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<User>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Role>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Offre>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Vehicule>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Reservation>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Contrat>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Client>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<Log_journal>().HasQueryFilter(a => a.DeletedAt == null);            
            


            OnModelCreatingPartial(modelBuilder);
        }

        // insert sample data
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}