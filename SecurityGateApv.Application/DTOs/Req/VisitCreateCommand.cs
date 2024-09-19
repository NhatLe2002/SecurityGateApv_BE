using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Req
{
    public class VisitCreateCommand
    {
        public int VisitQuantity { get; set; }
        public int AcceptLevel { get; set; }
        public int DepartmentReasonId { get; set; }
        public int CreateById { get; set; }
        public int UpdateById { get; set; }
        public ICollection<VisitProjectCommand>? VisitProject { get; set; }
        public ICollection<VisitDetailCommand> VisitDetailOfNewVisitor { get; set; }
        public ICollection<VisitDetailOldCommand> VisitDetailOfOldVisitor { get; set; }
    }
    public class VisitProjectCommand
    {
        public string VisitName { get; set; }
        public int QuantityOfVisit { get; set; }
        public DateTime ExpectedTimeIn { get; set; }
        public DateTime ExpectedTimeOut { get; set; }
        public int ProjectId { get; set; }
    }
    public class VisitDetailCommand
    {
        public string VisitDetailName { get; set; }
        public string Description { get; set; }
        public DateTime ExpectedTimeIn { get; set; }
        public DateTime ExpectedTimeOut { get; set; }
        public bool Status { get; set; }
        public VisitorCommand Visitor { get; set; }
    }
    public class VisitDetailOldCommand
    {
        public string VisitDetailName { get; set; }
        public string Description { get; set; }
        public DateTime ExpectedTimeIn { get; set; }
        public DateTime ExpectedTimeOut { get; set; }
        public bool Status { get; set; }
        public int VisitorId { get; set; }
    }
    public class VisitorCommand
    {
        public string VisitorName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CredentialsCard { get; set; }
        public bool Status { get; set; }
        public int CredentialCardTypeId { get; set; }
    }
}
