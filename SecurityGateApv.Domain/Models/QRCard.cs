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
    public class QRCard
    {
        [Key]
        public int QRCardId { get; set; }
        public Guid CardGuidId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastCancelDate { get; set; }


        [ForeignKey("QRCardType")]
        public int QRCardTypeId { get; set; }
        public QRCardType QRCardType { get; set; }


        [ForeignKey("QRCardStatus")]
        public int QRCardStatusId { get; set; }
        public QRCardStatus QRCardStatus { get; set; }

        public ICollection<VisitorSession> VisitorSession { get; set; }
        public Result<QRCard> Update(Guid cardGuidId)
        {
            this.CardGuidId = cardGuidId;
            return this;
        }
        public Result<QRCard> UpdateQRCardStatus(int status)
        {
            this.QRCardStatusId = status;
            return this;
        }
    }
}
