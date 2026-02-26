var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   
app.UseStaticFiles();   

app.MapPost("/add", async (HttpRequest request) =>
{
    var form = await request.ReadFormAsync();
    int num1 = int.Parse(form["num1"]);
    int num2 = int.Parse(form["num2"]);
    int result = num1 + num2;

    return Results.Text(result.ToString());
});

app.Run();
