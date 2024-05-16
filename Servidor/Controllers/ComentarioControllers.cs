using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Servidor.Entidades;
using Servidor.DTos;
using Microsoft.EntityFrameworkCore;

namespace Servidor.Controllers;

[ApiController]
[Route("/api/comentarios")]
public class ComentarioControllers: ControllerBase
{
    private readonly AplcactionContext context;
    private readonly IMapper mapper;
    public ComentarioControllers(AplcactionContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> Post(ComentarioCreacionDTO comentarioCreacionDTO)
    {
        var comentario = mapper.Map<Comentario>(comentarioCreacionDTO);
        // var usuario = await context.Usuarios.FindAsync(comentarioCreacionDTO.UsuarioId);

        // if (usuario == null)
        // {
        //     return NotFound("Usuario no encontrado");    
        // }
        // comentario.Usuario = usuario;
        context.Add(comentario);
        await context.SaveChangesAsync();

        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<List<Comentario>>> Get()
    {
        var comentarios = await context.Comentarios.Include(x => x.Usuario).ToListAsync();
        return comentarios;
    }
}
