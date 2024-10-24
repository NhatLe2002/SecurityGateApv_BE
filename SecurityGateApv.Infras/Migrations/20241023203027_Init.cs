using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    CredentialCardTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                name: "PrivateKeyServices",
                columns: table => new
                {
                    PrivateKeyServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateKeyServices", x => x.PrivateKeyServiceId);
                });

            migrationBuilder.CreateTable(
                name: "QRCardTypes",
                columns: table => new
                {
                    QRCardTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QRCardTypes", x => x.QRCardTypeId);
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
                name: "ScheduleTypes",
                columns: table => new
                {
                    ScheduleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTypes", x => x.ScheduleTypeId);
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
                    VisitorCredentialImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardVerification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastCancelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QRCardTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_QRCardTypes_QRCardTypeId",
                        column: x => x.QRCardTypeId,
                        principalTable: "QRCardTypes",
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
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Users_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysOfSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ScheduleTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleTypes_ScheduleTypeId",
                        column: x => x.ScheduleTypeId,
                        principalTable: "ScheduleTypes",
                        principalColumn: "ScheduleTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadlineTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    AssignToId = table.Column<int>(type: "int", nullable: false),
                    AssignFromId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleUsers_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleUsers_Users_AssignFromId",
                        column: x => x.AssignFromId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScheduleUsers_Users_AssignToId",
                        column: x => x.AssignToId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitQuantity = table.Column<int>(type: "int", nullable: false),
                    ExpectedStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateById = table.Column<int>(type: "int", nullable: false),
                    UpdateById = table.Column<int>(type: "int", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    ResponsiblePersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visits_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visits_Users_ResponsiblePersonId",
                        column: x => x.ResponsiblePersonId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Visits_Users_UpdateById",
                        column: x => x.UpdateById,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VisitDetails",
                columns: table => new
                {
                    VisitDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpectedStartHour = table.Column<TimeSpan>(type: "time", nullable: false),
                    ExpectedEndHour = table.Column<TimeSpan>(type: "time", nullable: false),
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
                    CardId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_VisitorSessions_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Gates_GateInId",
                        column: x => x.GateInId,
                        principalTable: "Gates",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Gates_GateOutId",
                        column: x => x.GateOutId,
                        principalTable: "Gates",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Users_SecurityInId",
                        column: x => x.SecurityInId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "CredentialCardTypeId", "CredentialCardTypeName", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "Giấy phép lái xe", "A magni repellendus saepe voluptates qui non.", true },
                    { 2, "Căn cước công dân", "Delectus dolor totam qui consequatur.", true }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng R&D", "Quia qui quis iure ut labore.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Sản xuất", "Fugit atque placeat numquam aliquid ipsa asperiores omnis velit magnam.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Marketing", "Ad corrupti quidem veritatis quam.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Pháp chế", "Et est corporis velit itaque in iure.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Sản xuất", "Blanditiis vitae qui quaerat eaque debitis accusamus saepe aut.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Kế toán", "Voluptatum numquam nemo fugit sequi expedita.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Sản xuất", "Ut praesentium aut porro voluptas fugiat magni natus voluptatem.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng R&D", "Non quos aliquam tenetur delectus distinctio.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Hành chính", "Unde ea totam harum.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng R&D", "Voluptatibus blanditiis beatae sequi ducimus ut similique minima.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                table: "QRCardTypes",
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
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "DepartmentId", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin1@example.com", "Admin One", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s", "123", "0123456789", 1, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1" },
                    { 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "manager1@example.com", "Manager One", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s", "123", "0987654321", 2, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager1" },
                    { 3, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "employee1@example.com", "Department Manager One", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s", "123", "0112223334", 3, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "DM1" },
                    { 4, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Staff1@egmail.com", "Staff One", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s", "123", "0223334445", 4, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff1" },
                    { 5, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Staff2@gmail.com", "Staff Tow", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s", "123", "0223334446", 4, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staff2" },
                    { 6, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "it1@example.com", "Security One", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s", "123", "0334445556", 5, "Active", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Security1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_QRCardTypeId",
                table: "Cards",
                column: "QRCardTypeId");

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
                name: "IX_Schedules_CreateById",
                table: "Schedules",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleTypeId",
                table: "Schedules",
                column: "ScheduleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleUsers_AssignFromId",
                table: "ScheduleUsers",
                column: "AssignFromId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleUsers_AssignToId",
                table: "ScheduleUsers",
                column: "AssignToId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleUsers_ScheduleId",
                table: "ScheduleUsers",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");

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
                name: "IX_Visitors_CredentialCardTypeId",
                table: "Visitors",
                column: "CredentialCardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_CardId",
                table: "VisitorSessions",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_GateInId",
                table: "VisitorSessions",
                column: "GateInId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_GateOutId",
                table: "VisitorSessions",
                column: "GateOutId");

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
                name: "IX_Visits_CreateById",
                table: "Visits",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ResponsiblePersonId",
                table: "Visits",
                column: "ResponsiblePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ScheduleId",
                table: "Visits",
                column: "ScheduleId");

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
                name: "PrivateKeyServices");

            migrationBuilder.DropTable(
                name: "ScheduleUsers");

            migrationBuilder.DropTable(
                name: "VehicleSessionImages");

            migrationBuilder.DropTable(
                name: "VisitorSessionsImages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "VehicleSessions");

            migrationBuilder.DropTable(
                name: "VisitorSessions");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Gates");

            migrationBuilder.DropTable(
                name: "VisitDetails");

            migrationBuilder.DropTable(
                name: "QRCardTypes");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "CredentialCardTypes");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "ScheduleTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
