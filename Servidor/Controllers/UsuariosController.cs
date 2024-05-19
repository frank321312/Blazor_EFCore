using Microsoft.AspNetCore.Mvc;
using Servidor.DTos;
using Servidor.Entidades;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Servidor.Servicios;
namespace Servidor.Controllers;

[ApiController]
[Route("api/usuario")]
public class UsuariosController : ControllerBase
{
    private readonly AplcactionDbContext context;
    private readonly IMapper mapper;
    private readonly IUsuario iUsuario;
    public UsuariosController(AplcactionDbContext context, IMapper mapper, IUsuario iUsuario)
    {
        this.context = context;
        this.mapper = mapper;
        this.iUsuario = iUsuario;
    }

    // [HttpPost]
    // public async Task<ActionResult> Post(UsuarioCreacionDTO usuarioDTO)
    // {
    //     // var usuario = new Usuario
    //     // {
    //     //     Nombre = usuarioDTO.Nombre,
    //     //     Email = usuarioDTO.Email,
    //     //     Password = usuarioDTO.Password
    //     // };
    //     var usuario = mapper.Map<Usuario>(usuarioDTO);
    //     context.Add(usuario);
    //     await context.SaveChangesAsync();
    //     return Ok();
    // }

    [HttpPost]
    public async Task<ActionResult> Post(UsuarioCreacionDTO usuarioDTO)
    {
        var usuario = await Task.FromResult(iUsuario.CrearUsuario(usuarioDTO));
        context.Add(usuario);
        await context.SaveChangesAsync();
        
        return Ok();
    }

    [HttpGet]
    public async Task<List<Usuario>> Get()
    {
        return await Task.FromResult(iUsuario.ObtenerUsuarios());
    }
}
