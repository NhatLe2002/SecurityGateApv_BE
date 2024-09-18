using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class init_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Role");

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
                    StatusName = table.Column<int>(type: "int", nullable: false),
                    StatusNumber = table.Column<int>(type: "int", nullable: false)
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
                name: "Reasons",
                columns: table => new
                {
                    ReasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReasonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reasons", x => x.ReasonId);
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
                name: "Visitors",
                columns: table => new
                {
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CredentialsCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
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
                name: "QRCards",
                columns: table => new
                {
                    QRCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardGuidId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastCancelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "DepartmentReasons",
                columns: table => new
                {
                    DepartmentReasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    ReasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentReasons", x => x.DepartmentReasonId);
                    table.ForeignKey(
                        name: "FK_DepartmentReasons_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentReasons_Reasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "Reasons",
                        principalColumn: "ReasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passwork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Users_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "Users",
                        principalColumn: "UserId",
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
                name: "Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitQuantity = table.Column<int>(type: "int", nullable: false),
                    AcceptLevel = table.Column<int>(type: "int", nullable: false),
                    DepartmentReasonId = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<int>(type: "int", nullable: false),
                    UpdateById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visits_DepartmentReasons_DepartmentReasonId",
                        column: x => x.DepartmentReasonId,
                        principalTable: "DepartmentReasons",
                        principalColumn: "DepartmentReasonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
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
                    VisitDetailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedTimeIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedTimeOut = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "VisitProjects",
                columns: table => new
                {
                    VisitProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityOfVisit = table.Column<int>(type: "int", nullable: false),
                    ExpectedTimeIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedTimeOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitProjects", x => x.VisitProjectId);
                    table.ForeignKey(
                        name: "FK_VisitProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitProjects_Visits_VisitId",
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorSessions",
                columns: table => new
                {
                    VisitorSessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRCardId = table.Column<int>(type: "int", nullable: false),
                    VisitDetailId = table.Column<int>(type: "int", nullable: false),
                    SecurityID = table.Column<int>(type: "int", nullable: false),
                    GateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorSessions", x => x.VisitorSessionId);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Gates_GateId",
                        column: x => x.GateId,
                        principalTable: "Gates",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_QRCards_QRCardId",
                        column: x => x.QRCardId,
                        principalTable: "QRCards",
                        principalColumn: "QRCardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_Users_SecurityID",
                        column: x => x.SecurityID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorSessions_VisitDetails_VisitDetailId",
                        column: x => x.VisitDetailId,
                        principalTable: "VisitDetails",
                        principalColumn: "VisitDetailId",
                        onDelete: ReferentialAction.Cascade);
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentReasons_DepartmentId",
                table: "DepartmentReasons",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentReasons_ReasonId",
                table: "DepartmentReasons",
                column: "ReasonId");

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
                name: "IX_Projects_CreateBy",
                table: "Projects",
                column: "CreateBy");

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
                name: "IX_Visitors_CredentialCardTypeId",
                table: "Visitors",
                column: "CredentialCardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_GateId",
                table: "VisitorSessions",
                column: "GateId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_QRCardId",
                table: "VisitorSessions",
                column: "QRCardId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_SecurityID",
                table: "VisitorSessions",
                column: "SecurityID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_VisitDetailId",
                table: "VisitorSessions",
                column: "VisitDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessionsImages_VisitorSessionId",
                table: "VisitorSessionsImages",
                column: "VisitorSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProjects_ProjectId",
                table: "VisitProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProjects_VisitId",
                table: "VisitProjects",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_CreateById",
                table: "Visits",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DepartmentReasonId",
                table: "Visits",
                column: "DepartmentReasonId");

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
                name: "UserDepartments");

            migrationBuilder.DropTable(
                name: "VehicleSessionImages");

            migrationBuilder.DropTable(
                name: "VisitorSessionsImages");

            migrationBuilder.DropTable(
                name: "VisitProjects");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "VehicleSessions");

            migrationBuilder.DropTable(
                name: "VisitorSessions");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Gates");

            migrationBuilder.DropTable(
                name: "QRCards");

            migrationBuilder.DropTable(
                name: "VisitDetails");

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
                name: "DepartmentReasons");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Reasons");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "Description", "RoleName" },
                values: new object[,]
                {
                    { 1, "Quản lý toàn bộ hệ thống", "Admin" },
                    { 2, "Quản lý toàn bộ công ty", "Manager" },
                    { 3, "Quản lý toàn bộ phòng ban", "DepartmentManaager" },
                    { 4, "Tạo và quản lý khách ra vào của phòng ban", "Staff" },
                    { 5, "Quản lý khách ra vào tại cổng", "Security" }
                });
        }
    }
}
