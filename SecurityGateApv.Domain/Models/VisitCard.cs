using SecurityGateApv.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class VisitCard
    {
        private VisitCard(DateTime issueDate, DateTime expiryDate, string visitCardStatus, int visitDetailId, int cardId)
        {
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            VisitCardStatus = visitCardStatus;
            VisitDetailId = visitDetailId;
            CardId = cardId;
        }

        public int VisitCardId { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public string VisitCardStatus { get; private set; }

        [ForeignKey("VisitDetail")]
        public int VisitDetailId { get; private set; }
        public VisitDetail VisitDetail { get; private set; }

        [ForeignKey("Card")]
        public int CardId { get; private set; }
        public Card Card { get; private set; }


        //create function create visit card
        public static VisitCard Create(DateTime issueDate, DateTime expiryDate, string visitCardStatus, int visitDetailId, int cardId)
        {
            VisitCard visitCard = new VisitCard(issueDate, expiryDate, visitCardStatus, visitDetailId, cardId);

            return visitCard;
        }
    }

}
