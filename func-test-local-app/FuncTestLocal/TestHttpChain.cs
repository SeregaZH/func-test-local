using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FuncTestLocal
{
    public static class TestHttpChain
    {
        [FunctionName("TestHttpChain")]
        public static async Task<List<string>> Run([OrchestrationTrigger]DurableOrchestrationContext context)
        {
            var output = new List<string>
            {
                await context.CallActivityAsync<string>("TestActivityOne", "one")
            };

            // Fetching the name from the path parameter in the request URL
            return output;
        }
    }
}
