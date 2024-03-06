using Eval_D2_P2_back_louis_perrin_Application.Interfaces;
using Eval_D2_P2_back_louis_perrin_Application.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();

        services.AddScoped<IEvenementService, EvenementService>();
    })
    .Build();

host.Run();
