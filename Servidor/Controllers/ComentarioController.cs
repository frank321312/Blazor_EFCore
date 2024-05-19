using Microsoft.AspNetCore.Mvc;
using Servidor.Entidades;
using Servidor.DTos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Servidor.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ComentarioController: ControllerBase
{
    private readonly AplcactionDbContext context;
    private readonly IMapper mapper;
    public ComentarioController(AplcactionDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> Post(ComentarioCreacionDTO comentarioCreacionDTO)
    {
        var comentario = mapper.Map<Comentario>(comentarioCreacionDTO);
        // var usuario = await context.Usuarios.FindAsync(comentarioCreacionDTO.UsuarioId);
        
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
