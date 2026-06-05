using BusinessInventory.Models;

namespace BusinessInventory.Services;

public class ProductService
{
    private readonly DatabaseService _databaseService;

    public ProductService(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _databaseService.Database.GetProductsAsync();
    }

    public async Task AddAsync(Product product)
    {
        await _databaseService.Database.AddProductAsync(product);
    }

    public async Task UpdateAsync(Product product)
    {
        await _databaseService.Database.UpdateProductAsync(product);
    }

    public async Task DeleteAsync(Product product)
    {
        await _databaseService.Database.DeleteProductAsync(product.Id);
    }
}
