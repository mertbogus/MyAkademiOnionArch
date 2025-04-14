using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Features.CQRS.Commands;
using Onion.Application.Features.CQRS.Handlers;
using Onion.Application.Features.CQRS.Queries;

namespace Onion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase

    {
        private readonly GetCategoryQueryHandler _handler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;

        public CategoriesController(GetCategoryQueryHandler handler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler)
        {
            _handler = handler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var values = await _handler.Handle();
            return Ok(values);
        }

        [HttpGet("{CategoryId}")]

        public async Task<IActionResult> GetById(Guid CategoryId)
        {
            var value = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(CategoryId));
            if (value == null)
            {
                return NotFound("Kategori bulunamadı");
            }
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateCategoryCommand createCategoryCommand)
        {
            var result = await _createCategoryCommandHandler.Handle(createCategoryCommand);
            if (result==false)
            {
                return BadRequest("Kategori Kayıt Edilemedi.");
            }
            return Created();
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdateCategoryCommand updateCategoryCommand)
        {
            var result = await _updateCategoryCommandHandler.Handle(updateCategoryCommand);
            if (result==false)
            {
                return BadRequest("Kategori Güncellenemedi.");
            }
            return Ok("Kategori Başarıyla Güncellendi.");
        }

        [HttpDelete("{CategoryId}")]

        public async Task<IActionResult> Delete(Guid CategoryId)
        {
            var result = await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(CategoryId));
            if (result==false)
            {
                return BadRequest("Kategori Silinemedi.");
            }

            return Ok("Kategori Başarıyla Silindi.");
        }
    }
}
