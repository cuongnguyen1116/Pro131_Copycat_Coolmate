using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Colors;
using shop.ViewModels.Catalog.Colors;
using shop.ViewModels.Catalog.Materials;

namespace shop.BackEndApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ColorsController : ControllerBase
{
    private readonly IColorServices _colorServices;

    public ColorsController(IColorServices colorServices)
    {
        _colorServices = colorServices;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var colors = await _colorServices.GetAll();
        return Ok(colors);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var color = await _colorServices.GetById(id);
        return Ok(color);
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] ColorCreateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var result = await _colorServices.Create(request);
        return Ok(result);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] ColorUpdateRequest request)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var result = await _colorServices.Update(id, request);
        return Ok(result);

    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _colorServices.Delete(id);
        return Ok(result);
    }
}

