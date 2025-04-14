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

        public CategoriesController(GetCategoryQueryHandler handler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler)
        {
            _handler = handler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
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
    }
}
