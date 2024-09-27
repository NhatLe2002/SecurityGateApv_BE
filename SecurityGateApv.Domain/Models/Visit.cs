using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Errors;
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
        internal Visit(DateTime dateRegister, int visitQuantity, string visitName, int acceptLevel, int createById, int updateById, string visitType)
        {
            DateRegister = dateRegister;
            VisitQuantity = visitQuantity;
            AcceptLevel = acceptLevel;
            CreateById = createById;
            VisitName = visitName;
            UpdateById = updateById;
            VisitType = visitType;
        }

        public Visit()
        {
            
        }

        [Key]
        public int VisitId { get;  set; }
        public DateTime DateRegister { get; private set; }
        public string VisitName { get; private set; }
        public int VisitQuantity { get; private set; }
        public int AcceptLevel { get; private set; }
        public string? Description { get; private set; }
        public string VisitType { get; private set; }

        [ForeignKey("CreateBy")]
        public int CreateById { get; private set; }
        public User CreateBy { get; private set; }

        [ForeignKey("UpdateBy")]
        public int? UpdateById { get; private set; }
        public User? UpdateBy { get; private set; }

        public ICollection<VisitProcess> VisitProcess { get; private set; } = new List<VisitProcess>();
        public ICollection<VisitDetail> VisitDetail { get; private set; } = new List<VisitDetail>();

        public static Result<Visit> Create(int visitQuantity, int acceptLevel,string visitName, int createById, int updateById, User createBy)
        {
            var visitType = VisitTypeEnum.NONE;
            if (createBy.Role.RoleName == UserRole.Staff.ToString())
            {
                visitType = VisitTypeEnum.VisitStaff;
            }
            else if (createBy.Role.RoleName == UserRole.Security.ToString())
            {
                visitType = VisitTypeEnum.VisitSecurity;
            }
            else
            {
                return Result.Failure<Visit>(Error.NotRoleNotPermission);
            }
            var result = new Visit(DateTime.UtcNow,  visitQuantity, visitName,  acceptLevel,  createById,  updateById, visitType.ToString());
            return result;
        }
        public static Result<Visit> CreateVisitOfProcess(int visitQuantity, int acceptLevel, string visitName, int createById, int updateById, VisitTypeEnum visitTypeEnum)
        {              
            /*if (createBy.Role.RoleName == UserRole.Staff.ToString())
            {
                visitType = VisitTypeEnum.VisitStaff;
            }
            else if (createBy.Role.RoleName == UserRole.Security.ToString())
            {
                visitType = VisitTypeEnum.VisitSecurity;
            }
            else
            {
                return Result.Failure<Visit>(Error.NotRoleNotPermission);
            }*/
            var result = new Visit(DateTime.UtcNow, visitQuantity, visitName, acceptLevel, createById, updateById, visitTypeEnum.ToString());
            return result;
        }
        public Result<Visit> AddVisitDetailOfOldVisitor( string description, DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedTimeIn, TimeSpan expectedTimeOut, bool status, int visitorId)
        {
            var visitDetail = new VisitDetail( description, expectedStartDate, expectedEndDate, expectedTimeIn, expectedTimeOut, status, this, visitorId);
            VisitDetail.Add(visitDetail);
            return this;
        }
        public Result<Visit> AddVisitDetailOfNewVisitor( string description, DateTime expectedStartDate, DateTime expectedEndDate, TimeSpan expectedTimeIn, TimeSpan expectedTimeOut, bool status, Visitor visitor)
        {
            var visitDetail = new VisitDetail( description, expectedStartDate, expectedEndDate, expectedTimeIn, expectedTimeOut, status, this, visitor);
            VisitDetail.Add(visitDetail);
            return this;
        }
    }
}
