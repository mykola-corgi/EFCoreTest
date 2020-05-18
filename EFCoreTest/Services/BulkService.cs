using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EFCoreTest.Entities;
using EFCoreTest.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EFCoreTest.Services
{
    public class BulkService : IBulkService
    {
        private ExternalJobContext _jobContext;
        private ILogger<BulkService> _logger;
        public BulkService(ExternalJobContext jobContext, ILogger<BulkService> logger)
        {
            _jobContext = jobContext;
            _logger = logger;
        }
        public async Task ProcessBulkOrders(IEnumerable<IWorkOrder> orders)
        {
            var failedOrders = new List<IWorkOrder>();
            using (var transaction = _jobContext.Database.BeginTransaction())
            {
                foreach (var order in orders)
                {
                    try
                    {
                        _jobContext.Add((WorkOrder)order);
                        await _jobContext.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex.InnerException?.Message);
                        _jobContext.Remove(order);
                        failedOrders.Add(order);
                    }

                }
                await transaction.CommitAsync();
            }

            foreach (var failedOrder in failedOrders)
            {
                _logger.LogInformation($"Failed order: {JsonConvert.SerializeObject(failedOrder)}");
            }
        }
    }
}
