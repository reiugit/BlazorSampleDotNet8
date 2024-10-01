using BlazorSampleDotNet8.Core;
using BlazorSampleDotNet8.UseCases.Products.Interfaces;

namespace BlazorSampleDotNet8.UseCases.Products;

public class GetProductsByNameUseCase(IProductRepository productRepository) : IGetProductsByNameUseCase
{
    public async Task<List<Product>> ExecuteAsync(string name = "")
    {
        return await productRepository.GetProductsByNameAsync(name);
    }
}
