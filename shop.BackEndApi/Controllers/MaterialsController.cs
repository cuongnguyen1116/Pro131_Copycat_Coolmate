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

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] MaterialCreateRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _materialServices.Create(request);
            return Ok(result);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] MaterialUpdateRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _materialServices.Update(id, request);
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _materialServices.Delete(id);
            return Ok(result);
        }
    }
}
