using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Infras.DBContext;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public async Task<Card> GenerateQRCard(string cardIdGuid, IFormFile file, string cardTypeName)
        {
            // Generate QR code
            QRCodeGenerator qRCode = new QRCodeGenerator();
            QRCodeData data = qRCode.CreateQrCode(cardIdGuid, QRCoder.QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode1 = new PngByteQRCode(data);
            byte[] qrCodeBytes = qrCode1.GetGraphic(5, new byte[] { 0, 0, 0, 255 }, new byte[] { 0xf5, 0xf5, 0xf7, 255 });

            // Create a card image with the QR code embedded
            using (var qrCodeImage = new Bitmap(new MemoryStream(qrCodeBytes)))
            {
                int cardWidth = 250;
                int cardHeight = 400;
                using (var cardImage = new Bitmap(cardWidth, cardHeight))
                {
                    using (Graphics graphics = Graphics.FromImage(cardImage))
                    {
                        // Design the card background
                        graphics.Clear(Color.White);

                        // Draw rounded rectangle
                        int cornerRadius = 20;
                        using (GraphicsPath path = new GraphicsPath())
                        {
                            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                            path.AddArc(cardWidth - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                            path.AddArc(cardWidth - cornerRadius, cardHeight - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                            path.AddArc(0, cardHeight - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                            path.CloseAllFigures();

                            using (Brush brush = new SolidBrush(Color.White))
                            {
                                graphics.FillPath(brush, path);
                            }

                            Color borderColor = ColorTranslator.FromHtml("#34495e");
                            using (Pen borderPen = new Pen(borderColor, 5))
                            {
                                graphics.DrawPath(borderPen, path);
                            }
                        }

                        // Add logo
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            using (var logo = Image.FromStream(memoryStream))
                            {
                                int logoWidth = 100;
                                int logoHeight = 100;
                                int logoX = (cardWidth - logoWidth) / 2;
                                int logoY = 20;
                                graphics.DrawImage(logo, logoX, logoY, logoWidth, logoHeight);
                            }
                        }

                        // Add title text
                        Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                        StringFormat format = new StringFormat { Alignment = StringAlignment.Center };
                        graphics.DrawString("Security Gate APV", titleFont, Brushes.Black, new PointF(cardWidth / 2, 130), format);

                        // Draw the QR code on the card
                        int qrCodeSize = 150;
                        int qrCodeX = (cardWidth - qrCodeSize) / 2;
                        int qrCodeY = 160;
                        graphics.DrawImage(qrCodeImage, qrCodeX, qrCodeY, qrCodeSize, qrCodeSize);

                        // Add footer text
                        Font textFont = new Font("Arial", 12, FontStyle.Bold);
                        if(cardTypeName == CardTypeEnum.ShotTermCard.ToString())
                        {

                        graphics.DrawString("Thẻ ra vào hàng ngày", textFont, Brushes.Blue, new PointF(cardWidth / 2, cardHeight - 30), format);
                        }
                        else if (cardTypeName == CardTypeEnum.LongTermCard.ToString())
                        {
                        graphics.DrawString("Thẻ ra vào theo lịch trình", textFont, Brushes.Green, new PointF(cardWidth / 2, cardHeight - 30), format);

                        }
                    }

                    // Convert the card image to a base64 string
                    using (var ms = new MemoryStream())
                    {
                        cardImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        var cardImageBase64 = Convert.ToBase64String(ms.ToArray());

                        // Create the Card object
                        var card = Card.GenerateCard(cardIdGuid, cardImageBase64);
                        return card.Value;
                    }
                }
            }
        }
    }
}
