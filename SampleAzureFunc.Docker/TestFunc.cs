using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using System;

namespace SampleAzureFunc.Docker
{
    public static class TestFunc
    {
        [FunctionName("TestFunc")]
        public static void Run(
            [TimerTrigger("0 */1 * * *")] TimerInfo timeTrigger, 
            TraceWriter log)
        {
            log.Info("Triggered");
        }
    }
}
