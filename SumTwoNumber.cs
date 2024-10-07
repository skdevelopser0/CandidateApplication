using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace fnSum
{
    public static class SumTwoNumber
    {
        [FunctionName("SumTwoNumber")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function SumTwoNumber processed a request.");

            string num1 = req.Query["x"];
            string num2 = req.Query["y"];

            var result = int.Parse(num1) + int.Parse(num2);


            return new OkObjectResult(result);
        }
    }
}
