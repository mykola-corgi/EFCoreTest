using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTest.Interfaces;

namespace EFCoreTest.Entities
{
    internal class Exclusion : IExclusion
    {
        public string ExclusionId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string LocationOther { get; set; }
        public string AffectedAppliance { get; set; }
        public string AffectedApplianceOther { get; set; }
        public string ExcludedComponent { get; set; }
        public string ExcludedComponentOther { get; set; }
        public string ExclusionReason { get; set; }
        public string ExclusionReasonOther { get; set; }
    }
}
