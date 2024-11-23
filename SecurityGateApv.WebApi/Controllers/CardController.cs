using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : Controller
    {
        private readonly ICardService _qrCodeService;

        public CardController(ICardService qrCodeService)
        {
            _qrCodeService = qrCodeService;
        }

        //[HttpPost("decode")]
        //public async Task<IActionResult> DecodeQRCode( IFormFile image)
        //{
        //    // Kiểm tra xem file có tồn tại không
        //    if (image == null || image.Length == 0)
        //    {
        //        return BadRequest("Vui lòng chọn một file ảnh.");
        //    }

        //    try
        //    {
        //        var result = _qrCodeService.DecodeQRCodeFromImage(image);
        //        return Ok(new { Text = result });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Lỗi: {ex.Message}");
        //    }
        //}
        [HttpPost("ShoeDetect")]
        public async Task<IActionResult> ShoeDetect(DetectImageCommand request)
        {
            // Kiểm tra xem file có tồn tại không
            if (request.Image == null || request.Image.Length == 0)
            {
                return BadRequest("Vui lòng chọn một file ảnh.");
            }

            try
            {
                var result = await _qrCodeService.DetectShoe(request.Image);
                if (result.IsFailure)
                {
                    return BadRequest(result.Error);
                }
                return Ok(result.Value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi: {ex.Message}");
            }
        }

        [HttpPost("GenerateCard")]
        public async Task<IActionResult> GenerateCard(CreateCardCommand command)
        {
            var result = await _qrCodeService.GenerateCard(command);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateCard( CreateCardCommand command)
        {
            var result = await _qrCodeService.CreateCard(command);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet()]
        public async Task<ActionResult> GetAllQrCardPaging(int pageNumber,  int pageSize)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _qrCodeService.GetAllByPaging(pageNumber, pageSize);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
        [HttpGet("{cardVerification}")]
        public async Task<ActionResult> GetQrCardByCardVerification(string cardVerification)
        {
            if (cardVerification == null)
            {
                return BadRequest("CardVerification can not null");
            }

            var result = await _qrCodeService.GetQrCardByCardVerification(cardVerification);
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}
