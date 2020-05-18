using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTest.Enums;

namespace EFCoreTest.Interfaces
{
    public interface ICustomer
    {
        string CustomerId { get; set; }
        string Title { get; set; }
        string FullName { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string AddressLine4 { get; set; }
        string Postcode { get; set; }
        string MobilePhone { get; set; }
        string HomePhone { get; set; }
        string BusinessPhone { get; set; }
        PreferredPhone PreferredPhone { get; set; }
        PreferredLetter PreferredLetter { get; set; }
        string Email { get; set; }
        bool IsVulnerable { get; set; }
        string VulnerabilityReason { get; set; }
        bool VipMarker { get; set; }
        string SpecialRequirements { get; set; }
        bool DoNotAllowSms { get; set; }
    }
}
