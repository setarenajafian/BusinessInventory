using BusinessInventory.Data;
namespace BusinessInventory.Services;

public class DatabaseService
{
    public AppDatabase Database { get; }

    public DatabaseService()
    {
        string dbPath = Path.Combine(
            FileSystem.AppDataDirectory,
            "business_inventory_v2.db");

        Database = new AppDatabase(dbPath);

        System.Diagnostics.Debug.WriteLine(dbPath);
    }
}
