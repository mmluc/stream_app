using Serilog;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("YARP"));

builder.Host.UseSerilog((context, services, configuration) => configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext()
);

var app = builder.Build();

//app.UseSerilogRequestLogging();
//app.UseHsts();
app.MapGet("/", () => "Hello World!");
app.MapReverseProxy();

app.Run();
