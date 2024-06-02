var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.UseHttpsRedirection();

app.MapGet("/api2", () => "API2");


app.Run();

