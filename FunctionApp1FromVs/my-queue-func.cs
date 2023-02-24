using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1FromVs
{
    public class my_queue_func
    {
        [FunctionName("my_queue_func")]
        public void Run(
            [QueueTrigger("myqueue-items", Connection = "QueueStorage")]string myQueueItem,
            [Queue("myqueue-items-destination", Connection = "QueueStorage")] out string myQueueItemCopy, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            myQueueItemCopy = myQueueItem;
        }
    }
}
