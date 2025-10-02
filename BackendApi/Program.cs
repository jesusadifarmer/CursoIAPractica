var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => Results.Json(new { message = "API Backend funcionando" }))
    .WithName("GetRoot")
    .WithOpenApi();

app.MapGet("/health", () => Results.Json(new { status = "Healthy" }))
    .WithName("GetHealth")
    .WithOpenApi();

app.Run();
