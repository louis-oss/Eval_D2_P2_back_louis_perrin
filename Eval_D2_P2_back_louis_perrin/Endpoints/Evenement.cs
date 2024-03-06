using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Eval_D2_P2_back_louis_perrin_API.Endpoints;

public class Evenement
{
    private readonly ILogger<Evenement> _logger;
    private static List<Evenement> events = new List<Evenement>();

    public Evenement(ILogger<Evenement> logger)
    {
        _logger = logger;
    }

    [Function("AddEvent")]
    public static async Task<IActionResult> AddEvent(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
        ILogger _logger)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request to add an event.");

        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var eventData = JsonConvert.DeserializeObject<Evenement>(requestBody);
        if (eventData == null)
        {
            return new BadRequestObjectResult("Please pass event data in the request body");
        }

        events.Add(eventData); // Add the event to the in-memory list

        return new OkObjectResult($"Event added");
    }
}
