using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.DTOs.Res
{
    public class GetVisitRes
    {
        public string VisitName { get; private set; }
        public int VisitQuantity { get; private set; }
        public DateTime ExpectedStartTime { get; private set; }
        public DateTime ExpectedEndTime { get; private set; }
        public DateTime CreateTime { get; private set; }
        public DateTime UpdateTime { get; private set; }
        public string? Description { get; private set; }
        public string VisitStatus { get; private set; }
        public CreateByRes CreateBy { get; private set; }

        public CreateByRes? UpdateBy { get; private set; }

        public ScheduleResForVisit Schedule { get; private set; }
        public ICollection<VisitDetailRes> VisitDetail { get; set; }
        //public ICollection<VisitProcessRes> VisitProcess { get;  set; }

    }
    public class GetVisitNoDetailRes
    {
        public int VisitId { get; set; }
        public string VisitName { get; private set; }
        public int VisitQuantity { get; private set; }
        public DateTime ExpectedStartTime { get; private set; }
        public DateTime ExpectedEndTime { get; private set; }
        public DateTime CreateTime { get; private set; }
        public DateTime UpdateTime { get; private set; }
        public string? Description { get; private set; }
        public string VisitStatus { get; private set; }
        public CreateByRes CreateBy { get; private set; }

        public CreateByRes? UpdateBy { get; private set; }

        public ScheduleResForVisit Schedule { get; private set; }
    }
    public class GetVisitByCurrentDateRes
    {
        
        public int VisitDetailId { get;  set; }
        public int VisitId { get;  set; }
        public string? VisitName { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public TimeSpan ExpectedStartTime { get; set; }
        public TimeSpan ExpectedEndTime { get; set; }
        public string VisitorName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string CredentialsCard { get; set; }

    }
    public class VisitDetailRes
    {
        public int VisitDetailId { get;  set; }
        public DateTime ExpectedStartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public TimeSpan ExpectedStartTime { get;  set; }
        public TimeSpan ExpectedEndTime { get;  set; }
        public bool Status { get; private set; }
        public VisitorRes Visitor { get; set; }
    }

    public class VisitorRes
    {
        public string VisitorName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CredentialsCard { get; set; }
        //public bool Status { get; set; }

        public CredentialCardType CredentialCardType { get; set; }
    }

    public class CredentialCardType
    {
        public string CredentialCardTypeName { get; set; }
    } 
    
    public class CreateByRes
    {
        public string FullName { get; set; }
    }
    
    public class VisitProcessRes
    {
        public string DaysOfProcess { get; set; }
    }
    public class ScheduleResForVisit
    {
        public int ScheduleId { get; private set; }
        public string ScheduleName { get; private set; }
    }
}
