var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok("Hello World");
});
app.MapGet("/{nome}", (string nome) =>
{
    return Results.Ok($"Hello {nome}");
});

app.Run();
