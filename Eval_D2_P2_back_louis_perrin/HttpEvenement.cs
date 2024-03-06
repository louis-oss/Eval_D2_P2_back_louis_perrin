using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Eval_D2_P2_back_louis_perrin
{
    public class HttpEvenement
    {
        private readonly ILogger<HttpEvenement> _logger;

        public HttpEvenement(ILogger<HttpEvenement> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
