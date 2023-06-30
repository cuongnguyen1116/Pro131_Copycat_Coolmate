using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Colors;
using shop.ViewModels.Catalog.Colors;

namespace shop.BackEndApi.Controllers
{
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

        [HttpPost]
        public async Task<IActionResult> Create(ColorVm vm)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _colorServices.Create(vm);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, ColorVm vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _colorServices.Update(id, vm);
            return Ok(result);
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _colorServices.Delete(id);
            return Ok(result);
        }
    } 
}
