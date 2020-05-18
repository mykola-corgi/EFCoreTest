using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTest.Interfaces
{
    public interface IWorkOrder
    {
        string Number { get; set; }
        string Category { get; set; }
        string Group { get; set; }
        string Type { get; set; }
        string Instruction { get; set; }
        bool IsCentralHeatingOperational { get; set; }
        bool IsHotWaterOperational { get; set; }
        bool IsCallOutChargeable { get; set; }
        bool IsPartsChargeable { get; set; }
        bool IsLabourChargeable { get; set; }
        DateTime DueDate { get; set; }
        string Name { get; set; }
        int AppointmentNumber { get; set; }
        //ICustomer Customer { get; set; }
        //IContract Contract { get; set; }
        //IProperty Property { get; set; }
    }
}
