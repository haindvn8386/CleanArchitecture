using CRUD.Application.ProductDTOs;
using CRUD.Domain.ProductEntity;

namespace CRUD.Application.MappingInterface;

public interface IProductMapper
{
    ProductDto MapToProductDto(Product product);
    Product MapToCreateProductEntity(CreateProductDto createDto);
    Product MapToUpdateProductEntity(UpdateProductDto updateDto);
}
