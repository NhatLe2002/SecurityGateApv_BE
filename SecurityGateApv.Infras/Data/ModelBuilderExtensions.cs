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
            SeedDepartments(modelBuilder);
            SeedUserDepartments(modelBuilder);
            SeedCredentialCardTypes(modelBuilder);
            SeedVisitors(modelBuilder);
            SeedVisitType(modelBuilder);
            SeedProcess(modelBuilder);
            SeedVisits(modelBuilder);
            //SeedVisitDetails(modelBuilder);
            SeedQRCards(modelBuilder);
            SeedGate(modelBuilder);
            //SeedVisitorSession(modelBuilder);

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
                 User.Create(1, "admin1", "123", "Admin One", "admin1@example.com", "0123456789",
                "data:image/jpeg;base64,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",
                 DateTime.UtcNow.AddMonths(-6),
                     DateTime.UtcNow,
                    "Active",
                   1
                ).Value,


                User.Create(
                
                     2,
                     "manager1",
                    "123",
                    "Manager One",
                    "manager1@example.com",
                    "0987654321",
                    "data:image/jpeg;base64,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",
                    DateTime.UtcNow.AddMonths(-3),
                    DateTime.UtcNow,
                    "Active",
                    2
                ).Value,
                User.Create(
                    3,
                    "DM1",
                    "123",
                    "Department Manager One",
                    "employee1@example.com",
                    "0112223334",
                    "data:image/jpeg;base64,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",
                    DateTime.UtcNow.AddMonths(-2),
                    DateTime.UtcNow,
                    "Active",
                     3
                ).Value,
                User.Create(
                     4,
                    "Staff1",
                    "123",
                    "Staff One",
                    "hr1@example.com",
                    "0223334445",
                    "data:image/jpeg;base64,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",
                    DateTime.UtcNow.AddMonths(-1),
                    DateTime.UtcNow,
                    "Active",
                     4
                ).Value,
               User.Create(
                    5,
                    "Security1",
                    "123",
                    "Security One",
                    "it1@example.com",
                    "0334445556",
                    "data:image/jpeg;base64,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",
                    DateTime.UtcNow.AddMonths(-4),
                    DateTime.UtcNow,
                    "Active",
                     5
                ).Value
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
            modelBuilder.Entity<UserDepartment>().HasData(
                new UserDepartment { UserDepartmentId = 1, DepartmentId = 1, UserId = 3 },
                new UserDepartment { UserDepartmentId = 2, DepartmentId = 1, UserId = 4 },
                new UserDepartment { UserDepartmentId = 3, DepartmentId = 2, UserId = 3 }
                );
            // Giả sử có 10 phòng ban và 25 người dùng
            var userDepartmentFaker = new Faker<UserDepartment>()
                .RuleFor(ud => ud.UserDepartmentId, f => f.IndexFaker + 4)
                .RuleFor(ud => ud.DepartmentId, f => f.Random.Int(1, 10))
                .RuleFor(ud => ud.UserId, f => f.Random.Int(6, 25));

            var randomUserDepartments = userDepartmentFaker.Generate(20);
            modelBuilder.Entity<UserDepartment>().HasData(randomUserDepartments);
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
                .RuleFor(v => v.UserId, f => null)
                .RuleFor(v => v.CredentialCardTypeId, f => f.PickRandom(1, 2))
                .RuleFor(v => v.CreateById, f => 1);

            var visitors = visitorFaker.Generate(10);

            modelBuilder.Entity<Visitor>().HasData(visitors);
        }
        private static void SeedVisitType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VisitType>().HasData(
                new VisitType { VisitTypeId = 1, VisitTypeName = "ProcessWeek", Description = "Process trong tuần" },
                new VisitType { VisitTypeId = 2, VisitTypeName = "ProcessMonth", Description = "Process trong tháng" },
                new VisitType { VisitTypeId = 3, VisitTypeName = "Project", Description = "Project" },
                new VisitType { VisitTypeId = 4, VisitTypeName = "VisitStaff", Description = "Visit được tạo bởi staff" },
                new VisitType { VisitTypeId = 5, VisitTypeName = "VisitSecurity", Description = "Visit được tạo bởi security" }
            );
        }
        private static void SeedProcess(ModelBuilder modelBuilder)
        {
            var ProcessFaker = new Faker<Process>()
             .RuleFor(p => p.ProcessId, f => f.IndexFaker + 1)
             .RuleFor(p => p.ProcessName, f => f.Commerce.ProductName())
             .RuleFor(p => p.CreateTime, f => DateTime.UtcNow.AddDays(-2))
             .RuleFor(p => p.Description, f => "")
             .RuleFor(p => p.Status, f => f.Random.Bool())
             .RuleFor(p => p.CreateBy, f => 3)
             .RuleFor(p => p.VisitTypeId, f => 1);

            var processes = ProcessFaker.Generate(5);

            modelBuilder.Entity<Process>().HasData(processes);

            var visitFaker = new Faker<Visit>()
                .RuleFor(v => v.VisitId, f => f.IndexFaker + 1)
                .RuleFor(v => v.DateRegister, f => DateTime.Now.AddDays(-2))
                .RuleFor(v => v.VisitName, f => "Dọn vệ sinh")
                .RuleFor(v => v.VisitQuantity, f => 2)
                .RuleFor(v => v.AcceptLevel, f => 1)
                .RuleFor(v => v.Description, f => null)
                .RuleFor(v => v.VisitType, f => "ProcessWeek")
                .RuleFor(v => v.CreateById, f => 3)
                .RuleFor(v => v.UpdateById, f => 4);

            var visits = visitFaker.Generate(1);
            modelBuilder.Entity<Visit>().HasData(visits);


            var visitProcessFaker = new Faker<VisitProcess>()
                .RuleFor(v => v.VisitProcessId, f => f.IndexFaker + 1)
                .RuleFor(v => v.ExpectedStartDate, f => DateTime.Now.AddDays(-1))
                .RuleFor(v => v.ExpectedEndDate, f => DateTime.Now.AddDays(29))
                .RuleFor(v => v.ExpectedStartTime, f => TimeSpan.FromHours(7))
                .RuleFor(v => v.ExpectedEndTime, f => TimeSpan.FromHours(12))
                .RuleFor(v => v.DaysOfProcess, f => "Monday")
                .RuleFor(v => v.VisitQuantity, f => 2)
                .RuleFor(v => v.Status, f => "Processing")
                .RuleFor(v => v.ProcessId, f => 1)
                .RuleFor(v => v.VisitId, f => 1);

            var visitProcess = visitProcessFaker.Generate(1);
            modelBuilder.Entity<VisitProcess>().HasData(visitProcess);


            var visitDetailFaker = new Faker<VisitDetail>()
               .RuleFor(vd => vd.VisitDetailId, f => f.IndexFaker + 1)
               .RuleFor(vd => vd.ExpectedStartDate, f => DateTime.Now.AddDays(-1))
               .RuleFor(vd => vd.ExpectedEndDate, f => DateTime.Now.AddDays(29))
               .RuleFor(vd => vd.ExpectedStartTime, f => TimeSpan.FromHours(7))
               .RuleFor(vd => vd.ExpectedEndTime, f => TimeSpan.FromHours(12))
               .RuleFor(vd => vd.Description, f => f.Lorem.Paragraph())
               .RuleFor(vd => vd.Status, f => true)
               .RuleFor(vd => vd.VisitId, f => 1)
               .RuleFor(vd => vd.VisitorId, f => f.Random.Int(1, 2));

            var visitDetails = visitDetailFaker.Generate(2);

            modelBuilder.Entity<VisitDetail>().HasData(visitDetails);

        }
        private static void SeedVisits(ModelBuilder modelBuilder)
        {
            var visitFaker = new Faker<Visit>()
                .RuleFor(v => v.VisitId, f => f.IndexFaker + 2)
                .RuleFor(v => v.DateRegister, f => DateTime.UtcNow)
                .RuleFor(v => v.VisitName, f => "Dọn vệ sinh")
                .RuleFor(v => v.VisitQuantity, f => 2)
                .RuleFor(v => v.AcceptLevel, f => 2)
                .RuleFor(v => v.Description, f => null)
                .RuleFor(v => v.VisitType, f => "ProcessWeek")
                .RuleFor(v => v.CreateById, f => 4)
                .RuleFor(v => v.UpdateById, f => 4);
            var visits = visitFaker.Generate(5);
            modelBuilder.Entity<Visit>().HasData(visits);



            int visitDetailCounter = 3;
            foreach (var v in visits)
            {
                for (var v2 = 0; v2 <= v.VisitQuantity; v2++)
                {

                    var visitDetailFaker = new Faker<VisitDetail>()
                      .RuleFor(vd => vd.VisitDetailId, f => visitDetailCounter++)
                      .RuleFor(vd => vd.Description, f => f.Lorem.Paragraph())
                      .RuleFor(vd => vd.ExpectedStartDate, f => DateTime.Now)
                      .RuleFor(vd => vd.ExpectedEndDate, f => DateTime.Now.AddDays(1))
                      .RuleFor(vd => vd.ExpectedStartTime, f => TimeSpan.FromHours(7))
                      .RuleFor(vd => vd.ExpectedEndTime, f => TimeSpan.FromHours(12))
                      .RuleFor(vd => vd.Status, f => true)
                      .RuleFor(vd => vd.VisitId, f => v.VisitId)
                      .RuleFor(vd => vd.VisitorId, f => f.Random.Int(1, 10));

                    var visitDetails = visitDetailFaker.Generate(v.VisitQuantity);

                    modelBuilder.Entity<VisitDetail>().HasData(visitDetails);
                }
            }

        }

        private static void SeedVisitDetails(ModelBuilder modelBuilder)
        {

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
