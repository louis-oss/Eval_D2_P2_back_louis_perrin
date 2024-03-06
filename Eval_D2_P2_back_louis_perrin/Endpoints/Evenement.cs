using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;
using System.Text;

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

    [Function("ListEvents")]
    public static async Task<HttpResponseData> ListEvents(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequestData req,
            ILogger _logger)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request to list events.");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "application/json; charset=utf-8");

        await response.WriteStringAsync(JsonConvert.SerializeObject(events), Encoding.UTF8);

        return response;
    }
}
