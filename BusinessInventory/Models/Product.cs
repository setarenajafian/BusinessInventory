using SQLite;

namespace BusinessInventory.Models;

public class Product
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(100)]
    public string Barcode { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public int MinimumStock { get; set; }

    public string Description { get; set; } = string.Empty;

    [Ignore]
    public bool IsLowStock => Quantity <= MinimumStock;
}
