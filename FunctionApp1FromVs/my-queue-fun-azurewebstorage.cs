using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1FromVs
{
    public class my_queue_fun_azurewebstorage
    {
        [FunctionName("my_queue_fun_azurewebstorage")]
        public void Run([QueueTrigger("myqueue-items-with-webstorage", Connection = "AzureWebJobsStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
