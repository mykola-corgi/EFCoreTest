using System;
using System.Collections.Generic;
using System.Text;
using EFCoreTest.Enums;
using EFCoreTest.Interfaces;

namespace EFCoreTest.Entities
{
    internal class Customer : ICustomer
    {
        public string CustomerId { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Postcode { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string BusinessPhone { get; set; }
        public PreferredPhone PreferredPhone { get; set; }
        public PreferredLetter PreferredLetter { get; set; }
        public string Email { get; set; }
        public bool IsVulnerable { get; set; }
        public string VulnerabilityReason { get; set; }
        public bool VipMarker { get; set; }
        public string SpecialRequirements { get; set; }
        public bool DoNotAllowSms { get; set; }

    }
}
