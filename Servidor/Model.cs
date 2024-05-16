using Microsoft.EntityFrameworkCore;
using Servidor.Entidades;
using System.Reflection;

public class AplcactionContext : DbContext
{
    public AplcactionContext(DbContextOptions options) : base(options)
    {
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
        // modelBuilder.Entity<Usuario>().Property(x => x.Nombre).HasMaxLength(45);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Comentario>().HasOne(x => x.Usuario)
        .WithMany(x => x.Comemtarios)
        .HasForeignKey(x => x.UsuarioId);
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Comentario> Comentarios => Set<Comentario>(); 
}