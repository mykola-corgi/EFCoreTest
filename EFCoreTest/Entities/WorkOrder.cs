using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTest.Interfaces;

namespace EFCoreTest.Entities
{
    public class WorkOrder : IWorkOrder
    {
        public string Number { get; set; }
        public string Category { get; set; }
        public string Group { get; set; }
        public string Type { get; set; }
        public string Instruction { get; set; }
        public bool IsCentralHeatingOperational { get; set; }
        public bool IsHotWaterOperational { get; set; }
        public bool IsCallOutChargeable { get; set; }
        public bool IsPartsChargeable { get; set; }
        public bool IsLabourChargeable { get; set; }
        public DateTime DueDate { get; set; }
        public string Name { get; set; }
        public int AppointmentNumber { get; set; }
        //public ICustomer Customer { get; set; }
        //public IContract Contract { get; set; }
        //public IProperty Property { get; set; }
    }
}
