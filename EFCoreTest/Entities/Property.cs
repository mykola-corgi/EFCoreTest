using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTest.Interfaces;

namespace EFCoreTest.Entities
{
    internal class Property : IProperty
    {
        public Guid PropertyId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Postcode { get; set; }
        public string AccessInformation { get; set; }
        public string TenantContactNumber { get; set; }
        public string TenantFullName { get; set; }
        public string RegionBrand { get; set; }
        public string OwnershipType { get; set; }
        //public IEnumerable<IAppliance> AppliancesAtProperty { get; set; }
        //public IEnumerable<IExclusion> SiteExclusions { get; set; }
    }
}
