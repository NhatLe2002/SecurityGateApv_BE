using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class UserDepartment
    {
        internal UserDepartment(int userDepartmentId, int departmentId, int userId)
        {
            UserDepartmentId = userDepartmentId;
            DepartmentId = departmentId;
            UserId = userId;
        }

        [Key]
        public int UserDepartmentId { get; private set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; private set; }
        public Department Department { get; private set; }


        [ForeignKey("User")]
        public int UserId { get; private set; }
        public User User { get; private set; }

        public ICollection<VisitorDepartment> VisitorDepartments { get; set; }

        public static Result<UserDepartment> Create(int userDeparmentId, int departmentId, int userId)
        {
            var result = new UserDepartment(userDeparmentId, departmentId, userId);
            return result;
        }
    }
}
