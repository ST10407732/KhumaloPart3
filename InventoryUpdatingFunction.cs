using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace KhumaloCraftKCfunctions
{
    public class InventoryUpdatingFunction
    
        {
        [FunctionName("UpdateInventory")]
        public static async Task UpdateInventory([Microsoft.Azure.WebJobs.Extensions.DurableTask.ActivityTrigger] OrderDetails orderDetails, ILogger log)
        {
            log.LogInformation($"Updating inventory for order {orderDetails.OrderId}.");
         
        }
    }
}
