using TaskWeb.Models;

Tag tag = new Tag();
tag.SetTitle("Estudo");
Console.Write(tag.GetTitle());

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!?");

app.Run();
