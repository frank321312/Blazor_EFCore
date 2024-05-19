using Servidor.Entidades;
using Servidor.DTos;
namespace Servidor.Servicios;

public interface IUsuario
{
    public List<Usuario> ObtenerUsuarios();
    public Usuario CrearUsuario(UsuarioCreacionDTO usuarioDTO);
}
