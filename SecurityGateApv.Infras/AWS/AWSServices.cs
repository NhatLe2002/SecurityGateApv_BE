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

namespace SecurityGateApv.Infras.AWS
{
    public class AWSServices : IAWSService
    {
        public async Task<ICollection<AWSDomainDTO>> DetectLabelService(IFormFile image)
        {
            MemoryStream stream = new MemoryStream();
            await image.CopyToAsync(stream);
            List<AWSDomainDTO> list = new List<AWSDomainDTO>();
            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();

            DetectLabelsRequest detectlabelsRequest = new DetectLabelsRequest()
            {
                Image = new Image()
                {
                    Bytes = stream
                },
                MaxLabels = 10,
                MinConfidence = 75F
            };

            try
            {
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
    }
}
