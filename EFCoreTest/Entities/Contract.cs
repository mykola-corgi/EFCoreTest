using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTest.Interfaces;

namespace EFCoreTest.Entities
{
    internal class Contract : IContract
    {
        public Guid ContractId { get; set; }
        public string ContractNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime LastServicedOn { get; set; }
        public DateTime ServiceDueDate { get; set; }
        public string BaseProductName { get; set; }
    }
}
