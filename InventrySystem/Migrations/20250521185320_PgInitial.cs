using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventrySystem.Migrations
{
    /// <inheritdoc />
    public partial class PgInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    EmployeeNumber = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    GeneratedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ContactInfo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SerialNumber = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    BrandId = table.Column<Guid>(type: "uuid", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsFaulty = table.Column<bool>(type: "boolean", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devices_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devices_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeviceAssignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: true),
                    OfficeId = table.Column<Guid>(type: "uuid", nullable: true),
                    AssignedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceAssignments_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceAssignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeviceAssignments_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uuid", nullable: false),
                    ScheduledDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceSchedules_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PerformedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceHistories_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DateCreated", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a670f0d-a08f-4bba-b1fd-9b6df6e42d70", null, new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "USER" },
                    { "cfa9978f-2afd-4786-9cf9-97b4493f4d34", null, new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a2bd32c0-d75e-4966-8274-758e273da3fb", 0, "aa9e3ddf-7d32-4ea1-8dd0-0a51e4ae1f95", "user@example.com", true, "John", "Doe", false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMNzCDbm92cUHUgBOjdAhiavBi26JHtiFK9Y+GvV97nuVp5UbJDq8u1dfY/Vxl4zHA==", null, false, "", false, "user@example.com" },
                    { "d7930984-3648-45c8-b33e-7b902e1166b4", 0, "28fbcaf3-1351-4234-8d29-f1c7e0190357", "user2@example.com", true, "John2", "Doe2", false, null, "USER2@EXAMPLE.COM", "USER2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFZXT3Smqn7eMSqrc+iJVVwjZDBryqcp3vpcQSJGMybtuhlkeCZgMS/LPasySbOK1A==", null, false, "", false, "user2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14c1b3fb-57d0-48f5-aa4a-130a1ab629c0"), "Dell" },
                    { new Guid("302a431a-2f54-4768-8a34-b6414f3909df"), "Samsung" },
                    { new Guid("89491906-e1e3-4d90-b8da-7363d1d92518"), "Lenovo" },
                    { new Guid("f10323d3-da72-44e7-ae7d-0379da31b329"), "Apple" },
                    { new Guid("ffb0451c-5f0b-457d-a513-e308e9b87326"), "HP" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("42a2b158-1964-47da-8c4e-31a249aa1b3a"), "Printers" },
                    { new Guid("9aa0f4cd-de28-4d3c-b38b-586819845ba3"), "Laptops" },
                    { new Guid("afc1bef3-e71d-4bd8-9bb2-c838c40e9ee0"), "Desktops" },
                    { new Guid("f8f32941-7bad-471e-9d15-07b0ed660516"), "Mobile Phone" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "EmployeeNumber", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { new Guid("057fabeb-23cb-4828-b262-874b958253a6"), "alice.johnson@example.com", "EMP003", "Alice", "Johnson", "HR Coordinator" },
                    { new Guid("b90f27aa-7d93-4d22-bda0-c81e6f5b2121"), "jane.smith@example.com", "EMP002", "Jane", "Smith", "Project Manager" },
                    { new Guid("c5ee8a06-f67d-4ab9-8e4f-54d4b9351455"), "john.doe@example.com", "EMP001", "John", "Doe", "Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("528803ca-bee7-4b5e-931c-c09ec547a274"), "Building 1, Floor 2", "Office A" },
                    { new Guid("970afde9-26ba-4df7-9fef-0050e66ec6e6"), "Building 3, Floor 3", "Office C" },
                    { new Guid("f17c9156-16db-4e0a-834c-8c010d56b722"), "Building 2, Floor 1", "Office B" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "ContactInfo", "Name" },
                values: new object[,]
                {
                    { new Guid("029e2d94-fd9d-41bd-9b4a-58b2f738c662"), "Contact info for Omega IT", "Omega IT Eswatini" },
                    { new Guid("3fff2d50-83f4-4128-a5dd-bb74f0d754e8"), "Contact info for CompuParts", "CompuParts Eswatini" },
                    { new Guid("ec98376a-b287-458c-96b8-18aef57eb9f0"), "Contact info for DataNet", "DataNet Eswatini" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cfa9978f-2afd-4786-9cf9-97b4493f4d34", "a2bd32c0-d75e-4966-8274-758e273da3fb" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "BrandId", "CategoryId", "IsAvailable", "IsFaulty", "Name", "SerialNumber", "SupplierId" },
                values: new object[,]
                {
                    { new Guid("0cf54638-2678-4684-9ed0-0937a9fd7578"), new Guid("302a431a-2f54-4768-8a34-b6414f3909df"), new Guid("f8f32941-7bad-471e-9d15-07b0ed660516"), true, false, "Mobile Phone M1", "SN789012", new Guid("3fff2d50-83f4-4128-a5dd-bb74f0d754e8") },
                    { new Guid("0f3d6050-d5cf-4d46-b89e-7f90d5213423"), new Guid("302a431a-2f54-4768-8a34-b6414f3909df"), new Guid("f8f32941-7bad-471e-9d15-07b0ed660516"), true, false, "Mobile Phone M2", "SN456789", new Guid("3fff2d50-83f4-4128-a5dd-bb74f0d754e8") },
                    { new Guid("16bef877-af10-4f93-af42-0864cea7d394"), new Guid("89491906-e1e3-4d90-b8da-7363d1d92518"), new Guid("afc1bef3-e71d-4bd8-9bb2-c838c40e9ee0"), true, false, "Desktop Y3", "SN112233", new Guid("ec98376a-b287-458c-96b8-18aef57eb9f0") },
                    { new Guid("231dbb8e-da9c-4243-a5f4-d1e170420a92"), new Guid("ffb0451c-5f0b-457d-a513-e308e9b87326"), new Guid("42a2b158-1964-47da-8c4e-31a249aa1b3a"), true, false, "Printer Z2", "SN456789", new Guid("3fff2d50-83f4-4128-a5dd-bb74f0d754e8") },
                    { new Guid("36e29417-85d2-4a4d-b090-81bfb1ae9742"), new Guid("f10323d3-da72-44e7-ae7d-0379da31b329"), new Guid("9aa0f4cd-de28-4d3c-b38b-586819845ba3"), true, false, "Laptop X2", "SN789012", new Guid("029e2d94-fd9d-41bd-9b4a-58b2f738c662") },
                    { new Guid("3960e987-01f3-4bc8-82bf-4c28056022e8"), new Guid("89491906-e1e3-4d90-b8da-7363d1d92518"), new Guid("afc1bef3-e71d-4bd8-9bb2-c838c40e9ee0"), true, false, "Desktop Y1", "SN246810", new Guid("ec98376a-b287-458c-96b8-18aef57eb9f0") },
                    { new Guid("4d404b82-55c4-4e68-9cb0-98e3fbcfc842"), new Guid("f10323d3-da72-44e7-ae7d-0379da31b329"), new Guid("f8f32941-7bad-471e-9d15-07b0ed660516"), true, false, "Mobile Phone M3", "SN135790", new Guid("3fff2d50-83f4-4128-a5dd-bb74f0d754e8") },
                    { new Guid("8ce1291e-2078-4e8b-aa62-014e9f630d2e"), new Guid("89491906-e1e3-4d90-b8da-7363d1d92518"), new Guid("afc1bef3-e71d-4bd8-9bb2-c838c40e9ee0"), true, false, "Desktop Y2", "SN567890", new Guid("ec98376a-b287-458c-96b8-18aef57eb9f0") },
                    { new Guid("8e518623-6270-48f2-bdf4-32c9f736e81a"), new Guid("f10323d3-da72-44e7-ae7d-0379da31b329"), new Guid("9aa0f4cd-de28-4d3c-b38b-586819845ba3"), true, false, "Laptop X3", "SN345678", new Guid("029e2d94-fd9d-41bd-9b4a-58b2f738c662") },
                    { new Guid("f7698c98-21c1-4ec1-9e9a-9d63796826dc"), new Guid("ffb0451c-5f0b-457d-a513-e308e9b87326"), new Guid("42a2b158-1964-47da-8c4e-31a249aa1b3a"), true, false, "Printer Z3", "SN135790", new Guid("3fff2d50-83f4-4128-a5dd-bb74f0d754e8") },
                    { new Guid("f94b2674-4c79-4a0b-b4b0-1d64d73d7b11"), new Guid("f10323d3-da72-44e7-ae7d-0379da31b329"), new Guid("9aa0f4cd-de28-4d3c-b38b-586819845ba3"), true, false, "Laptop X1", "SN123456", new Guid("029e2d94-fd9d-41bd-9b4a-58b2f738c662") },
                    { new Guid("fc4e276a-17cf-4604-8f63-9f6de9c1f77b"), new Guid("ffb0451c-5f0b-457d-a513-e308e9b87326"), new Guid("42a2b158-1964-47da-8c4e-31a249aa1b3a"), true, false, "Printer Z1", "SN987654", new Guid("3fff2d50-83f4-4128-a5dd-bb74f0d754e8") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceAssignments_DeviceId",
                table: "DeviceAssignments",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceAssignments_EmployeeId",
                table: "DeviceAssignments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceAssignments_OfficeId",
                table: "DeviceAssignments",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_BrandId",
                table: "Devices",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_CategoryId",
                table: "Devices",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_SupplierId",
                table: "Devices",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceSchedules_DeviceId",
                table: "MaintenanceSchedules",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHistories_DeviceId",
                table: "ServiceHistories",
                column: "DeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceAssignments");

            migrationBuilder.DropTable(
                name: "MaintenanceSchedules");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "ServiceHistories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
