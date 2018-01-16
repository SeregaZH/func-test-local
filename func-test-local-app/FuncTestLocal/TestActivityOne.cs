using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FuncTestLocal
{
    public static class TestActivityOne
    {
        [FunctionName("TestActivityOne")]
        public static async Task<string> Run([ActivityTrigger] string name, TraceWriter log)
        {
            return await Task.FromResult($"Hello {name}");
        }
    }
}
