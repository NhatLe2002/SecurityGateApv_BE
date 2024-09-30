using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Department
    {
        public Department()
        {
            
        }
        internal Department(string departmentName, string description, 
            DateTime createDate, DateTime updatedDate, int acceptLevel)
        {
            DepartmentName = departmentName;
            Description = description;
            CreateDate = createDate;
            UpdatedDate = updatedDate;
            AcceptLevel = acceptLevel;
        }

        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int AcceptLevel { get; set; }
        public ICollection<Visit> Visit { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<VisitorDepartment> VisitorDepartment { get; set; }
        public static Result<Department> Create(string departmentName, string description,
             int acceptLevel)
        {
            var department = new Department(departmentName, description,
                DateTime.Now, DateTime.Now, acceptLevel);
            return department;
        }
        public Result<Department> Update() {
            this.UpdatedDate = DateTime.Now;
            return this;      
        }

    }
}
