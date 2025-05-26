using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Logging;
using Serilog;

public class RouteParser
{
    private readonly ILogger<RouteParser> _logger;

    public RouteParser(ILogger<RouteParser> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public List<string> ParseRoutes(string filePath)
    {
        try
        {
            _logger.LogInformation($"Pocetak parsiranja iz datoteke: {filePath}");

            if (string.IsNullOrEmpty(filePath))
            {
                _logger.LogError("Putanja datoteke prazna.");
                throw new ArgumentNullException(nameof(filePath), "File path is null");
            }
            if (!File.Exists(filePath))
            {
                _logger.LogError($"Datoteka ne postoji na putanji: {filePath}");
                throw new FileNotFoundException("The specified file does not exist", filePath);
            }

            var routes = new List<string>();
            string baseRoute = null;
            int lineNumber = 0;

            foreach (var line in File.ReadLines(filePath))
            {
                lineNumber++;
                var trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed))
                {
                    continue;
                }

                trimmed = trimmed.ToLowerInvariant();
                int start = trimmed.IndexOf('"') + 1;
                int end = trimmed.LastIndexOf('"');
                if (start <= 0 || end < start || end == -1)
                {
                    continue;
                }

                var route = trimmed.Substring(start, end - start).Trim();
                if (string.IsNullOrEmpty(route))
                {
                    continue;
                }

                if (trimmed.StartsWith("[route(\"") && trimmed.EndsWith("\")]"))
                {
                    baseRoute = route;
                    continue;
                }

                if ((trimmed.StartsWith("[httpget(\"") ||
                     trimmed.StartsWith("[httppost(\"") ||
                     trimmed.StartsWith("[httpput(\"") ||
                     trimmed.StartsWith("[httpdelete(\"")) &&
                    trimmed.EndsWith("\")]"))
                {
                    if (!string.IsNullOrEmpty(baseRoute))
                    {
                        var fullRoute = $"/{baseRoute}/{route}".Replace("//", "/").Trim('/');
                        routes.Add($"/{fullRoute}");
                        _logger.LogInformation($"Dodana ruta u liniji {lineNumber}: {fullRoute}");
                    }
                    else if (!string.IsNullOrEmpty(route))
                    {
                        routes.Add($"/{route}".Trim('/'));
                        _logger.LogInformation($"Dodana ruta bez bazne rute u liniji {lineNumber}: {route}");
                    }
                }
            }

            _logger.LogInformation($"Ukupno pronadeno ruta: {routes.Count}");
            return routes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Pogreska tijekom parsiranja datoteke: {filePath}");
            throw;
        }
    }
}