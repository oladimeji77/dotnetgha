var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

// GET UTC
app.MapGet("/hello", async context => {
    await context.Response.WriteAsync("Hello world");
});

await app.RunAsync();
