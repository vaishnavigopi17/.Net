var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/add/{a}/{b}", (int a,int b) =>  a + b);

app.Run();
