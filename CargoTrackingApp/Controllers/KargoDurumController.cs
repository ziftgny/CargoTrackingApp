using Business.Abstracts;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KargoDurumController : ControllerBase
    {
        IKargoDurumService _kargoDurumService;
        public KargoDurumController(IKargoDurumService kargoDurumService)
        {
            _kargoDurumService = kargoDurumService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kargoDurumService.GetAll();
            return Ok(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _kargoDurumService.Get(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Kargo_Durum kargodurum)
        {
            _kargoDurumService.Add(kargodurum);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Kargo_Durum kargodurum)
        {
            _kargoDurumService.Update(kargodurum);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Kargo_Durum kargodurum)
        {
            _kargoDurumService.Delete(kargodurum);
            return Ok();
        }
       
    }
}
