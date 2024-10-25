using Microsoft.EntityFrameworkCore;
using QRCoder;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Infras.DBContext;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.Repositories
{
    public class CardRepo : RepoBase<Card>, ICardRepo
    {
        private readonly SecurityGateApvDbContext _context;
        private readonly DbSet<Visit> _dbSet;

        public CardRepo(SecurityGateApvDbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Visit>();
        }

        public async Task<Card> GenerateQRCard(string cardIdGuid)
        {
            string base64Qr = "";
            QRCodeGenerator qRCode = new QRCodeGenerator();
            QRCodeData data = qRCode.CreateQrCode(cardIdGuid, QRCoder.QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode1 = new PngByteQRCode(data);
            var cardImage = Convert.ToBase64String(qrCode1.GetGraphic(5, new byte[] { 0, 0, 0, 255 }, new byte[] { 0xf5, 0xf5, 0xf7, 255 }));

            var car = Card.GenerateCard(  cardIdGuid, cardImage);

            return car.Value;


        }
    }
}
