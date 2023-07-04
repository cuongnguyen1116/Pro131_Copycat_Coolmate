using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Categories;
using shop.ViewModels.Catalog.Categories;

namespace shop.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;

        public CategoriesController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryServices.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _categoryServices.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryVm vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _categoryServices.Create(vm);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, CategoryVm vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _categoryServices.Update(id, vm);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _categoryServices.Delete(id);
            return Ok(result);
        }
    }
}
