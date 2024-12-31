using Business.Abstracts;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriController:ControllerBase
    {
        IMusteriService _musteriSercive;
        public MusteriController(IMusteriService musteriService)
        {
            _musteriSercive = musteriService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _musteriSercive.GetAll();
            return Ok(result);
        }
        [HttpGet("getdetail")]
        public IActionResult GetDetails(string tc)
        {
            var result = _musteriSercive.GetDetail(tc);
            return Ok(result);
        }

        [HttpGet("get")]
        public IActionResult Get(string tc)
        {
            var result = _musteriSercive.GetByTc(tc);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Musteri musteri)
        {
            _musteriSercive.Add(musteri);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Musteri musteri)
        {
            _musteriSercive.Update(musteri);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(string tc)
        {
            _musteriSercive.Delete(tc);
            return Ok();
        }
    }
}
