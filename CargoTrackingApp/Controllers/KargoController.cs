using Business.Abstracts;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KargoController : ControllerBase
    {
        IKargoService _kargoService;
        public KargoController(IKargoService kargoService)
        {
            _kargoService = kargoService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kargoService.GetAll();
            return Ok(result);
        }

        [HttpGet("get")]
        public IActionResult Get(string takip_no)
        {
            var result = _kargoService.GetByTc(takip_no);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Kargo kargo)
        {
            _kargoService.Add(kargo);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Kargo kargo)
        {
            _kargoService.Update(kargo);
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete(string takip_no)
        {
            _kargoService.Delete(takip_no);
            return Ok();
        }
        [HttpGet("getdetail")]
        public IActionResult GetDetail(string takip_no)
        {
            var result = _kargoService.GetDetail(takip_no);
            return Ok(result);
        }
    }

}
