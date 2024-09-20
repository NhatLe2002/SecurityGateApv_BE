using Bogus;
using Microsoft.EntityFrameworkCore;
using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedRoles(modelBuilder);
            SeedFixedUsers(modelBuilder);
            SeedRandomUsers(modelBuilder);
            SeedDepartments(modelBuilder); // Seed Departments
            SeedUserDepartments(modelBuilder); // Seed UserDepartments
            SeedReasons(modelBuilder);
            SeedDepartmentReasons(modelBuilder);
            SeedCredentialCardTypes(modelBuilder);
            SeedVisitors(modelBuilder);
            SeedProjects(modelBuilder);
            SeedVisits(modelBuilder);
            SeedVisitDetails(modelBuilder);
            SeedQRCards(modelBuilder);
            SeedGate(modelBuilder);
            SeedVisitorSession(modelBuilder);

        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin", Description = "Quản lý toàn bộ hệ thống" },
                new Role { RoleId = 2, RoleName = "Manager", Description = "Quản lý toàn bộ công ty" },
                new Role { RoleId = 3, RoleName = "DepartmentManaager", Description = "Quản lý toàn bộ phòng ban" },
                new Role { RoleId = 4, RoleName = "Staff", Description = "Tạo và quản lý khách ra vào của phòng ban" },
                new Role { RoleId = 5, RoleName = "Security", Description = "Quản lý khách ra vào tại cổng" }
            );
        }

        private static void SeedFixedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    UserName = "admin1",
                    Password = "123",
                    FullName = "Admin One",
                    Email = "admin1@example.com",
                    PhoneNumber = "0123456789",
                    CreatedDate = DateTime.UtcNow.AddMonths(-6),
                    UpdatedDate = DateTime.UtcNow,
                    Status = "Active",
                    RoleId = 1
                },
                new User
                {
                    UserId = 2,
                    UserName = "manager1",
                    Password = "123",
                    FullName = "Manager One",
                    Email = "manager1@example.com",
                    PhoneNumber = "0987654321",
                    CreatedDate = DateTime.UtcNow.AddMonths(-3),
                    UpdatedDate = DateTime.UtcNow,
                    Status = "Active",
                    RoleId = 2
                },
                new User
                {
                    UserId = 3,
                    UserName = "DM1",
                    Password = "123",
                    FullName = "Department Manager One",
                    Email = "employee1@example.com",
                    PhoneNumber = "0112223334",
                    CreatedDate = DateTime.UtcNow.AddMonths(-2),
                    UpdatedDate = DateTime.UtcNow,
                    Status = "Active",
                    RoleId = 3
                },
                new User
                {
                    UserId = 4,
                    UserName = "Staff1",
                    Password = "123",
                    FullName = "Staff One",
                    Email = "hr1@example.com",
                    PhoneNumber = "0223334445",
                    CreatedDate = DateTime.UtcNow.AddMonths(-1),
                    UpdatedDate = DateTime.UtcNow,
                    Status = "Active",
                    RoleId = 4
                },
                new User
                {
                    UserId = 5,
                    UserName = "Security1",
                    Password = "123",
                    FullName = "Security One",
                    Email = "it1@example.com",
                    PhoneNumber = "0334445556",
                    CreatedDate = DateTime.UtcNow.AddMonths(-4),
                    UpdatedDate = DateTime.UtcNow,
                    Status = "Active",
                    RoleId = 5
                }
            );
        }

        private static void SeedRandomUsers(ModelBuilder modelBuilder)
        {
            var userFaker = new Faker<User>()
                .RuleFor(u => u.UserId, f => f.IndexFaker + 6) 
                .RuleFor(u => u.UserName, f => f.Internet.UserName())
                .RuleFor(u => u.Password, f => f.Random.AlphaNumeric(6)) 
                .RuleFor(u => u.FullName, f => f.Name.FullName())
                .RuleFor(u => u.Email, f => f.Internet.Email("gmail.com")) 
                .RuleFor(u => u.PhoneNumber, f => f.Random.Number(100000000, 999999999).ToString("D10")) 
                .RuleFor(u => u.CreatedDate, f => f.Date.Between(new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1), DateTime.UtcNow)) 
                .RuleFor(u => u.UpdatedDate, (f, u) => u.CreatedDate) 
                .RuleFor(u => u.Status, f => "Active")
                .RuleFor(u => u.RoleId, f => f.Random.Int(1, 5));

            var randomUsers = userFaker.Generate(20);

            modelBuilder.Entity<User>().HasData(randomUsers);
        }
        private static void SeedDepartments(ModelBuilder modelBuilder)
        {
            var departmentNames = new List<string>
            {
                "Phòng Nhân sự",
                "Phòng Kế toán",
                "Phòng IT",
                "Phòng Kinh doanh",
                "Phòng Marketing",
                "Phòng Hành chính",
                "Phòng Chăm sóc khách hàng",
                "Phòng Pháp chế",
                "Phòng R&D",
                "Phòng Sản xuất"
            };

            var departmentFaker = new Faker<Department>()
                .RuleFor(d => d.DepartmentId, f => f.IndexFaker + 1)
                .RuleFor(d => d.DepartmentName, f => f.PickRandom(departmentNames)) 
                .RuleFor(d => d.Description, f => f.Lorem.Sentence())
                .RuleFor(d => d.CreateDate, f => f.Date.Between(DateTime.UtcNow.AddDays(-DateTime.UtcNow.Day + 1), DateTime.UtcNow)) 
                .RuleFor(d => d.UpdatedDate, (f, d) => d.CreateDate) 
                .RuleFor(d => d.AcceptLevel, f => f.Random.Int(1, 5)); 

            var randomDepartments = departmentFaker.Generate(10); 

            modelBuilder.Entity<Department>().HasData(randomDepartments);
        }
        private static void SeedUserDepartments(ModelBuilder modelBuilder)
        {
            // Giả sử có 10 phòng ban và 25 người dùng
            var userDepartmentFaker = new Faker<UserDepartment>()
                .RuleFor(ud => ud.UserDepartmentId, f => f.IndexFaker + 1)
                .RuleFor(ud => ud.DepartmentId, f => f.Random.Int(1, 10)) 
                .RuleFor(ud => ud.UserId, f => f.Random.Int(1, 25)); 

            var randomUserDepartments = userDepartmentFaker.Generate(30); 
            modelBuilder.Entity<UserDepartment>().HasData(randomUserDepartments);
        }
        private static void SeedReasons(ModelBuilder modelBuilder)
        {
            var reasonFaker = new Faker<Reason>()
                .RuleFor(r => r.ReasonId, f => f.IndexFaker + 1) 
                .RuleFor(r => r.ReasonName, f => f.Commerce.ProductName()) 
                .RuleFor(r => r.Description, f => f.Lorem.Sentence()); 

            var randomReasons = reasonFaker.Generate(5); 

            modelBuilder.Entity<Reason>().HasData(randomReasons);
        }
        private static void SeedDepartmentReasons(ModelBuilder modelBuilder)
        {
            var departmentReasonFaker = new Faker<DepartmentReason>()
                .RuleFor(dr => dr.DepartmentReasonId, f => f.IndexFaker + 1) 
                .RuleFor(dr => dr.Name, f => f.Commerce.ProductName()) 
                .RuleFor(dr => dr.Description, f => f.Lorem.Sentence()) 
                .RuleFor(dr => dr.DepartmentId, f => f.Random.Int(1, 10)) 
                .RuleFor(dr => dr.ReasonId, f => f.Random.Int(1, 5)); 

            var randomDepartmentReasons = departmentReasonFaker.Generate(20); 

            modelBuilder.Entity<DepartmentReason>().HasData(randomDepartmentReasons);
        }
        private static void SeedCredentialCardTypes(ModelBuilder modelBuilder)
        {
            var cardTypeFaker = new Faker<CredentialCardType>()
                .RuleFor(c => c.CredentialCardTypeId, f => f.IndexFaker + 1)
                .RuleFor(c => c.CredentialCardTypeName, f => f.PickRandom(new[] { "Căn cước công dân", "Giấy phép lái xe" }));

            var cardTypes = cardTypeFaker.Generate(2);

            modelBuilder.Entity<CredentialCardType>().HasData(cardTypes);
        }

        private static void SeedVisitors(ModelBuilder modelBuilder)
        {
            var visitorFaker = new Faker<Visitor>()
                .RuleFor(v => v.VisitorId, f => f.IndexFaker + 1)
                .RuleFor(v => v.VisitorName, f => f.Name.FullName())
                .RuleFor(v => v.CompanyName, f => f.Company.CompanyName())
                .RuleFor(v => v.PhoneNumber, f => f.Random.Number(100000000, 999999999).ToString("D10"))
                .RuleFor(v => v.CreatedDate, f => f.Date.Between(new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1), DateTime.UtcNow))
                .RuleFor(v => v.UpdatedDate, (f, v) => v.CreatedDate)
                .RuleFor(v => v.CredentialsCard, f => f.Random.AlphaNumeric(10))
                .RuleFor(v => v.Status, f => f.Random.Bool())
                .RuleFor(v => v.CredentialCardTypeId, f => f.PickRandom(1, 2));

            var visitors = visitorFaker.Generate(10);

            modelBuilder.Entity<Visitor>().HasData(visitors);
        }
        private static void SeedProjects(ModelBuilder modelBuilder)
        {
            var projectFaker = new Faker<Project>()
                .RuleFor(p => p.ProjectId, f => f.IndexFaker + 1) 
                .RuleFor(p => p.ProjectName, f => f.Commerce.ProductName()) 
                .RuleFor(p => p.CreateTime, f => f.Date.Between(new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1), DateTime.UtcNow)) 
                .RuleFor(p => p.Status, f => f.Random.Bool()) 
                .RuleFor(p => p.CreateBy, f => 3); 

            var projects = projectFaker.Generate(5); 

            modelBuilder.Entity<Project>().HasData(projects);
        }
        private static void SeedVisits(ModelBuilder modelBuilder)
        {
            var visitFaker = new Faker<Visit>()
                .RuleFor(v => v.VisitId, f => f.IndexFaker + 1)
                .RuleFor(v => v.DateRegister, f => f.Date.Between(new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1), DateTime.UtcNow))
                .RuleFor(v => v.VisitQuantity, f => f.Random.Int(1, 10))
                .RuleFor(v => v.AcceptLevel, f => f.Random.Int(1, 5))
                .RuleFor(v => v.DepartmentReasonId, f => f.Random.Int(1, 5))
                .RuleFor(v => v.CreateById, f => 4)
                .RuleFor(v => v.UpdateById, f => 4);

            var visits = visitFaker.Generate(5);

            modelBuilder.Entity<Visit>().HasData(visits);
        }

        private static void SeedVisitDetails(ModelBuilder modelBuilder)
        {
            var visitDetailFaker = new Faker<VisitDetail>()
                .RuleFor(vd => vd.VisitDetailId, f => f.IndexFaker + 1)
                .RuleFor(vd => vd.VisitDetailName, f => f.Commerce.ProductName())
                .RuleFor(vd => vd.Description, f => f.Lorem.Paragraph())
                .RuleFor(vd => vd.ExpectedTimeIn, f => DateTime.Now) 
                .RuleFor(vd => vd.ExpectedTimeOut, f => DateTime.Now.AddDays(1)) 
                .RuleFor(vd => vd.Status, f => f.Random.Bool())
                .RuleFor(vd => vd.VisitId, f => f.Random.Int(1, 5))
                .RuleFor(vd => vd.VisitorId, f => f.Random.Int(1, 10));

            var visitDetails = visitDetailFaker.Generate(10);

            modelBuilder.Entity<VisitDetail>().HasData(visitDetails);
        }

        private static void SeedQRCards(ModelBuilder modelBuilder)
        {
            // Seed QRCardStatus
            modelBuilder.Entity<QRCardStatus>().HasData(
                new QRCardStatus { QRCardStatusId = 1, StatusName = "Active", StatusNumber = 1 },
                new QRCardStatus { QRCardStatusId = 2, StatusName = "Inactive", StatusNumber = 0 }
            );

            // Seed QRCardType
            modelBuilder.Entity<QRCardType>().HasData(
                new QRCardType { QRCardTypeId = 1, CardTypeName = "Employee", TypeDescription = "Employee QR Card" },
                new QRCardType { QRCardTypeId = 2, CardTypeName = "Visitor", TypeDescription = "Visitor QR Card" }
            );

            var cardFaker = new Faker<QRCard>()
                .RuleFor(q => q.QRCardId, f => f.IndexFaker + 1)
                .RuleFor(q => q.CardGuidId, f => Guid.NewGuid())
                .RuleFor(q => q.CreateDate, f => DateTime.Now)  // CreateDate là hôm nay
                .RuleFor(q => q.LastCancelDate, (f, q) => q.CreateDate.AddMonths(1))  // LastCancelDate là 1 tháng sau CreateDate
                .RuleFor(q => q.QRCardTypeId, f => f.PickRandom(1, 2))  // Random QRCardType
                .RuleFor(q => q.QRCardStatusId, f => f.PickRandom(1, 2));  // Random QRCardStatus


            var randomQRCards = cardFaker.Generate(10);

            // Seed QRCards
            modelBuilder.Entity<QRCard>().HasData(randomQRCards);
        }
        private static void SeedGate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gate>().HasData(
                new Gate { GateId = 1, GateName = "Cổng 1", GateCoordinate = "Ra vào trong ngày" },
                new Gate { GateId = 2, GateName = "Cổng 2", GateCoordinate = "Ra vào trong ngày" }
                );
        }
        private static void SeedVisitorSession(ModelBuilder modelBuilder)
            {
            var visitorSessionFaker = new Faker<VisitorSession>()
                .RuleFor(vs => vs.VisitorSessionId, f => f.IndexFaker + 1)
                .RuleFor(vs => vs.CheckinTime, f => DateTime.UtcNow.AddDays(1))
                .RuleFor(vs => vs.CheckoutTime, f => null)
                .RuleFor(vs => vs.QRCardId, f => f.Random.Int(1, 10))
                .RuleFor(vs => vs.VisitDetailId, f => f.Random.Int(1, 10))
                .RuleFor(vs => vs.SecurityInId, 5)
                .RuleFor(vs => vs.SecurityOutId, f => null)
                .RuleFor(vs => vs.GateInId, f => f.Random.Int(1, 2))
                .RuleFor(vs => vs.GateOutId, f => null)
                .RuleFor(vs => vs.Status, f => "CheckIn");

                var visitorSessions = visitorSessionFaker.Generate(5); 
                modelBuilder.Entity<VisitorSession>().HasData(visitorSessions);
                SeedVisitorSessionImages(modelBuilder, visitorSessions);
            }

        private static void SeedVisitorSessionImages(ModelBuilder modelBuilder, List<VisitorSession> visitorSessions)
        {
            var visitorSessionImages = new List<VisitorSessionsImage>();

            foreach (var session in visitorSessions)
            {
                for (int j = 0; j < 3; j++) // Tạo 3 hình ảnh cho mỗi VisitorSession
                {
                    visitorSessionImages.Add(new VisitorSessionsImage
                    {
                        VisitorSessionsImageId = (session.VisitorSessionId - 1) * 3 + j + 1, // Đảm bảo ID là duy nhất
                        Name = $"Image_{session.VisitorSessionId}_{j + 1}",
                        ImageType = "jpg", // Hoặc bất kỳ loại nào bạn muốn
                        ImageURL = $"https://example.com/images/{session.VisitorSessionId}_{j + 1}.jpg", // Địa chỉ URL hình ảnh
                        VisitorSessionId = session.VisitorSessionId
                    });
                }
            }

            modelBuilder.Entity<VisitorSessionsImage>().HasData(visitorSessionImages);
        }



    }

}
