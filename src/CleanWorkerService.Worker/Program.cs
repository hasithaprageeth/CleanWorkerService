using CleanWorkerService.Worker;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices();

var host = builder.Build();
host.Run();
