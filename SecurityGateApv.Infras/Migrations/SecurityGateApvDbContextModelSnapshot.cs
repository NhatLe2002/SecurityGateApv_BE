﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecurityGateApv.Infras.DBContext;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    [DbContext(typeof(SecurityGateApvDbContext))]
    partial class SecurityGateApvDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SecurityGateApv.Domain.Models.CredentialCardType", b =>
                {
                    b.Property<int>("CredentialCardTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CredentialCardTypeId"));

                    b.Property<string>("CredentialCardTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CredentialCardTypeId");

                    b.ToTable("CredentialCardTypes");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("AcceptLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.DepartmentReason", b =>
                {
                    b.Property<int>("DepartmentReasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentReasonId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReasonId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentReasonId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ReasonId");

                    b.ToTable("DepartmentReasons");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Gate", b =>
                {
                    b.Property<int>("GateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GateId"));

                    b.Property<string>("GateCoordinate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GateId");

                    b.ToTable("Gates");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReadDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.NotificationUsers", b =>
                {
                    b.Property<int>("NotificationUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationUserID"));

                    b.Property<int>("NotificationID")
                        .HasColumnType("int");

                    b.Property<bool>("ReadStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int>("SenderID")
                        .HasColumnType("int");

                    b.HasKey("NotificationUserID");

                    b.HasIndex("NotificationID");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("NotificationUsers");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<int>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProjectId");

                    b.HasIndex("CreateBy");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.QRCard", b =>
                {
                    b.Property<int>("QRCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QRCardId"));

                    b.Property<Guid>("CardGuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastCancelDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QRCardStatusId")
                        .HasColumnType("int");

                    b.Property<int>("QRCardTypeId")
                        .HasColumnType("int");

                    b.HasKey("QRCardId");

                    b.HasIndex("QRCardStatusId");

                    b.HasIndex("QRCardTypeId");

                    b.ToTable("QRCards");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.QRCardStatus", b =>
                {
                    b.Property<int>("QRCardStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QRCardStatusId"));

                    b.Property<int>("StatusName")
                        .HasColumnType("int");

                    b.Property<int>("StatusNumber")
                        .HasColumnType("int");

                    b.HasKey("QRCardStatusId");

                    b.ToTable("QRCardStatus");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.QRCardType", b =>
                {
                    b.Property<int>("QRCardTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QRCardTypeId"));

                    b.Property<string>("CardTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QRCardTypeId");

                    b.ToTable("QRCardType");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Reason", b =>
                {
                    b.Property<int>("ReasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReasonId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReasonId");

                    b.ToTable("Reasons");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Description = "Quản lý toàn bộ hệ thống",
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            Description = "Quản lý toàn bộ công ty",
                            RoleName = "Manager"
                        },
                        new
                        {
                            RoleId = 3,
                            Description = "Quản lý toàn bộ phòng ban",
                            RoleName = "DepartmentManaager"
                        },
                        new
                        {
                            RoleId = 4,
                            Description = "Tạo và quản lý khách ra vào của phòng ban",
                            RoleName = "Staff"
                        },
                        new
                        {
                            RoleId = 5,
                            Description = "Quản lý khách ra vào tại cổng",
                            RoleName = "Security"
                        });
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passwork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.UserDepartment", b =>
                {
                    b.Property<int>("UserDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDepartmentId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserDepartmentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDepartments");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VehicleSession", b =>
                {
                    b.Property<int>("VehicleSessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleSessionId"));

                    b.Property<DateTime>("CheckinTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GateId")
                        .HasColumnType("int");

                    b.Property<int>("SecurityID")
                        .HasColumnType("int");

                    b.Property<int>("VisitDetailId")
                        .HasColumnType("int");

                    b.HasKey("VehicleSessionId");

                    b.HasIndex("GateId");

                    b.HasIndex("SecurityID");

                    b.HasIndex("VisitDetailId");

                    b.ToTable("VehicleSessions");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VehicleSessionImage", b =>
                {
                    b.Property<int>("VehicleSessionImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleSessionImageId"));

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleSessionId")
                        .HasColumnType("int");

                    b.Property<string>("VehicleSessionImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleSessionImageId");

                    b.HasIndex("VehicleSessionId");

                    b.ToTable("VehicleSessionImages");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitId"));

                    b.Property<int>("AcceptLevel")
                        .HasColumnType("int");

                    b.Property<int>("CreateById")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRegister")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentReasonId")
                        .HasColumnType("int");

                    b.Property<int>("UpdateById")
                        .HasColumnType("int");

                    b.Property<int>("VisitQuantity")
                        .HasColumnType("int");

                    b.HasKey("VisitId");

                    b.HasIndex("CreateById");

                    b.HasIndex("DepartmentReasonId");

                    b.HasIndex("UpdateById");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitDetail", b =>
                {
                    b.Property<int>("VisitDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitDetailId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpectedTimeIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpectedTimeOut")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("VisitDetailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("VisitDetailId");

                    b.HasIndex("VisitId");

                    b.HasIndex("VisitorId");

                    b.ToTable("VisitDetails");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitProject", b =>
                {
                    b.Property<int>("VisitProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitProjectId"));

                    b.Property<DateTime>("ExpectedTimeIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpectedTimeOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOfVisit")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<string>("VisitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("VisitId");

                    b.ToTable("VisitProjects");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Visitor", b =>
                {
                    b.Property<int>("VisitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CredentialCardTypeId")
                        .HasColumnType("int");

                    b.Property<string>("CredentialsCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VisitorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitorId");

                    b.HasIndex("CredentialCardTypeId");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitorSession", b =>
                {
                    b.Property<int>("VisitorSessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorSessionId"));

                    b.Property<DateTime>("CheckinTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GateId")
                        .HasColumnType("int");

                    b.Property<int>("QRCardId")
                        .HasColumnType("int");

                    b.Property<int>("SecurityID")
                        .HasColumnType("int");

                    b.Property<int>("VisitDetailId")
                        .HasColumnType("int");

                    b.HasKey("VisitorSessionId");

                    b.HasIndex("GateId");

                    b.HasIndex("QRCardId");

                    b.HasIndex("SecurityID");

                    b.HasIndex("VisitDetailId");

                    b.ToTable("VisitorSessions");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitorSessionsImage", b =>
                {
                    b.Property<int>("VisitorSessionsImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorSessionsImageId"));

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitorSessionId")
                        .HasColumnType("int");

                    b.HasKey("VisitorSessionsImageId");

                    b.HasIndex("VisitorSessionId");

                    b.ToTable("VisitorSessionsImages");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.DepartmentReason", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Department", "Department")
                        .WithMany("DepartmentReason")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.Reason", "Reason")
                        .WithMany("DepartmentReason")
                        .HasForeignKey("ReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Reason");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.NotificationUsers", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Notification", "Notification")
                        .WithMany("NotificationUsers")
                        .HasForeignKey("NotificationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.User", "Receiver")
                        .WithMany("ReceivedNotifications")
                        .HasForeignKey("ReceiverID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.User", "Sender")
                        .WithMany("SentNotifications")
                        .HasForeignKey("SenderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Notification");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Project", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.User", "User")
                        .WithMany("Project")
                        .HasForeignKey("CreateBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.QRCard", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.QRCardStatus", "QRCardStatus")
                        .WithMany("QRCards")
                        .HasForeignKey("QRCardStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.QRCardType", "QRCardType")
                        .WithMany("QRCards")
                        .HasForeignKey("QRCardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QRCardStatus");

                    b.Navigation("QRCardType");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.User", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.UserDepartment", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Department", "Department")
                        .WithMany("UserDepartment")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.User", "User")
                        .WithMany("UserDepartment")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VehicleSession", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Gate", "Gate")
                        .WithMany("VehicleSession")
                        .HasForeignKey("GateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.User", "Security")
                        .WithMany("VehicleSession")
                        .HasForeignKey("SecurityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.VisitDetail", "VisitDetail")
                        .WithMany("VehicleSession")
                        .HasForeignKey("VisitDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gate");

                    b.Navigation("Security");

                    b.Navigation("VisitDetail");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VehicleSessionImage", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.VehicleSession", "VehicleSession")
                        .WithMany("Images")
                        .HasForeignKey("VehicleSessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleSession");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Visit", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.User", "CreateBy")
                        .WithMany("CreatedVisits")
                        .HasForeignKey("CreateById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.DepartmentReason", "DepartmentReason")
                        .WithMany("Visits")
                        .HasForeignKey("DepartmentReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.User", "UpdateBy")
                        .WithMany("UpdatedVisits")
                        .HasForeignKey("UpdateById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreateBy");

                    b.Navigation("DepartmentReason");

                    b.Navigation("UpdateBy");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitDetail", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Visit", "Visit")
                        .WithMany("VisitDetail")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.Visitor", "Visitor")
                        .WithMany("VisitDetail")
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visit");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitProject", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Project", "Project")
                        .WithMany("VisitProject")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.Visit", "Visit")
                        .WithMany("VisitProject")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Visitor", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.CredentialCardType", "CredentialCardType")
                        .WithMany("Visitor")
                        .HasForeignKey("CredentialCardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CredentialCardType");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitorSession", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.Gate", "Gate")
                        .WithMany("VisitorSession")
                        .HasForeignKey("GateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.QRCard", "QRCard")
                        .WithMany("VisitorSession")
                        .HasForeignKey("QRCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.User", "Security")
                        .WithMany("VisitorSession")
                        .HasForeignKey("SecurityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityGateApv.Domain.Models.VisitDetail", "VisitDetail")
                        .WithMany("VisitorSession")
                        .HasForeignKey("VisitDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gate");

                    b.Navigation("QRCard");

                    b.Navigation("Security");

                    b.Navigation("VisitDetail");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitorSessionsImage", b =>
                {
                    b.HasOne("SecurityGateApv.Domain.Models.VisitorSession", "VisitorSession")
                        .WithMany("Images")
                        .HasForeignKey("VisitorSessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisitorSession");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.CredentialCardType", b =>
                {
                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Department", b =>
                {
                    b.Navigation("DepartmentReason");

                    b.Navigation("UserDepartment");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.DepartmentReason", b =>
                {
                    b.Navigation("Visits");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Gate", b =>
                {
                    b.Navigation("VehicleSession");

                    b.Navigation("VisitorSession");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Notification", b =>
                {
                    b.Navigation("NotificationUsers");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Project", b =>
                {
                    b.Navigation("VisitProject");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.QRCard", b =>
                {
                    b.Navigation("VisitorSession");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.QRCardStatus", b =>
                {
                    b.Navigation("QRCards");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.QRCardType", b =>
                {
                    b.Navigation("QRCards");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Reason", b =>
                {
                    b.Navigation("DepartmentReason");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.User", b =>
                {
                    b.Navigation("CreatedVisits");

                    b.Navigation("Project");

                    b.Navigation("ReceivedNotifications");

                    b.Navigation("SentNotifications");

                    b.Navigation("UpdatedVisits");

                    b.Navigation("UserDepartment");

                    b.Navigation("VehicleSession");

                    b.Navigation("VisitorSession");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VehicleSession", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Visit", b =>
                {
                    b.Navigation("VisitDetail");

                    b.Navigation("VisitProject");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitDetail", b =>
                {
                    b.Navigation("VehicleSession");

                    b.Navigation("VisitorSession");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.Visitor", b =>
                {
                    b.Navigation("VisitDetail");
                });

            modelBuilder.Entity("SecurityGateApv.Domain.Models.VisitorSession", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
