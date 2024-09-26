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
        public Guid CardGuidId { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastCancelDate { get; private set; }


        [ForeignKey("QRCardType")]
        public int QRCardTypeId { get; private set; }
        public QRCardType QRCardType { get; private set; }


        [ForeignKey("QRCardStatus")]
        public int QRCardStatusId { get; private set; }
        public QRCardStatus QRCardStatus { get; private set; }

        public ICollection<VisitorSession> VisitorSession { get; private set; }
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
