using BMB_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuyMeBack.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
    public class KoiFishController : ControllerBase
    {
        private readonly IKoiFishService _koiFishService;
        public KoiFishController(IKoiFishService koiFishService)
        {
            _koiFishService = koiFishService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var koiFishList  =  await _koiFishService.GetAllAsync();
            return Ok(koiFishList);
        }
    }
}
