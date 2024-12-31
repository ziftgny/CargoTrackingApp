using Business.Abstracts;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdresController : ControllerBase
    {
        IAdresService _adresSercive;
        public AdresController(IAdresService adresSercive)
        {
            _adresSercive = adresSercive;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _adresSercive.GetAll();
            return Ok(result);
        }
        [HttpGet("getilceler")]
        public IActionResult getIlceler(int il_id)
        {
            var result = _adresSercive.getIlceler(il_id);
            return Ok(result);
        }
        [HttpGet("getiller")]
        public IActionResult getIller()
        {
            var result = _adresSercive.getIller();
            return Ok(result);
        }
        
        [HttpGet("getidbytcno")]
        public IActionResult getIdByTcNo(string tc_no)
        {
            var result = _adresSercive.getAddressIdByTcNo(tc_no);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Adres adres)
        {
            _adresSercive.Add(adres);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Adres adres)
        {
            _adresSercive.Update(adres);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Adres adres)
        {
            _adresSercive.Delete(adres);
            return Ok();
        }
    }
}
