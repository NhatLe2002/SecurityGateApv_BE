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
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public string CardVerification { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastCancelDate { get; private set; }
        public DateTime IssuedDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        public string CardImage { get; private set; }
        public string CardStatus { get; private set; }

        [ForeignKey("QRCardType")]
        public int QRCardTypeId { get; private set; }
        public CardType QRCardType { get; private set; }

        public ICollection<VisitorSession> VisitorSession { get; private set; }
       /* public Result<QRCard> Update(Guid cardGuidId)
        {
            this.CardGuidId = cardGuidId;
            return this;
        }*/
        public Result<Card> UpdateQRCardStatus(int status)
        {
            //this.QRCardStatusId = status;
            return this;
        }
        public static Card Create(int qrCardTypeId, int qrCardStatusId, string guid, string cardImage)
        {
            var qrCard = new Card
            {
                CardVerification = guid,
                CreateDate = DateTime.Now,
                LastCancelDate = DateTime.Now,
                CardImage = cardImage,
                QRCardTypeId = qrCardTypeId,
                //QRCardStatusId = qrCardStatusId
            };

            return qrCard;
        }
    }
}
