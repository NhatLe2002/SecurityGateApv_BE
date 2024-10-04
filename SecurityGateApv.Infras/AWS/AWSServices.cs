using Amazon.Rekognition.Model;
using Amazon.Rekognition;
using Microsoft.AspNetCore.Http;
using SecurityGateApv.Domain.Interfaces.AWS;
using SecurityGateApv.Domain.Interfaces.DomainDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityGateApv.Domain.Models;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SecurityGateApv.Infras.AWS
{
    public class AWSServices : IAWSService
    {
        public async Task<ICollection<AWSDomainDTO>> DetectLabelService(IFormFile image, PrivateKeyService key)
        {
            List<AWSDomainDTO> list = new List<AWSDomainDTO>();
            try
            {
            MemoryStream stream = new MemoryStream();
            await image.CopyToAsync(stream);
            System.Drawing.Image resizeImage = System.Drawing.Image.FromStream(stream);
            resizeImage = ResizeImage(resizeImage, new Size(500, 500));
            MemoryStream streamResize = new MemoryStream();
            resizeImage.Save(streamResize, ImageFormat.Png);
            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient(key.KeyName, key.Key, Amazon.RegionEndpoint.APSoutheast1);

            DetectLabelsRequest detectlabelsRequest = new DetectLabelsRequest()
            {
                Image = new Amazon.Rekognition.Model.Image()
                {
                    Bytes = streamResize
                },
                MaxLabels = 10,
                MinConfidence = 75F
                
            };

   
                DetectLabelsResponse detectLabelsResponse = await rekognitionClient.DetectLabelsAsync(detectlabelsRequest);
                Console.WriteLine("Detected labels for ");
                foreach (Label label in detectLabelsResponse.Labels)
                {
                    Console.WriteLine("{0}: {1}", label.Name, label.Confidence);
                    list.Add(new AWSDomainDTO
                    {
                        Label = label.Name,
                        Confidence = label.Confidence
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }
        private static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
    }
}
