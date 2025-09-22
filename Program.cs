using TaskWeb.Models;

//Builder
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //interpreta o caminho da URL

//App
var app = builder.Build();

app.MapControllerRoute("default", "{controller=tag}/{action=index}");

app.Run();
