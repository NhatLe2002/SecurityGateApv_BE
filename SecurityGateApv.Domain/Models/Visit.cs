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
    public class Visit
    {
        internal Visit(DateTime dateRegister, int visitQuantity, int acceptLevel, int departmentReasonId, int createById, int updateById)
        {
            DateRegister = dateRegister;
            VisitQuantity = visitQuantity;
            AcceptLevel = acceptLevel;
            DepartmentReasonId = departmentReasonId;
            CreateById = createById;
            UpdateById = updateById;

        }

        protected Visit()
        {
            
        }

        [Key]
        public int VisitId { get; set; }
        public DateTime DateRegister { get; private set; }
        public int VisitQuantity { get; private set; }
        public int AcceptLevel { get; private set; }


        [ForeignKey("DepartmentReason")]
        public int DepartmentReasonId { get; private set; }
        public DepartmentReason DepartmentReason { get; private set; }



        [ForeignKey("CreateBy")]
        public int CreateById { get; private set; }
        public User CreateBy { get; private set; }

        [ForeignKey("UpdateBy")]
        public int UpdateById { get; private set; }
        public User? UpdateBy { get; private set; }

        public ICollection<VisitProject> VisitProject { get; private set; } = new List<VisitProject>();
        public ICollection<VisitDetail> VisitDetail { get; private set; } = new List<VisitDetail>();

        public static Result<Visit> Create(int visitQuantity, int acceptLevel, int departmentReasonId, int createById, int updateById)
        {
            var result = new Visit( DateTime.UtcNow,  visitQuantity,  acceptLevel,  departmentReasonId,  createById,  updateById);
            return result;
        }
        public Result<Visit> AddVisitDetailOfOldVisitor(string visitDetailName, string description, DateTime expectedTimeIn, DateTime expectedTimeOut, bool status, int visitorId)
        {
            var visitDetail = new VisitDetail(visitDetailName, description, expectedTimeIn, expectedTimeOut, status, this, visitorId);
            VisitDetail.Add(visitDetail);
            return this;
        }
        public Result<Visit> AddVisitDetailOfNewVisitor(string visitDetailName, string description, DateTime expectedTimeIn, DateTime expectedTimeOut, bool status, Visitor visitor)
        {
            var visitDetail = new VisitDetail(visitDetailName, description, expectedTimeIn, expectedTimeOut, status, this, visitor);
            VisitDetail.Add(visitDetail);
            return this;
        }
    }
}
