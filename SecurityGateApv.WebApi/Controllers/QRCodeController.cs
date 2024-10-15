using Microsoft.AspNetCore.Mvc;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;

namespace SecurityGateApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QRCodeController : Controller
    {
        private readonly IQRCodeService _qrCodeService;

        public QRCodeController(IQRCodeService qrCodeService)
        {
            _qrCodeService = qrCodeService;
        }

        [HttpPost("decode")]
        public async Task<IActionResult> DecodeQRCode( IFormFile image)
        {
            // Kiểm tra xem file có tồn tại không
            if (image == null || image.Length == 0)
            {
                return BadRequest("Vui lòng chọn một file ảnh.");
            }

            try
            {
                var result = _qrCodeService.DecodeQRCodeFromImage(image);
                return Ok(new { Text = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi: {ex.Message}");
            }
        }
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

        [HttpPost("GenerateQrCard")]
        public async Task<IActionResult> GenerateQrCar(string cardGuid)
        {
            var result = _qrCodeService.GenerateQrCar(cardGuid);
            return Ok(result.Result);
        }

        [HttpPost("CreateQRCard")]
        public async Task<IActionResult> CreateQRCard( string cardGuid)
        {
            var result = _qrCodeService.CreateQRCard( cardGuid);
            return Ok(result.Result.Value);
        }
        [HttpGet("GetAllQrCardPaging")]
        public async Task<ActionResult> GetAllQrCardPaging(int pageNumber,  int pageSize)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than zero.");
            }

            var result = await _qrCodeService.GetAllByPaging(pageNumber, pageSize);
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
            return Ok(result.Value);
        }
    }
}
