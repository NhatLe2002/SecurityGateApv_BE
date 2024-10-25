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


    }
}
