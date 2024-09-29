using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class init_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CredentialCardTypes",
                columns: table => new
                {
                    CredentialCardTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CredentialCardTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialCardTypes", x => x.CredentialCardTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcceptLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Gates",
                columns: table => new
                {
                    GateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GateCoordinate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gates", x => x.GateId);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationID);
                });

            migrationBuilder.CreateTable(
                name: "QRCardStatus",
                columns: table => new
                {
                    QRCardStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QRCardStatus", x => x.QRCardStatusId);
                });

            migrationBuilder.CreateTable(
                name: "QRCardType",
                columns: table => new
                {
                    QRCardTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QRCardType", x => x.QRCardTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "VisitTypes",
                columns: table => new
                {
                    VisitTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitTypes", x => x.VisitTypeId);
                });

            migrationBuilder.CreateTable(
                name: "QRCards",
                columns: table => new
                {
                    QRCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardVerification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastCancelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QRCardTypeId = table.Column<int>(type: "int", nullable: false),
                    QRCardStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QRCards", x => x.QRCardId);
                    table.ForeignKey(
                        name: "FK_QRCards_QRCardStatus_QRCardStatusId",
                        column: x => x.QRCardStatusId,
                        principalTable: "QRCardStatus",
                        principalColumn: "QRCardStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QRCards_QRCardType_QRCardTypeId",
                        column: x => x.QRCardTypeId,
                        principalTable: "QRCardType",
                        principalColumn: "QRCardTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationUsers",
                columns: table => new
                {
                    NotificationUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadStatus = table.Column<bool>(type: "bit", nullable: false),
                    NotificationID = table.Column<int>(type: "int", nullable: false),
                    SenderID = table.Column<int>(type: "int", nullable: false),
                    ReceiverID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationUsers", x => x.NotificationUserID);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Notifications_NotificationID",
                        column: x => x.NotificationID,
                        principalTable: "Notifications",
                        principalColumn: "NotificationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Users_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Users_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    ProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    VisitTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.ProcessId);
                    table.ForeignKey(
                        name: "FK_Processes_Users_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processes_VisitTypes_VisitTypeId",
                        column: x => x.VisitTypeId,
                        principalTable: "VisitTypes",
                        principalColumn: "VisitTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDepartments",
                columns: table => new
                {
                    UserDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepartments", x => x.UserDepartmentId);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CredentialsCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CredentialCardTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorId);
                    table.ForeignKey(
                        name: "FK_Visitors_CredentialCardTypes_CredentialCardTypeId",
                        column: x => x.CredentialCardTypeId,
                        principalTable: "CredentialCardTypes",
                        principalColumn: "CredentialCardTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visitors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitQuantity = table.Column<int>(type: "int", nullable: false),
                    AcceptLevel = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateById = table.Column<int>(type: "int", nullable: false),
                    UpdateById = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visits_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                    table.ForeignKey(
                        name: "FK_Visits_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Users_UpdateById",
                        column: x => x.UpdateById,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VisitorDepartment",
                columns: table => new
                {
                    VisitorDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    UserDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorDepartment", x => x.VisitorDepartmentId);
                    table.ForeignKey(
                        name: "FK_VisitorDepartment_UserDepartments_UserDepartmentId",
                        column: x => x.UserDepartmentId,
                        principalTable: "UserDepartments",
                        principalColumn: "UserDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorDepartment_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitDetails",
                columns: table => new
                {
                    VisitDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpectedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ExpectedEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitDetails", x => x.VisitDetailId);
                    table.ForeignKey(
                        name: "FK_VisitDetails_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitDetails_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitProcesses",
                columns: table => new
                {
                    VisitProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpectedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ExpectedEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DaysOfProcess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitQuantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessId = table.Column<int>(type: "int", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitProcesses", x => x.VisitProcessId);
                    table.ForeignKey(
                        name: "FK_VisitProcesses_Processes_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "ProcessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitProcesses_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "VisitId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleSessions",
                columns: table => new
                {
                    VehicleSessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitDetailId = table.Column<int>(type: "int", nullable: false),
                    SecurityID = table.Column<int>(type: "int", nullable: false),
                    GateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleSessions", x => x.VehicleSessionId);
                    table.ForeignKey(
                        name: "FK_VehicleSessions_Gates_GateId",
                        column: x => x.GateId,
                        principalTable: "Gates",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleSessions_Users_SecurityID",
                        column: x => x.SecurityID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleSessions_VisitDetails_VisitDetailId",
                        column: x => x.VisitDetailId,
                        principalTable: "VisitDetails",
                        principalColumn: "VisitDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VisitorSessions",
                columns: table => new
                {
                    VisitorSessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QRCardId = table.Column<int>(type: "int", nullable: false),
                    VisitDetailId = table.Column<int>(type: "int", nullable: false),
                    SecurityInId = table.Column<int>(type: "int", nullable: false),
                    SecurityOutId = table.Column<int>(type: "int", nullable: true),
                    GateInId = table.Column<int>(type: "int", nullable: false),
                    GateOutId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorSessions", x => x.VisitorSessionId);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Gates_GateInId",
                        column: x => x.GateInId,
                        principalTable: "Gates",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Gates_GateOutId",
                        column: x => x.GateOutId,
                        principalTable: "Gates",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_QRCards_QRCardId",
                        column: x => x.QRCardId,
                        principalTable: "QRCards",
                        principalColumn: "QRCardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Users_SecurityInId",
                        column: x => x.SecurityInId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Users_SecurityOutId",
                        column: x => x.SecurityOutId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_VisitDetails_VisitDetailId",
                        column: x => x.VisitDetailId,
                        principalTable: "VisitDetails",
                        principalColumn: "VisitDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleSessionImages",
                columns: table => new
                {
                    VehicleSessionImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleSessionImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleSessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleSessionImages", x => x.VehicleSessionImageId);
                    table.ForeignKey(
                        name: "FK_VehicleSessionImages_VehicleSessions_VehicleSessionId",
                        column: x => x.VehicleSessionId,
                        principalTable: "VehicleSessions",
                        principalColumn: "VehicleSessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorSessionsImages",
                columns: table => new
                {
                    VisitorSessionsImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitorSessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorSessionsImages", x => x.VisitorSessionsImageId);
                    table.ForeignKey(
                        name: "FK_VisitorSessionsImages_VisitorSessions_VisitorSessionId",
                        column: x => x.VisitorSessionId,
                        principalTable: "VisitorSessions",
                        principalColumn: "VisitorSessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CredentialCardTypes",
                columns: new[] { "CredentialCardTypeId", "CredentialCardTypeName" },
                values: new object[,]
                {
                    { 1, "Căn cước công dân" },
                    { 2, "Căn cước công dân" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Chăm sóc khách hàng", "Repellat unde debitis eius cum dicta quae natus.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Kế toán", "Labore minima veniam qui ea aut amet sed deleniti ipsam.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Chăm sóc khách hàng", "Ullam nostrum rerum.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Sản xuất", "Porro magnam adipisci corporis rerum.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Pháp chế", "Doloribus dolor porro fuga quis consequatur cum.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng IT", "Et non tempore sequi.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Kế toán", "Atque assumenda nesciunt id ullam.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Pháp chế", "Eaque et et veniam.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng R&D", "Voluptas ad eum.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Kế toán", "Minus aut mollitia voluptates id error.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Gates",
                columns: new[] { "GateId", "GateCoordinate", "GateName" },
                values: new object[,]
                {
                    { 1, "Ra vào trong ngày", "Cổng 1" },
                    { 2, "Ra vào trong ngày", "Cổng 2" }
                });

            migrationBuilder.InsertData(
                table: "QRCardStatus",
                columns: new[] { "QRCardStatusId", "Description", "StatusName" },
                values: new object[,]
                {
                    { 1, "Thẻ đang được dùng checkin", "Active" },
                    { 2, "Thẻ chưa dùng cho bảo vệ", "Inactive" },
                    { 3, "Thẻ đã hết hạn", "Disable" }
                });

            migrationBuilder.InsertData(
                table: "QRCardType",
                columns: new[] { "QRCardTypeId", "CardTypeName", "TypeDescription" },
                values: new object[,]
                {
                    { 1, "Vehicle", "Vehicle QR Card" },
                    { 2, "Visitor", "Visitor QR Card" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Description", "RoleName" },
                values: new object[,]
                {
                    { 1, "Quản lý toàn bộ hệ thống", "Admin" },
                    { 2, "Quản lý toàn bộ công ty", "Manager" },
                    { 3, "Quản lý toàn bộ phòng ban", "DepartmentManaager" },
                    { 4, "Tạo và quản lý khách ra vào của phòng ban", "Staff" },
                    { 5, "Quản lý khách ra vào tại cổng", "Security" }
                });

            migrationBuilder.InsertData(
                table: "VisitTypes",
                columns: new[] { "VisitTypeId", "Description", "VisitTypeName" },
                values: new object[,]
                {
                    { 1, "Process trong tuần", "ProcessWeek" },
                    { 2, "Process trong tháng", "ProcessMonth" },
                    { 3, "Project", "Project" },
                    { 4, "Visit được tạo bởi staff", "VisitStaff" },
                    { 5, "Visit được tạo bởi security", "VisitSecurity" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1@example.com", "Admin One", "data:image/jpeg;base64,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", "123", "0123456789", 1, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1" },
                    { 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager1@example.com", "Manager One", "data:image/jpeg;base64,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", "123", "0987654321", 2, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager1" },
                    { 3, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "employee1@example.com", "Department Manager One", "data:image/jpeg;base64,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", "123", "0112223334", 3, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "DM1" },
                    { 4, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff1@egmail.com", "Staff One", "data:image/jpeg;base64,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", "123", "0223334445", 4, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff1" },
                    { 5, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff2@gmail.com", "Staff Tow", "data:image/jpeg;base64,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", "123", "0223334446", 4, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff2" },
                    { 6, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "it1@example.com", "Security One", "data:image/jpeg;base64,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", "123", "0334445556", 5, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Security1" }
                });

            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "UserDepartmentId", "DepartmentId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 1, 3 },
                    { 3, 2, 3 },
                    { 4, 2, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_NotificationID",
                table: "NotificationUsers",
                column: "NotificationID");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_ReceiverID",
                table: "NotificationUsers",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_SenderID",
                table: "NotificationUsers",
                column: "SenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_CreateBy",
                table: "Processes",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_VisitTypeId",
                table: "Processes",
                column: "VisitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_QRCards_QRCardStatusId",
                table: "QRCards",
                column: "QRCardStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_QRCards_QRCardTypeId",
                table: "QRCards",
                column: "QRCardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_DepartmentId",
                table: "UserDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_UserId",
                table: "UserDepartments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessionImages_VehicleSessionId",
                table: "VehicleSessionImages",
                column: "VehicleSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_GateId",
                table: "VehicleSessions",
                column: "GateId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_SecurityID",
                table: "VehicleSessions",
                column: "SecurityID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_VisitDetailId",
                table: "VehicleSessions",
                column: "VisitDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitDetails_VisitId",
                table: "VisitDetails",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitDetails_VisitorId",
                table: "VisitDetails",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorDepartment_UserDepartmentId",
                table: "VisitorDepartment",
                column: "UserDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorDepartment_VisitorId",
                table: "VisitorDepartment",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_CredentialCardTypeId",
                table: "Visitors",
                column: "CredentialCardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_UserId",
                table: "Visitors",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_GateInId",
                table: "VisitorSessions",
                column: "GateInId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_GateOutId",
                table: "VisitorSessions",
                column: "GateOutId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_QRCardId",
                table: "VisitorSessions",
                column: "QRCardId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_SecurityInId",
                table: "VisitorSessions",
                column: "SecurityInId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_SecurityOutId",
                table: "VisitorSessions",
                column: "SecurityOutId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_VisitDetailId",
                table: "VisitorSessions",
                column: "VisitDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessionsImages_VisitorSessionId",
                table: "VisitorSessionsImages",
                column: "VisitorSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProcesses_ProcessId",
                table: "VisitProcesses",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProcesses_VisitId",
                table: "VisitProcesses",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_CreateById",
                table: "Visits",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DepartmentId",
                table: "Visits",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_UpdateById",
                table: "Visits",
                column: "UpdateById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationUsers");

            migrationBuilder.DropTable(
                name: "VehicleSessionImages");

            migrationBuilder.DropTable(
                name: "VisitorDepartment");

            migrationBuilder.DropTable(
                name: "VisitorSessionsImages");

            migrationBuilder.DropTable(
                name: "VisitProcesses");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "VehicleSessions");

            migrationBuilder.DropTable(
                name: "UserDepartments");

            migrationBuilder.DropTable(
                name: "VisitorSessions");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Gates");

            migrationBuilder.DropTable(
                name: "QRCards");

            migrationBuilder.DropTable(
                name: "VisitDetails");

            migrationBuilder.DropTable(
                name: "VisitTypes");

            migrationBuilder.DropTable(
                name: "QRCardStatus");

            migrationBuilder.DropTable(
                name: "QRCardType");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "CredentialCardTypes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
