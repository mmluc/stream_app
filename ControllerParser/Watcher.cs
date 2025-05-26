using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class Watcher : IHostedService
{
    private readonly RouteParser _routeParser;
    private readonly IConfiguration _configuration;
    private readonly ILogger<Watcher> _logger;

    public Watcher(RouteParser routeParser, IConfiguration configuration, ILogger<Watcher> logger)
    {
        _routeParser = routeParser ?? throw new ArgumentNullException(nameof(routeParser));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Watcher servis pokrenut.");

        var filePath = _configuration.GetSection("RouteParser:FilePath").Get<string>();
        if (string.IsNullOrEmpty(filePath))
        {
            _logger.LogError("Putanja datoteke nije definirana u konfiguraciji.");
            return Task.CompletedTask;
        }

        try
        {
            var routes = _routeParser.ParseRoutes(filePath);
            _logger.LogInformation("Uspješno parsirane rute: {Routes}", string.Join(", ", routes));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Pogreška tijekom parsiranja ruta u Watcher servisu.");
        }

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Watcher servis zaustavljen.");
        return Task.CompletedTask;
    }
}