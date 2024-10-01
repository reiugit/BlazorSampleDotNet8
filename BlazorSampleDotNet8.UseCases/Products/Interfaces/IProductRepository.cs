using BlazorSampleDotNet8.Core;

namespace BlazorSampleDotNet8.UseCases.Products.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetProductsByNameAsync(string name);
}
