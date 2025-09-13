using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using WellnessHubAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Agrega soporte para controladores
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Agrega servicios para Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. Usa Swagger y Swagger UI (solo en desarrollo o en todos, tú decides)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsAssembly("MiProyecto.Data")));
//hola
// 4. Habilita HTTPS
app.UseHttpsRedirection();

// 5. Usa routing y autorización (si aplica)
app.UseRouting();
app.UseAuthorization(); // Sólo si usas autenticación

// 6. Mapea los controladores para las rutas API
app.MapControllers();

app.Run();