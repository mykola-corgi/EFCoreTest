using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EFCoreTest.Entities;

namespace EFCoreTest.Interfaces
{
    public interface  IWorkOrderRepository
    {
        Task Insert(WorkOrder workOrder);
    }
}
