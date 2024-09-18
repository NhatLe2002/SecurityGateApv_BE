using SecurityGateApv.Infras.Data;
using SecurityGateApv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.DBContext
{
    public class SecurityGateApvDbContext : DbContext
    {
        public SecurityGateApvDbContext()
        {

        }
        public SecurityGateApvDbContext(DbContextOptions<SecurityGateApvDbContext> options) : base(options)
        {

        }
        public DbSet<CredentialCardType> CredentialCardTypes { get; set; }
        public DbSet<DepartmentReason> DepartmentReasons { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationUsers> NotificationUsers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<QRCard> QRCards { get; set; }
        public DbSet<QRCardStatus> QRCardStatus { get; set; }
        public DbSet<QRCardType> QRCardType { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDepartment> UserDepartments { get; set; }
        public DbSet<VehicleSessionImage> VehicleSessionImages { get; set; }
        public DbSet<VehicleSession> VehicleSessions { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<VisitDetail> VisitDetails { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<VisitorSession> VisitorSessions { get; set; }
        public DbSet<VisitorSessionsImage> VisitorSessionsImages { get; set; }
        public DbSet<VisitProject> VisitProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            IConfigurationRoot configurationRoot = builder.Build();
            optionsBuilder.UseSqlServer("Server=nmh1223.myvnc.com;Uid=sa;Pwd=Password789;Database=SecurityGateApv;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NotificationUsers>()
                .HasOne(n => n.Sender)
                .WithMany(u => u.SentNotifications)
                .HasForeignKey(n => n.SenderID)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<NotificationUsers>()
                .HasOne(n => n.Receiver)
                .WithMany(u => u.ReceivedNotifications)
                .HasForeignKey(n => n.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Visit>()
                .HasOne(v => v.CreateBy)
                .WithMany(u => u.CreatedVisits)
                .HasForeignKey(v => v.CreateById)
                .OnDelete(DeleteBehavior.Restrict); // Hoặc tùy chọn theo yêu cầu

            modelBuilder.Entity<Visit>()
                .HasOne(v => v.UpdateBy)
                .WithMany(u => u.UpdatedVisits)
                .HasForeignKey(v => v.UpdateById)
                .OnDelete(DeleteBehavior.Restrict); // Hoặc tùy chọn theo yêu cầu


            // Seed data for Roles
            modelBuilder.Entity<Role>().HasData(SeedData.GetRoles().ToArray());

            // Seed data for Users
            //modelBuilder.Entity<User>().HasData(SeedData.GetUsers().ToArray());

            // Seed data for Department
            //modelBuilder.Entity<Departments>().HasData(SeedData.GetDepartments().ToArray());

            // Seed data for Visits
            // modelBuilder.Entity<Visit>().HasData(SeedData.GetVisits().ToArray());


            // Seed data for VisitDetails
            // modelBuilder.Entity<VisitDetails>().HasData(SeedData.GetVisitDetails().ToArray());
        }
    }
}
