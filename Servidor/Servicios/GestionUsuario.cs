using Servidor.Entidades;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Servidor.DTos;
namespace Servidor.Servicios;

public class GestionUsuario : IUsuario
{
    private AplcactionDbContext context;
    private readonly IMapper mapper;
    public GestionUsuario(AplcactionDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;

    }
    public List<Usuario> ObtenerUsuarios()
    {
        try
        {
            return context.Usuarios.Include(x => x.Comemtarios).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
    }
    public Usuario CrearUsuario(UsuarioCreacionDTO usuarioDTO)
    {
        var usuario = mapper.Map<Usuario>(usuarioDTO);
        return usuario;
    } 
}
