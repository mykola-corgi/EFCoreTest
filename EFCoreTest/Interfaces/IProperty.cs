using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTest.Interfaces
{
    public interface IProperty
    {
        Guid PropertyId { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string AddressLine4 { get; set; }
        string Postcode { get; set; }
        string AccessInformation { get; set; }
        string TenantContactNumber { get; set; }
        string TenantFullName { get; set; }
        string RegionBrand { get; set; }
        string OwnershipType { get; set; }
        //IEnumerable<IAppliance> AppliancesAtProperty { get; set; }
        //IEnumerable<IExclusion> SiteExclusions { get; set; }
    }
}
