public static class HelloFunction
{
    [FunctionName("HelloFunction")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Processing request...");
        string name = req.Query["name"];
        return new OkObjectResult($"Hello, {name}");
    }
}