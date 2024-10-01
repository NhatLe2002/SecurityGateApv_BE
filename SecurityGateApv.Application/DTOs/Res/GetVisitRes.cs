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
        public int VisitDetailId { get;  set; }
        public TimeSpan ExpectedStartHour { get;  set; }
        public TimeSpan ExpectedEndHour { get;  set; }
        public bool Status { get;  set; }
        public VisitorRes Visitor { get;  set; }

    }
    public class GetVisitNoDetailRes
    {
        public int VisitId { get; set; }
        public DateTime DateRegister { get; private set; }
        public string VisitName { get; private set; }
        public int VisitQuantity { get; private set; }
        public int AcceptLevel { get; private set; }
        public string Description { get; private set; }
        public string VisitType { get; private set; }
        public CreateByRes CreateBy { get;  set; }
    }
    public class GetVisitByDateRes
    {
        
        public int VisitId { get;  set; }
        public string VisitName { get; set; }
        public int VisitQuantity { get;  set; }
        public string? Description { get;  set; }
        public string CreateByname { get;  set; }
        public string ScheduleTypeName { get;  set; }

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
}
