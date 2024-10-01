using BlazorSampleDotNet8.Core;
using BlazorSampleDotNet8.UseCases.Products.Interfaces;

namespace BlazorSampleDotNet8.Data;

public class InMemoryProductRepository : IProductRepository
{
    private readonly List<Product> products =
    [
        new() { Id = 1, Name = "Apple" },
        new() { Id = 2, Name = "Banana" },
        new() { Id = 3, Name = "Cherry" },
        new() { Id = 4, Name = "Date" },
        new() { Id = 5, Name = "Elderberry" },
        new() { Id = 6, Name = "Fig" },
        new() { Id = 7, Name = "Grape" },
        new() { Id = 8, Name = "Honeydew" },
        new() { Id = 9, Name = "Jackfruit" },
        new() { Id = 10, Name = "Kiwi" },
        new() { Id = 11, Name = "Lemon" },
        new() { Id = 12, Name = "Mango" },
        new() { Id = 13, Name = "Nectarine" },
        new() { Id = 14, Name = "Orange" },
        new() { Id = 15, Name = "Papaya" },
    ];

    //please write more fruits


    public async Task<List<Product>> GetProductsByNameAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return await Task.FromResult(products);
        }

        return await Task.FromResult(products
            .Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            .ToList());
    }
}
