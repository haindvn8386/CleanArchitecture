using CRUD.Application.ProductDTOs;

namespace CRUD.Application.UseCaseInterface;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetAllProductsAsync();
    Task<ProductDto?> GetProductByIdAsync(int id);
    Task CreateProductAsync(CreateProductDto createDto);
    Task UpdateProductAsync(UpdateProductDto updateDto);
    Task DeleteProductAsync(int id);
}
