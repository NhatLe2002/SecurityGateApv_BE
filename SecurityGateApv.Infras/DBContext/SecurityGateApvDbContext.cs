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
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationUsers> NotificationUsers { get; set; }
        public DbSet<PrivateKeyService> PrivateKeyServices { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<QRCard> QRCards { get; set; }
        public DbSet<QRCardStatus> QRCardStatus { get; set; }
        public DbSet<QRCardType> QRCardType { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VehicleSessionImage> VehicleSessionImages { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<VisitDetail> VisitDetails { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<VehicleSession> VehicleSessions { get; set; }
        public DbSet<VisitorSession> VisitorSessions { get; set; }
        public DbSet<VisitorSessionsImage> VisitorSessionsImages { get; set; }
        public DbSet<ScheduleType> ScheduleTypes { get; set; }

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
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Visit>()
                .HasOne(v => v.UpdateBy)
                .WithMany(u => u.UpdatedVisits)
                .HasForeignKey(v => v.UpdateById)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Schedule>()
                .HasOne(v => v.CreateBy)
                .WithMany(u => u.ScheduleCreate)
                .HasForeignKey(v => v.CreateById)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Schedule>()
                .HasOne(v => v.AssignTo)
                .WithMany(u => u.ScheduleAssignTo)
                .HasForeignKey(v => v.AssignToId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<VisitorSession>()
                .HasOne(vs => vs.SecurityIn)
                .WithMany(g => g.SecurityInSessions) 
                .HasForeignKey(vs => vs.SecurityInId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<VisitorSession>()
                .HasOne(vs => vs.SecurityOut)
                .WithMany(g => g.SecurityOutSessions) 
                .HasForeignKey(vs => vs.SecurityOutId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VisitorSession>()
                .HasOne(vs => vs.GateIn)
                .WithMany(g => g.VisitorSessionsIn) 
                .HasForeignKey(vs => vs.GateInId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<VisitorSession>()
                .HasOne(vs => vs.GateOut)
                .WithMany(g => g.VisitorSessionsOut) 
                .HasForeignKey(vs => vs.GateOutId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VisitorSession>()
               .HasOne(v => v.VisitDetail)
               .WithMany(v => v.VisitorSession)
               .HasForeignKey(v => v.VisitDetailId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VehicleSession>()
               .HasOne(v => v.VisitDetail)
               .WithMany(v => v.VehicleSession)
               .HasForeignKey(v => v.VisitDetailId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Seed();
        }
    }
}
