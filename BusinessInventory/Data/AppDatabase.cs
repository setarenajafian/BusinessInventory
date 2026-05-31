using BusinessInventory.Models;
using SQLite;
namespace BusinessInventory.Data;

public class AppDatabase
{
    private SQLiteAsyncConnection _database;

    public AppDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);

        _database.CreateTableAsync<Product>().Wait();
    }
    public Task<List<Product>> GetProductsAsync()
    {
        return _database.Table<Product>().ToListAsync();
    }

    public Task<Product> GetProductAsync(int id)
    {
        return _database.Table<Product>()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<int> AddProductAsync(Product product)
    {
        return _database.InsertAsync(product);
    }

    public Task<int> UpdateProductAsync(Product product)
    {
        return _database.UpdateAsync(product);
    }

    public Task<int> DeleteProductAsync(Product product)
    {
        return _database.DeleteAsync(product);
    }
}
