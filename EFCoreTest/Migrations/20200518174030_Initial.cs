using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appliances",
                columns: table => new
                {
                    ApplianceId = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ModelQualifier = table.Column<string>(nullable: true),
                    ApplianceLocation = table.Column<string>(nullable: true),
                    OtherApplianceLocation = table.Column<string>(nullable: true),
                    ApplianceType = table.Column<string>(nullable: true),
                    ChimneyType = table.Column<string>(nullable: true),
                    SystemType = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    GasCouncilNumber = table.Column<string>(nullable: true),
                    LandlordAppliance = table.Column<bool>(nullable: false),
                    IsUnderContract = table.Column<bool>(nullable: false),
                    IsStoredInCompartment = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appliances", x => x.ApplianceId);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractId = table.Column<Guid>(nullable: false),
                    ContractNumber = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    LastServicedOn = table.Column<DateTime>(nullable: false),
                    ServiceDueDate = table.Column<DateTime>(nullable: false),
                    BaseProductName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    BusinessPhone = table.Column<string>(nullable: true),
                    PreferredPhone = table.Column<int>(nullable: false),
                    PreferredLetter = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    IsVulnerable = table.Column<bool>(nullable: false),
                    VulnerabilityReason = table.Column<string>(nullable: true),
                    VipMarker = table.Column<bool>(nullable: false),
                    SpecialRequirements = table.Column<string>(nullable: true),
                    DoNotAllowSms = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Exclusions",
                columns: table => new
                {
                    ExclusionId = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    LocationOther = table.Column<string>(nullable: true),
                    AffectedAppliance = table.Column<string>(nullable: true),
                    AffectedApplianceOther = table.Column<string>(nullable: true),
                    ExcludedComponent = table.Column<string>(nullable: true),
                    ExcludedComponentOther = table.Column<string>(nullable: true),
                    ExclusionReason = table.Column<string>(nullable: true),
                    ExclusionReasonOther = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exclusions", x => x.ExclusionId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<Guid>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    AccessInformation = table.Column<string>(nullable: true),
                    TenantContactNumber = table.Column<string>(nullable: true),
                    TenantFullName = table.Column<string>(nullable: true),
                    RegionBrand = table.Column<string>(nullable: true),
                    OwnershipType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    Number = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Instruction = table.Column<string>(nullable: true),
                    IsCentralHeatingOperational = table.Column<bool>(nullable: false),
                    IsHotWaterOperational = table.Column<bool>(nullable: false),
                    IsCallOutChargeable = table.Column<bool>(nullable: false),
                    IsPartsChargeable = table.Column<bool>(nullable: false),
                    IsLabourChargeable = table.Column<bool>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AppointmentNumber = table.Column<int>(nullable: false),
                    ContractId = table.Column<Guid>(nullable: true),
                    PropertyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.Number);
                    table.ForeignKey(
                        name: "FK_WorkOrders_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "ContractId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrders_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_ContractId",
                table: "WorkOrders",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_Name",
                table: "WorkOrders",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_PropertyId",
                table: "WorkOrders",
                column: "PropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appliances");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Exclusions");

            migrationBuilder.DropTable(
                name: "WorkOrders");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
