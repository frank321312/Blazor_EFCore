using Microsoft.AspNetCore.Mvc;
using Servidor.DTos;
using Servidor.Entidades;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace Servidor.Controllers;

[ApiController]
[Route("api/usuarios")]
public class UsuariosControllers: ControllerBase
{
    private readonly AplcactionContext context;
    private readonly IMapper mapper;
    public UsuariosControllers(AplcactionContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> Post(UsuarioCreacionDTO usuarioDTO)
    {
        // var usuario = new Usuario
        // {
        //     Nombre = usuarioDTO.Nombre,
        //     Email = usuarioDTO.Email,
        //     Password = usuarioDTO.Password
        // };
        var usuario = mapper.Map<Usuario>(usuarioDTO);
        context.Add(usuario);
        await context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<List<Usuario>>> Get()
    {
        var usuarios = await context.Usuarios.Include(x => x.Comemtarios).ToListAsync();
        return usuarios;
    }
}
