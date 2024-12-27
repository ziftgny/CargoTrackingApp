using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CargoTrackingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
    
        private readonly CargoTrackingDatabaseContext _context;

        public WeatherForecastController(CargoTrackingDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _context.kargolar.ToListAsync();
            return Ok(entities);
        }
    
    }
}
