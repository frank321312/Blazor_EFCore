using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Servidor.Entidades.Configuraciones;

public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(x => x.UsuarioId);
        builder.Property(x => x.Nombre).HasMaxLength(45);
        builder.Property(x => x.Email).HasMaxLength(75);
        builder.Property(x => x.Password).HasMaxLength(45);
    }
}
