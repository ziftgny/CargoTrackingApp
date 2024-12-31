using Business.Abstracts;
using Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CalisanController:ControllerBase
    {
        ICalisanService _calisanService;
        public CalisanController(ICalisanService calisanService)
        {
            _calisanService = calisanService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _calisanService.GetAll();
            return Ok(result);
        }
        [HttpGet("getallkurye")]
        public IActionResult GetAllKurye()
        {
            var result = _calisanService.GetAllKurye();
            return Ok(result);
        }
        [HttpGet("getcalisanlogincheck")]
        public IActionResult GetCalisanLoginCheck(string tc_no, string password)
        {
            var result = _calisanService.CalisanLoginCheck(tc_no, password);
            return Ok(result);
        }

        [HttpGet("get")]
        public IActionResult Get(string tc)
        {
            var result = _calisanService.GetByTc(tc);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Calisan calisan)
        {
            _calisanService.Add(calisan);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Calisan calisan)
        {
            _calisanService.Update(calisan);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Delete(string tc)
        {
            _calisanService.Delete(tc);
            return Ok();
        }
    }
}
