using SistemaBiblioteca.Data;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Data;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Registrar el DbContext con la cadena de conexión
builder.Services.AddDbContext<BibliotecaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaConnection")));

// 2️⃣ Agregar servicios MVC
builder.Services.AddControllersWithViews();

// 3️⃣ Configurar CORS con origen específico y credenciales
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000") // URL de tu frontend
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 4️⃣ Activar CORS antes de Authorization
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
