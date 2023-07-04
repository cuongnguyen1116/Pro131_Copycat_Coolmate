using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Stats;

namespace shop.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsServices _statisticsServices;

        public StatisticsController(IStatisticsServices statisticsServices)
        {
            _statisticsServices = statisticsServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistics()
        {
            var result = await _statisticsServices.GetStatistics();
            return Ok(result);
        }
    }
}
