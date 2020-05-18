using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EFCoreTest.Entities;

namespace EFCoreTest.Interfaces
{
    public interface IBulkService
    {
        Task ProcessBulkOrders(IEnumerable<IWorkOrder> orders);
    }
}
