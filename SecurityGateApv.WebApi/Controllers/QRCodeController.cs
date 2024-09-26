using Microsoft.AspNetCore.Mvc;
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
    }
}
