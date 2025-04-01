using CRUD.Application.MappingInterface;
using CRUD.Application.ProductDTOs;
using CRUD.Application.UseCaseInterface;
using CRUD.Domain.RepositoryInterface;

namespace CRUD.Application.UseCaseImplementation;

public class ProductService(IProductRepository productRepository,
    IProductMapper productMapper) : IProductService
{
    public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
    {
        var products = await productRepository.GetAllAsync();
        if (products == null || !products.Any())
        {
            return Enumerable.Empty<ProductDto>();
        }

        return products.Select(product => productMapper.MapToProductDto(product));
    }

    public async Task<ProductDto?> GetProductByIdAsync(int id)
    {
        var product = await productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return null!;
        }
        return productMapper.MapToProductDto(product);
    }

    public async Task CreateProductAsync(CreateProductDto createDto)
    {
        var product = productMapper.MapToCreateProductEntity(createDto);
        await productRepository.AddAsync(product);
    }

    public async Task DeleteProductAsync(int id)
    {
        await productRepository.DeleteAsync(id);
    }

    public async Task UpdateProductAsync(UpdateProductDto updateDto)
    {
        var product = productMapper.MapToUpdateProductEntity(updateDto);
        await productRepository.UpdateAsync(product);
    }
}
