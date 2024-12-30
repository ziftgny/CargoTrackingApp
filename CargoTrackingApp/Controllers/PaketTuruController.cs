using Business.Abstracts;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaketTuruController : ControllerBase
    {
        IPaketTuruService _paketTuruService;
        public PaketTuruController(IPaketTuruService paketTuruService)
        {
            _paketTuruService = paketTuruService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _paketTuruService.GetAll();
            return Ok(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _paketTuruService.Get(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Paket_Turu paketturu)
        {
            _paketTuruService.Add(paketturu);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Paket_Turu paketturu)
        {
            _paketTuruService.Update(paketturu);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(Paket_Turu paketturu)
        {
            _paketTuruService.Delete(paketturu);
            return Ok();
        }
     }
}
