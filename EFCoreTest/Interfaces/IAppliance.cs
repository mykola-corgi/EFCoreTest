using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTest.Interfaces
{
    public interface IAppliance
    {
        Guid ApplianceId { get; set; }
        string Status { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string ModelQualifier { get; set; }
        string ApplianceLocation { get; set; }
        string OtherApplianceLocation { get; set; }
        string ApplianceType { get; set; }
        string ChimneyType { get; set; }
        string SystemType { get; set; }
        string SerialNo { get; set; }
        string GasCouncilNumber { get; set; }
        bool LandlordAppliance { get; set; }
        bool IsUnderContract { get; set; }
        bool IsStoredInCompartment { get; set; }
    }
}
