using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Materials;
using shop.ViewModels.Catalog.Materials;

namespace shop.BackEndApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private readonly IMaterialServices _materialServices;

        public MaterialsController(IMaterialServices materialServices)
        {
            _materialServices = materialServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _materialServices.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _materialServices.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MaterialVm vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _materialServices.Create(vm);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, MaterialVm vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _materialServices.Update(id, vm);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _materialServices.Delete(id);
            return Ok(result);
        }
    }
}
