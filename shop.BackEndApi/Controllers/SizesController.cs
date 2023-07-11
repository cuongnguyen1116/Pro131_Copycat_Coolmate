using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Sizes;

namespace shop.BackEndApi.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class SizesController : ControllerBase
{
    private readonly ISizeServices _sizeServices;

    public SizesController(ISizeServices sizeServices)
    {
        _sizeServices = sizeServices;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _sizeServices.GetAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _sizeServices.GetById(id);
        return Ok(result);
    }
}
