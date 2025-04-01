using CRUD.Application.MappingInterface;
using CRUD.Application.ProductDTOs;
using CRUD.Domain.ProductEntity;

namespace CRUD.Application.MappingImplementaion;

public class ProductMapper : IProductMapper
{
    public ProductDto MapToProductDto(Product product)
    {
        return new ProductDto
        {
            Name = product.Name,
            Price = product.Price,
            Stock = product.Stock
        };
    }

    public Product MapToCreateProductEntity(CreateProductDto createDto)
    {
        return new Product
        {
            Name = createDto.Name,
            Price = createDto.Price,
            Stock = createDto.Stock
        };
    }

    public Product MapToUpdateProductEntity(UpdateProductDto updateDto)
    {
        return new Product
        {
            Id = updateDto.Id,
            Name = updateDto.Name,
            Price = updateDto.Price,
            Stock = updateDto.Stock
        };
    }
}
