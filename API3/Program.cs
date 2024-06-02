var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.UseHttpsRedirection();

app.MapGet("/api3", () => "API3");


app.Run();

