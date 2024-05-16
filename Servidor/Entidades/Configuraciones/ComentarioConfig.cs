using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Servidor.Entidades.Configuraciones;

public class ComentarioConfig: IEntityTypeConfiguration<Comentario>
{
    public void Configure(EntityTypeBuilder<Comentario> builder)
    {
        builder.HasKey(x => x.ComentarioId);
        builder.Property(x => x.Contenido).HasMaxLength(500);
    }
}
