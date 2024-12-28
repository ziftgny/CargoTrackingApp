using Business.Abstracts;
using Entity.Concretes;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Get(int id)
        {
            var result = _kargoService.GetById(id);
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
        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            _kargoService.Delete(id);
            return Ok();
        }
    }

}
