using CRUD.Application.ProductDTOs;
using CRUD.Application.UseCaseInterface;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto productDto)
        {
            await productService.CreateProductAsync(productDto);
            return CreatedAtAction(nameof(GetProductById), new { id = productDto.Name }, productDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto productDto)
        {
            if (id != productDto.Id)
            {
                return BadRequest();
            }
            await productService.UpdateProductAsync(productDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await productService.DeleteProductAsync(id);
            return NoContent();
        }
    }
}
