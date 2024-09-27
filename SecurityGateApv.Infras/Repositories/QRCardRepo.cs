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
    public class QRCardRepo : RepoBase<QRCard>, IQRCardRepo
    {
        private readonly SecurityGateApvDbContext _context;
        private readonly DbSet<Visit> _dbSet;

        public QRCardRepo(SecurityGateApvDbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Visit>();
        }

        public async Task<string> GenerateQRCard(string cardIdGuid)
        {
            string base64Qr = "";
            QRCodeGenerator qRCode = new QRCodeGenerator();
            QRCodeData data = qRCode.CreateQrCode(cardIdGuid, QRCoder.QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode1 = new PngByteQRCode(data);

            return Convert.ToBase64String(qrCode1.GetGraphic(5, new byte[] { 0, 0, 0, 255 }, new byte[] { 0xf5, 0xf5, 0xf7, 255 }));


        }
    }
}
