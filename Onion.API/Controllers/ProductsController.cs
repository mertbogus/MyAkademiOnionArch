using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Features.Mediator.Queries;

namespace Onion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var products= await _mediator.Send(new GetProductQuery());
            return Ok(products);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateProductCommand createProductCommand)
        {
            var result= await _mediator.Send(createProductCommand);
            if (result==false)
            {
                return BadRequest("Ürün Eklenirken Problem Oluştu.");
            }

            return Created();
        }

        [HttpGet("{ProductId}")]

        public async Task<IActionResult> GetById(Guid ProductId)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(ProductId));
            if (product==null)
            {
                return NotFound("Ürün Bulunamadı.");
            }

            return Ok(product);
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            if (result==false)
            {
                return BadRequest("Ürün Güncellerken Hata Meydana Geldi.");
            }

            return Ok("Ürün Başarıyla Güncellendi.");
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(Guid ProductId)
        {
            var result = await _mediator.Send(new RemoveProductCommand(ProductId));
            if (result==false)
            {
                return BadRequest("Ürün Silinirken Hata Oluştu.");
            }

            return Ok("üRÜN Başarıyla Silindi.");
        }
    }
}
