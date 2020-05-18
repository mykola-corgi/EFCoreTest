using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTest.Interfaces
{
    public interface IExclusion
    {
        string ExclusionId { get; set; }
        string Status { get; set; }
        string Location { get; set; }
        string LocationOther { get; set; }
        string AffectedAppliance { get; set; }
        string AffectedApplianceOther { get; set; }
        string ExcludedComponent { get; set; }
        string ExcludedComponentOther { get; set; }
        string ExclusionReason { get; set; }
        string ExclusionReasonOther { get; set; }
    }
}
