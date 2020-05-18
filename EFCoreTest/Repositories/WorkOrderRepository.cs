using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EFCoreTest.Entities;
using EFCoreTest.Interfaces;

namespace EFCoreTest.Repositories
{
    internal class WorkOrderRepository : IWorkOrderRepository
    {
        private ExternalJobContext _jobContext;

        public WorkOrderRepository(ExternalJobContext jobContext)
        {
            _jobContext = jobContext;
        }
        public async Task Insert(WorkOrder workOrder)
        {
            await _jobContext.AddAsync(workOrder);
        }
    }
}
