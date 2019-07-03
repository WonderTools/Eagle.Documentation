using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WonderTools.Eagle.Http.NUnit;
using Tests;

namespace EagleAzureFunctionNUnitHttp
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "api/tests/execute")] HttpRequest req,
            ILogger log)
        {
            return await req.HandleRequest(typeof(SampleTests));
        }
    }
}
