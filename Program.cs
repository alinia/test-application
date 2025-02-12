var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

app.MapOpenApi();
app.Map(
    "/branch1",
    b =>
    {
        b.UseRouting();
        b.UseEndpoints(e => e.MapGet("say-hello", () => "Hello from branch1"));
    }
);

app.Map(
    "/branch2",
    b =>
    {
        b.UseRouting();
        b.UseEndpoints(e => e.MapGet("say-hello", () => "Hello from branch2"));
    }
);


app.Run();