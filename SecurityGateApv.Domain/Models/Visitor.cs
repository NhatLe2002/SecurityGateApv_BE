﻿using SecurityGateApv.Domain.Enums;
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
    public class Visitor
    {
        public Visitor()
        {
            
        }
        internal Visitor(string visitorName, string companyName, string phoneNumber, DateTime createdDate, DateTime updatedDate, string credentialsCard, string status,
            int credentialCardTypeId)
        {
            VisitorName = visitorName;
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
            CreateDate = createdDate;
            UpdateDate = updatedDate;
            CredentialsCard = credentialsCard;
            Status = status;
            CredentialCardTypeId = credentialCardTypeId;
        }

        [Key]
        public int VisitorId { get; private set; }
        public string VisitorName { get; private set; }
        public string CompanyName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CredentialsCard { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public string Status { get; private set; }

        [ForeignKey("CredentialCardType")]
        public int CredentialCardTypeId { get; private set; }
        public CredentialCardType CredentialCardType { get; private set; }

        public ICollection<VisitDetail> VisitDetails { get; private set; }
        public ICollection<VisitorImage> VisitorImage { get; private set; } = new List<VisitorImage>();
        public static Result<Visitor> Create(string visitorName, string companyName, string phoneNumber, DateTime createdDate, DateTime updatedDate, string credentialsCard, string visitorCredentialImageFront, string visitorCredentialImageBack, string status,
            int credentialCardTypeId)
        {
            var result = new Visitor(visitorName, companyName, phoneNumber, createdDate, updatedDate, credentialsCard, status, credentialCardTypeId);
            if(credentialCardTypeId == (int)CredentialCardTypeEnum.CitizenIdentificationCard)
            {
                result.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.CitizenIdentificationCard.ToString() + "_FRONT", visitorCredentialImageFront, result));
                result.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.CitizenIdentificationCard.ToString() + "_BACK", visitorCredentialImageBack, result));
            }
            else if(credentialCardTypeId == (int)CredentialCardTypeEnum.DrivingLicence)
            {
                result.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.DrivingLicence.ToString() + "_FRONT", visitorCredentialImageFront, result));
                result.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.DrivingLicence.ToString() + "_BACK", visitorCredentialImageBack, result));
            }
            return result;
        }
        public Result<Visitor> Update(string visitorCredentialImageFront, string visitorCredentialImageBack, int credentialCardTypeId)
        {
            this.UpdateDate = DateTime.Now;
            this.VisitorImage = new List<VisitorImage>();
            if (credentialCardTypeId == (int)CredentialCardTypeEnum.CitizenIdentificationCard)
            {
                this.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.CitizenIdentificationCard.ToString() + "_FRONT", visitorCredentialImageFront, this));
                this.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.CitizenIdentificationCard.ToString() + "_BACK", visitorCredentialImageBack, this));
            }
            else if (credentialCardTypeId == (int)CredentialCardTypeEnum.DrivingLicence)
            {
                this.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.DrivingLicence.ToString() + "_FRONT", visitorCredentialImageFront, this));
                this.VisitorImage.Add(new VisitorImage(CredentialCardTypeEnum.DrivingLicence.ToString() + "_BACK", visitorCredentialImageBack, this));
            }
            return this;
        }
        public Result<Visitor> Delete()
        {
            if(this.Status == "Active")
            {
                this.Status = "Unactive";
            }
            else
            {
                this.Status = "Active";
            }

            this.UpdateDate = DateTime.Now;
            return this;
        }
        public Result<Visitor> DecrypCredentialCard(ICollection<VisitorImage> images)
        {
           this.VisitorImage = images;
            return this;
        }
    }
}
