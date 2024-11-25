using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Infras.DBContext;
using SkiaSharp;
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
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file), "File parameter is null.");
            }

            // Generate QR code
            var qrCodeGenerator = new QRCodeGenerator();
            var qrCodeData = qrCodeGenerator.CreateQrCode(cardIdGuid, QRCoder.QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qrCode.GetGraphic(5, new byte[] { 0, 0, 0, 255 }, new byte[] { 0xf5, 0xf5, 0xf7, 255 });

            // Create a card image with the QR code embedded
            using (var qrCodeImage = SKBitmap.Decode(qrCodeBytes))
            {
                if (qrCodeImage == null)
                {
                    throw new ArgumentNullException(nameof(qrCodeImage), "QR code image could not be decoded.");
                }

                int cardWidth = 250;
                int cardHeight = 400;
                using (var cardImage = new SKBitmap(cardWidth, cardHeight))
                {
                    using (var canvas = new SKCanvas(cardImage))
                    {
                        // Design the card background
                        var backgroundColor = SKColor.Parse("#34495e");
                        canvas.Clear(backgroundColor);

                        // Draw rounded rectangle
                        int cornerRadius = 20;
                        var paint = new SKPaint
                        {
                            Color = backgroundColor,
                            IsAntialias = true
                        };
                        var rect = new SKRoundRect(new SKRect(0, 0, cardWidth, cardHeight), cornerRadius, cornerRadius);
                        canvas.DrawRoundRect(rect, paint);

                        var borderColor = SKColors.White;
                        var borderPaint = new SKPaint
                        {
                            Color = borderColor,
                            StrokeWidth = 10,
                            IsStroke = true,
                            IsAntialias = true
                        };
                        canvas.DrawRoundRect(rect, borderPaint);

                        // Add logo
                        using (var memoryStream = new MemoryStream())
                        {
                            await file.CopyToAsync(memoryStream);
                            memoryStream.Seek(0, SeekOrigin.Begin); // Reset stream position
                            using (var logo = SKBitmap.Decode(memoryStream))
                            {
                                if (logo == null)
                                {
                                    throw new ArgumentNullException(nameof(logo), "Logo image could not be decoded.");
                                }

                                int logoWidth = 100;
                                int logoHeight = 100;
                                int logoX = (cardWidth - logoWidth) / 2;
                                int logoY = 20;
                                canvas.DrawBitmap(logo, new SKRect(logoX, logoY, logoX + logoWidth, logoY + logoHeight));
                            }
                        }

                        // Add title text
                        var titlePaint = new SKPaint
                        {
                            Color = SKColors.White,
                            TextSize = 24, // Increased text size
                            IsAntialias = true,
                            TextAlign = SKTextAlign.Center,
                            Typeface = SKTypeface.FromFamilyName("Arial", SKFontStyle.Bold)
                        };
                        canvas.DrawText("Security Gate APV", cardWidth / 2, 130, titlePaint);

                        // Draw the QR code on the card
                        int qrCodeSize = 150;
                        int qrCodeX = (cardWidth - qrCodeSize) / 2;
                        int qrCodeY = 160;
                        canvas.DrawBitmap(qrCodeImage, new SKRect(qrCodeX, qrCodeY, qrCodeX + qrCodeSize, qrCodeY + qrCodeSize));

                        // Add footer text
                        var textPaint = new SKPaint
                        {
                            Color = cardTypeName == CardTypeEnum.ShotTermCard.ToString() ? SKColors.White : SKColors.Yellow,
                            TextSize = 12,
                            IsAntialias = true,
                            TextAlign = SKTextAlign.Center,
                            Typeface = SKTypeface.FromFamilyName("Arial", SKFontStyle.Bold)
                        };
                        string footerText = cardTypeName == CardTypeEnum.ShotTermCard.ToString() ? "Thẻ ra vào hàng ngày" : "Thẻ ra vào theo lịch trình";
                        canvas.DrawText(footerText, cardWidth / 2, cardHeight - 30, textPaint);
                    }

                    // Convert the card image to a base64 string
                    using (var ms = new MemoryStream())
                    {
                        cardImage.Encode(ms, SKEncodedImageFormat.Png, 100);
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
