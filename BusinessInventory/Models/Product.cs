using SQLite;
using Microsoft.Maui.Graphics;

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

    [Ignore]
    public Color BorderColor =>
    IsLowStock ? Colors.Red : Colors.Gray;

    [Ignore]
    public Color BackgroundColor =>
    IsLowStock
        ? Color.FromArgb("#2B0000")
        : Colors.Transparent;

    [Ignore]
    public string StockStatus =>
    Quantity <= 0
        ? "Out Of Stock"
        : Quantity <= MinimumStock
            ? "Low Stock"
            : "In Stock";

    [Ignore]
    public Color StatusColor =>
        Quantity <= 0
            ? Colors.Gray
            : Quantity <= MinimumStock
                ? Color.FromArgb("#F97316")
                : Color.FromArgb("#22C55E");


}
