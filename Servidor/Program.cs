using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddRazorPages();

builder.Services.AddControllers();
builder.Services.AddDbContext<AplcactionContext>(opciones => opciones.UseNpgsql(
    "name=DefaultConnection"));

// builder.Services.AddDbContext<AplcactionContext>(opt => opt.UseNpgsql(""))
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseStaticFiles();

// app.UseRouting();

app.UseAuthorization();

// app.MapRazorPages();
app.MapControllers();

app.Run();
