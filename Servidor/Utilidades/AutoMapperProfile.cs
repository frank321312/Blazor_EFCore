using AutoMapper;
using Servidor.Entidades;
using Servidor.DTos;
namespace Servidor.Utilidades;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<UsuarioCreacionDTO, Usuario>();
        CreateMap<ComentarioCreacionDTO, Comentario>();
    }
}
