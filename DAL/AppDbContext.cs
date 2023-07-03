using Microsoft.EntityFrameworkCore;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;


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
                new Role { id = 1, name = "Admin" },
                new Role { id = 2, name = "Gerant" },
                new Role { id = 3, name = "Agent" },
                new Role { id = 4, name = "Client" }
            );


            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.agence)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.id_agence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_id_agence");

                entity.HasOne(d => d.Role).WithMany(p => p.users).HasForeignKey(d => d.id_role)
                    .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Users_id_role");
            });


            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasOne(d => d.Vehicule)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.id_vehicule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservation_id_vehicule");
            });


            modelBuilder.Entity<Modele>(entity =>
            {
                entity.HasOne(d => d.Marque)
                    .WithMany(p => p.Modeles)
                    .HasForeignKey(d => d.id_marque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modeles_id_marque");
            });

            modelBuilder.Entity<Contrat>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Contrats)
                    .HasForeignKey(d => d.id_client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contrats_id_client");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.Contrats)
                    .HasForeignKey(d => d.id_reservation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contrats_id_reservation");
            });

            modelBuilder.Entity<Vehicule>(entity =>
            {
                entity.HasOne(d => d.Modele)
                    .WithMany(p => p.Vehicules)
                    .HasForeignKey(d => d.id_modele)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicules_id_modele");

                entity.HasOne(d => d.Agence)
                    .WithMany(p => p.Vehicules)
                    .HasForeignKey(d => d.id_agence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicules_id_agence");
            });

            modelBuilder.Entity<Offre>(entity =>
            {
                entity.HasOne(d => d.Vehicule)
                    .WithMany(p => p.Offre)
                    .HasForeignKey(d => d.id_vehicule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offre_id_vehicule");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        // insert sample data
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}