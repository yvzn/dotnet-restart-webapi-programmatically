
namespace ApplicationLifetimeStopApplication.Services;

public class ApplicationUptimeService: BackgroundService
{
    private readonly DateTimeOffset startupTime;

    public ApplicationUptimeService()
    {
        startupTime = DateTimeOffset.UtcNow;
    }

    public TimeSpan GetUptime() => DateTimeOffset.UtcNow - startupTime;

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return Task.CompletedTask;
    }
}