using BlazorSampleDotNet8.Core;

namespace BlazorSampleDotNet8.UseCases.Products.Interfaces;

public interface IGetProductsByNameUseCase
{
    Task<List<Product>> ExecuteAsync(string name = "");
}