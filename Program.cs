using ApplicationLifetimeStopApplication.Services;

if (args.Contains("--delay"))
{
    await Task.Delay(5_000);
}

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<ApplicationUptimeService>();
builder.Services.AddSingleton<ApplicationUptimeService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
