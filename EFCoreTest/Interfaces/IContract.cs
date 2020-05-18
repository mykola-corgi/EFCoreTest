using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTest.Interfaces
{
    public interface IContract
    {
        Guid ContractId { get; set; }
        string ContractNumber { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        DateTime LastServicedOn { get; set; }
        DateTime ServiceDueDate { get; set; }
        string BaseProductName { get; set; }
    }
}
