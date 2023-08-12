using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Promotions;
using shop.ViewModels.Catalog.Promotions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shop.BackEndApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PromotionsController : ControllerBase
{
    private readonly IPromotionService _promotionService;

    public PromotionsController(IPromotionService promotionService)
    {
        _promotionService = promotionService;
    }

    // GET: api/<ValuesController>
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PromotionPagingRequest request)
    {
        var result = await _promotionService.GetAll(request);
        return Ok(result);
    }

    [HttpGet("{promotionId}")]
    public async Task<IActionResult> GetById(Guid promotionId)
    {
        var product = await _promotionService.GetById(promotionId);
        if (product == null)
        {
            return BadRequest("Can't find product");
        }
        return Ok(product);
    }
    // GET api/<ValuesController>/5
    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] PromotionCreateRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var promotionid = await _promotionService.Create(request);
        if (promotionid == false)
            return BadRequest();
        else
        {
            HttpContext.Response.StatusCode = 201;
            return Ok(request);
        }
    }

    // POST api/<ValuesController>
    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] PromotionUpdateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await _promotionService.Update(id, request);
        return Ok(result);
    }

}
