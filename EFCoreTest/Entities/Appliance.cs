using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTest.Interfaces;

namespace EFCoreTest.Entities
{
    internal class Appliance : IAppliance
    {
        public Guid ApplianceId { get; set; }
        public string Status { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ModelQualifier { get; set; }
        public string ApplianceLocation { get; set; }
        public string OtherApplianceLocation { get; set; }
        public string ApplianceType { get; set; }
        public string ChimneyType { get; set; }
        public string SystemType { get; set; }
        public string SerialNo { get; set; }
        public string GasCouncilNumber { get; set; }
        public bool LandlordAppliance { get; set; }
        public bool IsUnderContract { get; set; }
        public bool IsStoredInCompartment { get; set; }
    }
}
